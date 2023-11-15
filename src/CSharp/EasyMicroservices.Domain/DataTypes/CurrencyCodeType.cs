using System.ComponentModel;

namespace EasyMicroservices.Domain.DataTypes
{
    /// <summary>
    /// Enumeration of ISO 4217 currency codes, indexed with their respective ISO 4217 numeric currency codes. 
    /// Only codes support in .Net with RegionInfo objects are listed
    /// </summary>
    public enum CurrencyCodeType : int
    {
        /// <summary>
        /// value is none, Never use the None to return values
        /// </summary>
        None = 0,
        /// <summary>
        /// error value is default
        /// </summary>
        Default = 1,
        /// <summary>
        /// for the filter values from web admin panel you can sent all for types
        /// </summary>
        All = 2,
        /// <summary>
        /// there is other error that is not in the types
        /// </summary>
        Other = 3,
        /// <summary>
        /// the error type is uknown to us
        /// </summary>
        Unknown = 4,
        /// <summary>
        /// there is nothing to show or validate error
        /// </summary>
        Nothing = 5,
        /// <summary>
        /// 
        /// </summary>
        [Description("AED - United Arab Emirates dirham")] AED = 784,
        /// <summary>
        /// 
        /// </summary>
        [Description("AFN - Afghan afghani")] AFN = 971,
        /// <summary>
        /// 
        /// </summary>
        [Description("ALL - Albanian lek")] ALL = 8,
        /// <summary>
        /// 
        /// </summary>
        [Description("AMD - Armenian dram")] AMD = 51,
        /// <summary>
        /// 
        /// </summary>
        [Description("ANG - Netherlands Antillean guilder")] ANG = 532,
        /// <summary>
        /// 
        /// </summary>
        [Description("AOA - Angolan kwanza")] AOA = 973,
        /// <summary>
        /// 
        /// </summary>
        [Description("ARS - Argentine peso")] ARS = 32,
        /// <summary>
        /// 
        /// </summary>
        [Description("AUD - Australian dollar")] AUD = 36,
        /// <summary>
        /// 
        /// </summary>
        [Description("AWG - Aruban florin")] AWG = 533,
        /// <summary>
        /// 
        /// </summary>
        [Description("AZN - Azerbaijani manat")] AZN = 944,
        /// <summary>
        /// 
        /// </summary>
        [Description("BAM - Bosnia and Herzegovina convertible mark")] BAM = 977,
        /// <summary>
        /// 
        /// </summary>
        [Description("BBD - Barbados dollar")] BBD = 52,
        /// <summary>
        /// 
        /// </summary>
        [Description("BDT - Bangladeshi taka")] BDT = 50,
        /// <summary>
        /// 
        /// </summary>
        [Description("BGN - Bulgarian lev")] BGN = 975,
        /// <summary>
        /// 
        /// </summary>
        [Description("BHD - Bahraini dinar")] BHD = 48,
        /// <summary>
        /// 
        /// </summary>
        [Description("BIF - Burundian franc")] BIF = 108,
        /// <summary>
        /// 
        /// </summary>
        [Description("BMD - Bermudian dollar")] BMD = 60,
        /// <summary>
        /// 
        /// </summary>
        [Description("BND - Brunei dollar")] BND = 96,
        /// <summary>
        /// 
        /// </summary>
        [Description("BOB - Boliviano")] BOB = 68,
        /// <summary>
        /// 
        /// </summary>
        [Description("BOV - Bolivian Mvdol (funds code)")] BOV = 984,
        /// <summary>
        /// 
        /// </summary>
        [Description("BRL - Brazilian real")] BRL = 986,
        /// <summary>
        /// 
        /// </summary>
        [Description("BSD - Bahamian dollar")] BSD = 44,
        /// <summary>
        /// 
        /// </summary>
        [Description("BTN - Bhutanese ngultrum")] BTN = 64,
        /// <summary>
        /// 
        /// </summary>
        [Description("BWP - Botswana pula")] BWP = 72,
        /// <summary>
        /// 
        /// </summary>
        [Description("BYN - Belarusian ruble")] BYN = 933,
        /// <summary>
        /// 
        /// </summary>
        [Description("BZD - Belize dollar")] BZD = 84,
        /// <summary>
        /// 
        /// </summary>
        [Description("CAD - Canadian dollar")] CAD = 124,
        /// <summary>
        /// 
        /// </summary>
        [Description("CDF - Congolese franc")] CDF = 976,
        /// <summary>
        /// 
        /// </summary>
        [Description("CHE - WIR euro (complementary currency)")] CHE = 947,
        /// <summary>
        /// 
        /// </summary>
        [Description("CHF - Swiss franc")] CHF = 756,
        /// <summary>
        /// 
        /// </summary>
        [Description("CHW - WIR franc (complementary currency)")] CHW = 948,
        /// <summary>
        /// 
        /// </summary>
        [Description("CLF - Unidad de Fomento (funds code)")] CLF = 990,
        /// <summary>
        /// 
        /// </summary>
        [Description("CLP - Chilean peso")] CLP = 152,
        /// <summary>
        /// 
        /// </summary>
        [Description("COP - Colombian peso")] COP = 170,
        /// <summary>
        /// 
        /// </summary>
        [Description("COU - Unidad de Valor Real (UVR) (funds code)")] COU = 970,
        /// <summary>
        /// 
        /// </summary>
        [Description("CRC - Costa Rican colon")] CRC = 188,
        /// <summary>
        /// 
        /// </summary>
        [Description("CUC - Cuban convertible peso")] CUC = 931,
        /// <summary>
        /// 
        /// </summary>
        [Description("CUP - Cuban peso")] CUP = 192,
        /// <summary>
        /// 
        /// </summary>
        [Description("CVE - Cape Verdean escudo")] CVE = 132,
        /// <summary>
        /// 
        /// </summary>
        [Description("CZK - Czech koruna")] CZK = 203,
        /// <summary>
        /// 
        /// </summary>
        [Description("DJF - Djiboutian franc")] DJF = 262,
        /// <summary>
        /// 
        /// </summary>
        [Description("DKK - Danish krone")] DKK = 208,
        /// <summary>
        /// 
        /// </summary>
        [Description("DOP - Dominican peso")] DOP = 214,
        /// <summary>
        /// 
        /// </summary>
        [Description("DZD - Algerian dinar")] DZD = 12,
        /// <summary>
        /// 
        /// </summary>
        [Description("EGP - Egyptian pound")] EGP = 818,
        /// <summary>
        /// 
        /// </summary>
        [Description("ERN - Eritrean nakfa")] ERN = 232,
        /// <summary>
        /// 
        /// </summary>
        [Description("ETB - Ethiopian birr")] ETB = 230,
        /// <summary>
        /// 
        /// </summary>
        [Description("EUR - Euro")] EUR = 978,
        /// <summary>
        /// 
        /// </summary>
        [Description("FJD - Fiji dollar")] FJD = 242,
        /// <summary>
        /// 
        /// </summary>
        [Description("FKP - Falkland Islands pound")] FKP = 238,
        /// <summary>
        /// 
        /// </summary>
        [Description("GBP - Pound sterling")] GBP = 826,
        /// <summary>
        /// 
        /// </summary>
        [Description("GEL - Georgian lari")] GEL = 981,
        /// <summary>
        /// 
        /// </summary>
        [Description("GHS - Ghanaian cedi")] GHS = 936,
        /// <summary>
        /// 
        /// </summary>
        [Description("GIP - Gibraltar pound")] GIP = 292,
        /// <summary>
        /// 
        /// </summary>
        [Description("GMD - Gambian dalasi")] GMD = 270,
        /// <summary>
        /// 
        /// </summary>
        [Description("GNF - Guinean franc")] GNF = 324,
        /// <summary>
        /// 
        /// </summary>
        [Description("GTQ - Guatemalan quetzal")] GTQ = 320,
        /// <summary>
        /// 
        /// </summary>
        [Description("GYD - Guyanese dollar")] GYD = 328,
        /// <summary>
        /// 
        /// </summary>
        [Description("HKD - Hong Kong dollar")] HKD = 344,
        /// <summary>
        /// 
        /// </summary>
        [Description("HNL - Honduran lempira")] HNL = 340,
        /// <summary>
        /// 
        /// </summary>
        [Description("HRK - Croatian kuna")] HRK = 191,
        /// <summary>
        /// 
        /// </summary>
        [Description("HTG - Haitian gourde")] HTG = 332,
        /// <summary>
        /// 
        /// </summary>
        [Description("HUF - Hungarian forint")] HUF = 348,
        /// <summary>
        /// 
        /// </summary>
        [Description("IDR - Indonesian rupiah")] IDR = 360,
        /// <summary>
        /// 
        /// </summary>
        [Description("ILS - Israeli new shekel")] ILS = 376,
        /// <summary>
        /// 
        /// </summary>
        [Description("INR - Indian rupee")] INR = 356,
        /// <summary>
        /// 
        /// </summary>
        [Description("IQD - Iraqi dinar")] IQD = 368,
        /// <summary>
        /// 
        /// </summary>
        [Description("IRR - Iranian rial")] IRR = 364,
        /// <summary>
        /// 
        /// </summary>
        [Description("ISK - Icelandic króna (plural: krónur)")] ISK = 352,
        /// <summary>
        /// 
        /// </summary>
        [Description("JMD - Jamaican dollar")] JMD = 388,
        /// <summary>
        /// 
        /// </summary>
        [Description("JOD - Jordanian dinar")] JOD = 400,
        /// <summary>
        /// 
        /// </summary>
        [Description("JPY - Japanese yen")] JPY = 392,
        /// <summary>
        /// 
        /// </summary>
        [Description("KES - Kenyan shilling")] KES = 404,
        /// <summary>
        /// 
        /// </summary>
        [Description("KGS - Kyrgyzstani som")] KGS = 417,
        /// <summary>
        /// 
        /// </summary>
        [Description("KHR - Cambodian riel")] KHR = 116,
        /// <summary>
        /// 
        /// </summary>
        [Description("KMF - Comoro franc")] KMF = 174,
        /// <summary>
        /// 
        /// </summary>
        [Description("KPW - North Korean won")] KPW = 408,
        /// <summary>
        /// 
        /// </summary>
        [Description("KRW - South Korean won")] KRW = 410,
        /// <summary>
        /// 
        /// </summary>
        [Description("KWD - Kuwaiti dinar")] KWD = 414,
        /// <summary>
        /// 
        /// </summary>
        [Description("KYD - Cayman Islands dollar")] KYD = 136,
        /// <summary>
        /// 
        /// </summary>
        [Description("KZT - Kazakhstani tenge")] KZT = 398,
        /// <summary>
        /// 
        /// </summary>
        [Description("LAK - Lao kip")] LAK = 418,
        /// <summary>
        /// 
        /// </summary>
        [Description("LBP - Lebanese pound")] LBP = 422,
        /// <summary>
        /// 
        /// </summary>
        [Description("LKR - Sri Lankan rupee")] LKR = 144,
        /// <summary>
        /// 
        /// </summary>
        [Description("LRD - Liberian dollar")] LRD = 430,
        /// <summary>
        /// 
        /// </summary>
        [Description("LSL - Lesotho loti")] LSL = 426,
        /// <summary>
        /// 
        /// </summary>
        [Description("LYD - Libyan dinar")] LYD = 434,
        /// <summary>
        /// 
        /// </summary>
        [Description("MAD - Moroccan dirham")] MAD = 504,
        /// <summary>
        /// 
        /// </summary>
        [Description("MDL - Moldovan leu")] MDL = 498,
        /// <summary>
        /// 
        /// </summary>
        [Description("MGA - Malagasy ariary")] MGA = 969,
        /// <summary>
        /// 
        /// </summary>
        [Description("MKD - Macedonian denar")] MKD = 807,
        /// <summary>
        /// 
        /// </summary>
        [Description("MMK - Myanmar kyat")] MMK = 104,
        /// <summary>
        /// 
        /// </summary>
        [Description("MNT - Mongolian tögrög")] MNT = 496,
        /// <summary>
        /// 
        /// </summary>
        [Description("MOP - Macanese pataca")] MOP = 446,
        /// <summary>
        /// 
        /// </summary>
        [Description("MRU - Mauritanian ouguiya")] MRU = 929,
        /// <summary>
        /// 
        /// </summary>
        [Description("MUR - Mauritian rupee")] MUR = 480,
        /// <summary>
        /// 
        /// </summary>
        [Description("MVR - Maldivian rufiyaa")] MVR = 462,
        /// <summary>
        /// 
        /// </summary>
        [Description("MWK - Malawian kwacha")] MWK = 454,
        /// <summary>
        /// 
        /// </summary>
        [Description("MXN - Mexican peso")] MXN = 484,
        /// <summary>
        /// 
        /// </summary>
        [Description("MXV - Mexican Unidad de Inversion (UDI) (funds code)")] MXV = 979,
        /// <summary>
        /// 
        /// </summary>
        [Description("MYR - Malaysian ringgit")] MYR = 458,
        /// <summary>
        /// 
        /// </summary>
        [Description("MZN - Mozambican metical")] MZN = 943,
        /// <summary>
        /// 
        /// </summary>
        [Description("NAD - Namibian dollar")] NAD = 516,
        /// <summary>
        /// 
        /// </summary>
        [Description("NGN - Nigerian naira")] NGN = 566,
        /// <summary>
        /// 
        /// </summary>
        [Description("NIO - Nicaraguan córdoba")] NIO = 558,
        /// <summary>
        /// 
        /// </summary>
        [Description("NOK - Norwegian krone")] NOK = 578,
        /// <summary>
        /// 
        /// </summary>
        [Description("NPR - Nepalese rupee")] NPR = 524,
        /// <summary>
        /// 
        /// </summary>
        [Description("NZD - New Zealand dollar")] NZD = 554,
        /// <summary>
        /// 
        /// </summary>
        [Description("OMR - Omani rial")] OMR = 512,
        /// <summary>
        /// 
        /// </summary>
        [Description("PAB - Panamanian balboa")] PAB = 590,
        /// <summary>
        /// 
        /// </summary>
        [Description("PEN - Peruvian sol")] PEN = 604,
        /// <summary>
        /// 
        /// </summary>
        [Description("PGK - Papua New Guinean kina")] PGK = 598,
        /// <summary>
        /// 
        /// </summary>
        [Description("PHP - Philippine peso")] PHP = 608,
        /// <summary>
        /// 
        /// </summary>
        [Description("PKR - Pakistani rupee")] PKR = 586,
        /// <summary>
        /// 
        /// </summary>
        [Description("PLN - Polish złoty")] PLN = 985,
        /// <summary>
        /// 
        /// </summary>
        [Description("PYG - Paraguayan guaraní")] PYG = 600,
        /// <summary>
        /// 
        /// </summary>
        [Description("QAR - Qatari riyal")] QAR = 634,
        /// <summary>
        /// 
        /// </summary>
        [Description("RON - Romanian leu")] RON = 946,
        /// <summary>
        /// 
        /// </summary>
        [Description("RSD - Serbian dinar")] RSD = 941,
        /// <summary>
        /// 
        /// </summary>
        [Description("CNY - Renminbi[14]")] CNY = 156,
        /// <summary>
        /// 
        /// </summary>
        [Description("RUB - Russian ruble")] RUB = 643,
        /// <summary>
        /// 
        /// </summary>
        [Description("RWF - Rwandan franc")] RWF = 646,
        /// <summary>
        /// 
        /// </summary>
        [Description("SAR - Saudi riyal")] SAR = 682,
        /// <summary>
        /// 
        /// </summary>
        [Description("SBD - Solomon Islands dollar")] SBD = 90,
        /// <summary>
        /// 
        /// </summary>
        [Description("SCR - Seychelles rupee")] SCR = 690,
        /// <summary>
        /// 
        /// </summary>
        [Description("SDG - Sudanese pound")] SDG = 938,
        /// <summary>
        /// 
        /// </summary>
        [Description("SEK - Swedish krona (plural: kronor)")] SEK = 752,
        /// <summary>
        /// 
        /// </summary>
        [Description("SGD - Singapore dollar")] SGD = 702,
        /// <summary>
        /// 
        /// </summary>
        [Description("SHP - Saint Helena pound")] SHP = 654,
        /// <summary>
        /// 
        /// </summary>
        [Description("SLL - Sierra Leonean leone")] SLL = 694,
        /// <summary>
        /// 
        /// </summary>
        [Description("SLE - Sierra Leonean leone")] SLE = 925,
        /// <summary>
        /// 
        /// </summary>
        [Description("SOS - Somali shilling")] SOS = 706,
        /// <summary>
        /// 
        /// </summary>
        [Description("SRD - Surinamese dollar")] SRD = 968,
        /// <summary>
        /// 
        /// </summary>
        [Description("SSP - South Sudanese pound")] SSP = 728,
        /// <summary>
        /// 
        /// </summary>
        [Description("STN - São Tomé and Príncipe dobra")] STN = 930,
        /// <summary>
        /// 
        /// </summary>
        [Description("SVC - Salvadoran colón")] SVC = 222,
        /// <summary>
        /// 
        /// </summary>
        [Description("SYP - Syrian pound")] SYP = 760,
        /// <summary>
        /// 
        /// </summary>
        [Description("SZL - Swazi lilangeni")] SZL = 748,
        /// <summary>
        /// 
        /// </summary>
        [Description("THB - Thai baht")] THB = 764,
        /// <summary>
        /// 
        /// </summary>
        [Description("TJS - Tajikistani somoni")] TJS = 972,
        /// <summary>
        /// 
        /// </summary>
        [Description("TMT - Turkmenistan manat")] TMT = 934,
        /// <summary>
        /// 
        /// </summary>
        [Description("TND - Tunisian dinar")] TND = 788,
        /// <summary>
        /// 
        /// </summary>
        [Description("TOP - Tongan paʻanga")] TOP = 776,
        /// <summary>
        /// 
        /// </summary>
        [Description("TRY - Turkish lira")] TRY = 949,
        /// <summary>
        /// 
        /// </summary>
        [Description("TTD - Trinidad and Tobago dollar")] TTD = 780,
        /// <summary>
        /// 
        /// </summary>
        [Description("TWD - New Taiwan dollar")] TWD = 901,
        /// <summary>
        /// 
        /// </summary>
        [Description("TZS - Tanzanian shilling")] TZS = 834,
        /// <summary>
        /// 
        /// </summary>
        [Description("UAH - Ukrainian hryvnia")] UAH = 980,
        /// <summary>
        /// 
        /// </summary>
        [Description("UGX - Ugandan shilling")] UGX = 800,
        /// <summary>
        /// 
        /// </summary>
        [Description("USD - United States dollar")] USD = 840,
        /// <summary>
        /// 
        /// </summary>
        [Description("USN - United States dollar (next day) (funds code)")] USN = 997,
        /// <summary>
        /// 
        /// </summary>
        [Description("UYI - Uruguay Peso en Unidades Indexadas (URUIURUI) (funds code)")] UYI = 940,
        /// <summary>
        /// 
        /// </summary>
        [Description("UYU - Uruguayan peso")] UYU = 858,
        /// <summary>
        /// 
        /// </summary>
        [Description("UYW - Unidad previsional")] UYW = 927,
        /// <summary>
        /// 
        /// </summary>
        [Description("UZS - Uzbekistan som")] UZS = 860,
        /// <summary>
        /// 
        /// </summary>
        [Description("VED - Venezuelan bolívar digital")] VED = 926,
        /// <summary>
        /// 
        /// </summary>
        [Description("VES - Venezuelan bolívar soberano")] VES = 928,
        /// <summary>
        /// 
        /// </summary>
        [Description("VND - Vietnamese đồng")] VND = 704,
        /// <summary>
        /// 
        /// </summary>
        [Description("VUV - Vanuatu vatu")] VUV = 548,
        /// <summary>
        /// 
        /// </summary>
        [Description("WST - Samoan tala")] WST = 882,
        /// <summary>
        /// 
        /// </summary>
        [Description("XAF - CFA franc BEAC")] XAF = 950,
        /// <summary>
        /// 
        /// </summary>
        [Description("XAG - Silver (one troy ounce)")] XAG = 961,
        /// <summary>
        /// 
        /// </summary>
        [Description("XAU - Gold (one troy ounce)")] XAU = 959,
        /// <summary>
        /// 
        /// </summary>
        [Description("XBA - European Composite Unit (EURCO) (bond market unit)")] XBA = 955,
        /// <summary>
        /// 
        /// </summary>
        [Description("XBB - European Monetary Unit (E.M.U.-6) (bond market unit)")] XBB = 956,
        /// <summary>
        /// 
        /// </summary>
        [Description("XBC - European Unit of Account 9 (E.U.A.-9) (bond market unit)")] XBC = 957,
        /// <summary>
        /// 
        /// </summary>
        [Description("XBD - European Unit of Account 17 (E.U.A.-17) (bond market unit)")] XBD = 958,
        /// <summary>
        /// 
        /// </summary>
        [Description("XCD - East Caribbean dollar")] XCD = 951,
        /// <summary>
        /// 
        /// </summary>
        [Description("XDR - Special drawing rights")] XDR = 960,
        /// <summary>
        /// 
        /// </summary>
        [Description("XOF - CFA franc BCEAO")] XOF = 952,
        /// <summary>
        /// 
        /// </summary>
        [Description("XPD - Palladium (one troy ounce)")] XPD = 964,
        /// <summary>
        /// 
        /// </summary>
        [Description("XPF - CFP franc (franc Pacifique)")] XPF = 953,
        /// <summary>
        /// 
        /// </summary>
        [Description("XPT - Platinum (one troy ounce)")] XPT = 962,
        /// <summary>
        /// 
        /// </summary>
        [Description("XSU - SUCRE")] XSU = 994,
        /// <summary>
        /// 
        /// </summary>
        [Description("XTS - Code reserved for testing")] XTS = 963,
        /// <summary>
        /// 
        /// </summary>
        [Description("XUA - ADB Unit of Account")] XUA = 965,
        /// <summary>
        /// 
        /// </summary>
        [Description("XXX - No currency")] XXX = 999,
        /// <summary>
        /// 
        /// </summary>
        [Description("YER - Yemeni rial")] YER = 886,
        /// <summary>
        /// 
        /// </summary>
        [Description("ZAR - South African rand")] ZAR = 710,
        /// <summary>
        /// 
        /// </summary>
        [Description("ZMW - Zambian kwacha")] ZMW = 967,
        /// <summary>
        /// 
        /// </summary>
        [Description("ZWL - Zimbabwean dollar")] ZWL = 932,
    }
}
