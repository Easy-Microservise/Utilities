using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace EasyMicroservices.Utilities.Collections.Generic
{
    /// <summary>
    /// 
    /// </summary>
    public class ConcurrentTreeDictionary
    {
        private ConcurrentDictionary<object, ConcurrentTreeDictionary> Items { get; set; } = new ConcurrentDictionary<object, ConcurrentTreeDictionary>();
        /// <summary>
        /// use this object for null values
        /// </summary>
        private readonly static object nullObject = new();
        /// <summary>
        /// use this when you don't know what is the current value
        /// </summary>
        public readonly static object DefaultObject = new();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public void TryAdd(params object[] items)
        {
            items.ThrowIfNull(nameof(items));
            if (items.Length > 0)
            {
                var firstValue = items[0];
                if (firstValue == null)
                    firstValue = nullObject;
                if (Items.TryGetValue(firstValue, out ConcurrentTreeDictionary concurrentTree))
                    concurrentTree.TryAdd(items.Skip(1).ToArray());
                else
                {
                    var concurrentTreeDictionary = new ConcurrentTreeDictionary();
                    concurrentTreeDictionary.TryAdd(items.Skip(1).ToArray());
                    Items.TryAdd(firstValue, concurrentTreeDictionary);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestedValues"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryGetValue(object[] requestedValues, out IList<object> result)
        {
            if (requestedValues.IsEmpty())
            {
                result = null;
                return false;
            }
            var items = new List<object>();
            GetValue(requestedValues, items);
            result = items;
            return items.Count > 0;
        }

        void GetValue(object[] requestedValues, List<object> output)
        {
            if (requestedValues.Length > 0)
            {
                var firstValue = requestedValues[0];
                if (firstValue == null)
                {
                    if (Items.TryGetValue(nullObject, out ConcurrentTreeDictionary concurrentTree))
                    {
                        output.Add(null);
                        concurrentTree.GetValue(requestedValues.Skip(1).ToArray(), output);
                    }
                    else
                        output.Clear();
                }
                else if (Items.TryGetValue(firstValue, out ConcurrentTreeDictionary concurrentTree))
                {
                    output.Add(firstValue);
                    concurrentTree.GetValue(requestedValues.Skip(1).ToArray(), output);
                }
                else if (Items.TryGetValue(nullObject, out concurrentTree))
                {
                    output.Add(null);
                    concurrentTree.GetValue(requestedValues.Skip(1).ToArray(), output);
                }
                else
                    output.Clear();
            }
            else
                GetAllDirectChildren(output);
        }

        void GetAllDirectChildren(List<object> output)
        {
            if (Items.Count > 0)
            {
                var keyValue = Items.FirstOrDefault();
                output.Add(keyValue.Key);
                keyValue.Value.GetAllDirectChildren(output);
            }
        }
    }
}
