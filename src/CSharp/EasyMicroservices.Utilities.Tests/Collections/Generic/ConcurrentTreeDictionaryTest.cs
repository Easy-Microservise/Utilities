using EasyMicroservices.Utilities.Collections.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace EasyMicroservices.Utilities.Tests.Collections.Generic
{
    public class ConcurrentTreeDictionaryTest
    {
        [Theory]
        [InlineData(new object[] { "ServiceA", "MethodA", true }, new object[] { "ServiceA", "MethodA" }, new object[] { "ServiceA", "MethodA", true })]
        [InlineData(new object[] { "ServiceA", "MethodA", false }, new object[] { "ServiceA", "MethodA" }, new object[] { "ServiceA", "MethodA", false })]
        [InlineData(new object[] { "ServiceA", null, true }, new object[] { "ServiceA", "MethodA" }, new object[] { "ServiceA", null, true })]
        [InlineData(new object[] { null, null, true }, new object[] { "ServiceA", "MethodA" }, new object[] { null, null, true })]
        [InlineData(new object[] { null, null, true }, new object[] { null, "MethodA" }, new object[] { null, null, true })]
        [InlineData(new object[] { null, null, true }, new object[] { null, null }, new object[] { null, null, true })]
        public void SimpleExample(object[] items, object[] query, object[] expectResult)
        {
            ConcurrentTreeDictionary dictionary = new();
            dictionary.TryAdd(items);
            Assert.True(dictionary.TryGetValue(query, out var result));
            Assert.Equal(result, expectResult);
        }

        [Theory]
        [ClassData(typeof(TreeDictionaryData))]
        public void ComplexExample(UserPermissionInfo[] permissions, UserPermissionQueryExpect[] queryExpect)
        {
            ConcurrentTreeDictionary dictionary = new();
            foreach (var item in permissions)
            {
                dictionary.TryAdd(item.MicroserviceName, item.ServiceName, item.MethodName, item.IsAdmin, item.Name, item.HasAccess, item.CreationDateTime);
            }
            foreach (var item in queryExpect)
            {
                var obj = new object[]
                {
                    item.Query.MicroserviceName,
                    item.Query.ServiceName,
                    item.Query.MethodName,
                    item.Query.IsAdmin
                };
                if (item.IsNull)
                {
                    Assert.False(dictionary.TryGetValue(obj, out var result));
                }
                else
                {
                    Assert.True(dictionary.TryGetValue(obj, out var result));
                    Assert.Equal(result[0], item.Expect.MicroserviceName);
                    Assert.Equal(result[1], item.Expect.ServiceName);
                    Assert.Equal(result[2], item.Expect.MethodName);
                    Assert.Equal(result[3], item.Expect.IsAdmin);
                    Assert.Equal(result[4], item.Expect.Name);
                    Assert.Equal(result[5], item.Expect.HasAccess);
                    Assert.Equal(result[6], item.Expect.CreationDateTime);
                }
            }
        }
    }

    public class TreeDictionaryData : IEnumerable<object[]>
    {
        private List<object[]> Data
        {
            get

            {
                var result = new List<object[]>();
                var scenario = new UserPermissionInfo[]
                {
                    new UserPermissionInfo()
                    {
                         Name = "Base",
                         MicroserviceName = null,
                         ServiceName = null,
                         MethodName = null,
                         HasAccess = false,
                         IsAdmin = true,
                         CreationDateTime = DateTime.Now.Date
                    },
                    new UserPermissionInfo()
                    {
                         Name = "PaymentTop",
                         MicroserviceName = "Payment",
                         ServiceName = null,
                         MethodName = null,
                         HasAccess = true,
                         IsAdmin = false,
                         CreationDateTime = DateTime.Now.Date.AddDays(1)
                    },
                    new UserPermissionInfo()
                    {
                         Name = "Admin",
                         MicroserviceName = "Payment",
                         ServiceName = "AdminService",
                         MethodName = null,
                         HasAccess = false,
                         IsAdmin = false,
                         CreationDateTime = DateTime.Now.Date.AddDays(2)
                    },
                    new UserPermissionInfo()
                    {
                         Name = "Orders",
                         MicroserviceName = "Payment",
                         ServiceName = "Orders",
                         MethodName = "GetAll",
                         HasAccess = true,
                         IsAdmin = false,
                         CreationDateTime = DateTime.Now.Date.AddDays(3)
                    },
                    new UserPermissionInfo()
                    {
                         Name = "Orders",
                         MicroserviceName = "Payment",
                         ServiceName = "Orders",
                         MethodName = "GetAll2",
                         HasAccess = false,
                         IsAdmin = false,
                         CreationDateTime = DateTime.Now.Date.AddDays(3)
                    }
                };
                result.Add(new object[]
                {
                    scenario,
                    new UserPermissionQueryExpect[]
                    {
                        new UserPermissionQueryExpect()
                        {
                             Query = new UserPermissionInfo()
                             {
                                 Name = "Base",
                                 MicroserviceName = null,
                                 ServiceName = null,
                                 MethodName = null,
                                 HasAccess = false,
                                 IsAdmin = true,
                                 CreationDateTime = DateTime.Now.Date,
                             },
                             Expect = new UserPermissionInfo()
                             {
                                 Name = "Base",
                                 MicroserviceName = null,
                                 ServiceName = null,
                                 MethodName = null,
                                 HasAccess = false,
                                 IsAdmin = true,
                                 CreationDateTime = DateTime.Now.Date,
                             },
                             IsNull = false,
                        }
                    }
                });
                result.Add(new object[]
                {
                    scenario,
                    new UserPermissionQueryExpect[]
                    {
                        new UserPermissionQueryExpect()
                        {
                             Query = new UserPermissionInfo()
                             {
                                 Name = "PaymentTop",
                                 MicroserviceName = "Payment",
                                 ServiceName = null,
                                 MethodName = null,
                                 HasAccess = true,
                                 IsAdmin = false,
                                 CreationDateTime = DateTime.Now.Date.AddDays(1),
                             },
                             Expect = new UserPermissionInfo()
                             {
                                 Name = "PaymentTop",
                                 MicroserviceName = "Payment",
                                 ServiceName = null,
                                 MethodName = null,
                                 HasAccess = true,
                                 IsAdmin = false,
                                 CreationDateTime = DateTime.Now.Date.AddDays(1),
                             },
                             IsNull = false,
                        }
                    }
                });
                result.Add(new object[]
                {
                    scenario,
                    new UserPermissionQueryExpect[]
                    {
                        new UserPermissionQueryExpect()
                        {
                             Query = new UserPermissionInfo()
                             {
                                 Name = null,
                                 MicroserviceName = "Payment2",
                                 ServiceName = null,
                                 MethodName = null,
                                 HasAccess = false,
                                 IsAdmin = true,
                                 CreationDateTime = DateTime.Now.Date,
                             },
                             Expect = new UserPermissionInfo()
                             {
                                 Name = "Base",
                                 MicroserviceName = null,
                                 ServiceName = null,
                                 MethodName = null,
                                 HasAccess = false,
                                 IsAdmin = true,
                                 CreationDateTime = DateTime.Now.Date,
                             },
                             IsNull = false,
                        }
                    }
                });
                result.Add(new object[]
                {
                    scenario,
                    new UserPermissionQueryExpect[]
                    {
                        new UserPermissionQueryExpect()
                        {
                             Query = new UserPermissionInfo()
                             {
                                 Name = null,
                                 MicroserviceName = "Payment3",
                                 ServiceName = null,
                                 MethodName = null,
                                 HasAccess = false,
                                 IsAdmin = null,
                                 CreationDateTime = DateTime.Now.Date,
                             },
                             IsNull = true,
                        }
                    }
                });
                result.Add(new object[]
                {
                    scenario,
                    new UserPermissionQueryExpect[]
                    {
                        new UserPermissionQueryExpect()
                        {
                             Query = new UserPermissionInfo()
                             {
                                  Name = "Orders",
                                  MicroserviceName = "Payment",
                                  ServiceName = "Orders",
                                  MethodName = "GetAll",
                                  IsAdmin = false,
                                  CreationDateTime = DateTime.Now.Date.AddDays(3)
                             },
                             Expect = new UserPermissionInfo()
                             {
                                  Name = "Orders",
                                  MicroserviceName = "Payment",
                                  ServiceName = "Orders",
                                  MethodName = "GetAll",
                                  IsAdmin = false,
                                  HasAccess = true,
                                  CreationDateTime = DateTime.Now.Date.AddDays(3)
                             },
                             IsNull = false,
                        },
                        new UserPermissionQueryExpect()
                        {
                             Query = new UserPermissionInfo()
                             {
                                  Name = "Orders",
                                  MicroserviceName = "Payment",
                                  ServiceName = "Orders",
                                  MethodName = "GetAll2",
                                  IsAdmin = false,
                                  CreationDateTime = DateTime.Now.Date.AddDays(3)
                             },
                             Expect = new UserPermissionInfo()
                             {
                                  Name = "Orders",
                                  MicroserviceName = "Payment",
                                  ServiceName = "Orders",
                                  MethodName = "GetAll2",
                                  IsAdmin = false,
                                  HasAccess = false,
                                  CreationDateTime = DateTime.Now.Date.AddDays(3)
                             },
                             IsNull = false,
                        },
                        new UserPermissionQueryExpect()
                        {
                             Query = new UserPermissionInfo()
                             {
                                  Name = "Orders",
                                  MicroserviceName = null,
                                  ServiceName = null,
                                  MethodName = "GetAll",
                                  IsAdmin = false,
                                  CreationDateTime = DateTime.Now.Date.AddDays(3)
                             },
                             IsNull = true,
                        }
                    }
                });
                return result;
            }
        }

        public IEnumerator<object[]> GetEnumerator()
        { return Data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }

    public class UserPermissionInfo : IXunitSerializable
    {
        public string MicroserviceName { get; set; }
        public string ServiceName { get; set; }
        public string MethodName { get; set; }
        public bool? IsAdmin { get; set; }

        public string Name { get; set; }
        public bool HasAccess { get; set; }
        public DateTime CreationDateTime { get; set; }

        public void Deserialize(IXunitSerializationInfo info)
        {
            Deserialize(nameof(UserPermissionInfo), info);
        }

        public void Serialize(IXunitSerializationInfo info)
        {
            Serialize(nameof(UserPermissionInfo), info);
        }

        public void Deserialize(string name, IXunitSerializationInfo info)
        {
            MicroserviceName = info.GetValue<string>(name + nameof(MicroserviceName));
            ServiceName = info.GetValue<string>(name + nameof(ServiceName));
            MethodName = info.GetValue<string>(name + nameof(MethodName));
            IsAdmin = info.GetValue<bool?>(name + nameof(IsAdmin));
            Name = info.GetValue<string>(name + nameof(Name));
            HasAccess = info.GetValue<bool>(name + nameof(HasAccess));
            CreationDateTime = info.GetValue<DateTime>(name + nameof(CreationDateTime));
        }

        public void Serialize(string name, IXunitSerializationInfo info)
        {
            info.AddValue(name + nameof(MicroserviceName), MicroserviceName);
            info.AddValue(name + nameof(ServiceName), ServiceName);
            info.AddValue(name + nameof(MethodName), MethodName);
            info.AddValue(name + nameof(IsAdmin), IsAdmin);
            info.AddValue(name + nameof(Name), Name);
            info.AddValue(name + nameof(HasAccess), HasAccess);
            info.AddValue(name + nameof(CreationDateTime), CreationDateTime);
        }
    }

    public class UserPermissionQueryExpect : IXunitSerializable
    {
        public UserPermissionInfo Query { get; set; }
        public UserPermissionInfo Expect { get; set; }

        public bool IsNull { get; set; }

        public void Deserialize(IXunitSerializationInfo info)
        {
            Query = new UserPermissionInfo();
            Query.Deserialize(nameof(Query), info);
            Expect = new UserPermissionInfo();
            Expect.Deserialize(nameof(Expect), info);
            IsNull = info.GetValue<bool>(nameof(IsNull));
        }

        public void Serialize(IXunitSerializationInfo info)
        {
            Query.Serialize(nameof(Query), info);
            if (Expect != null)
                Expect.Serialize(nameof(Expect), info);
            info.AddValue(nameof(IsNull), IsNull);
        }
    }
}
