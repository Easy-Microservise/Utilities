namespace EasyMicroservices.Domain.DataTypes
{
    /// <summary>
    /// Country Name (ISO)
    /// Short Name / Code (2 Chr. ISO)
    /// Numeric Reporting Code ISO
    /// </summary>
    public enum NationalityType
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
        /// Afghanistan
        /// AF
        /// 4
        /// </summary>
        AFG = 6,
        /// <summary>
        /// Albania
        /// AL
        /// 8
        /// </summary>
        ALB = 7,
        /// <summary>
        /// Algeria
        /// DZ
        /// 12
        /// </summary>
        DZA = 8,
        /// <summary>
        /// American Samoa
        /// AS
        /// 16
        /// </summary>
        ASM = 9,
        /// <summary>
        /// Andorra
        /// AD
        /// 20
        /// </summary>
        AND = 10,
        /// <summary>
        /// Angola
        /// AO
        /// 24
        /// </summary>
        AGO = 11,
        /// <summary>
        /// Anguilla
        /// AI
        /// 660
        /// </summary>
        AIA = 12,
        /// <summary>
        /// Antarctica
        /// AQ
        /// 10
        /// </summary>
        ATA = 13,
        /// <summary>
        /// Antigua and Barbuda
        /// AG
        /// 28
        /// </summary>
        ATG = 14,
        /// <summary>
        /// Argentina
        /// AR
        /// 32
        /// </summary>
        ARG = 15,
        /// <summary>
        /// Armenia
        /// AM
        /// 51
        /// </summary>
        ARM = 16,
        /// <summary>
        /// Aruba
        /// AW
        /// 533
        /// </summary>
        ABW = 17,
        /// <summary>
        /// Australia
        /// AU
        /// 36
        /// </summary>
        AUS = 18,
        /// <summary>
        /// Austria
        /// AT
        /// 40
        /// </summary>
        AUT = 19,
        /// <summary>
        /// Azerbaijan
        /// AZ
        /// 31
        /// </summary>
        AZE = 20,
        /// <summary>
        /// Bahamas (the)
        /// BS
        /// 44
        /// </summary>
        BHS = 21,
        /// <summary>
        /// Bahrain
        /// BH
        /// 48
        /// </summary>
        BHR = 22,
        /// <summary>
        /// Bangladesh
        /// BD
        /// 50
        /// </summary>
        BGD = 23,
        /// <summary>
        /// Barbados
        /// BB
        /// 52
        /// </summary>
        BRB = 24,
        /// <summary>
        /// Belarus
        /// BY
        /// 112
        /// </summary>
        BLR = 25,
        /// <summary>
        /// Belgium
        /// BE
        /// 56
        /// </summary>
        BEL = 26,
        /// <summary>
        /// Belize
        /// BZ
        /// 84
        /// </summary>
        BLZ = 27,
        /// <summary>
        /// Benin
        /// BJ
        /// 204
        /// </summary>
        BEN = 28,
        /// <summary>
        /// Bermuda
        /// BM
        /// 60
        /// </summary>
        BMU = 29,
        /// <summary>
        /// Bhutan
        /// BT
        /// 64
        /// </summary>
        BTN = 30,
        /// <summary>
        /// Bolivia (Plurinational State of)
        /// BO
        /// 68
        /// </summary>
        BOL = 31,
        /// <summary>
        /// Bonaire Sint Eustatius and Saba
        /// BQ
        /// 535
        /// </summary>
        BES = 32,
        /// <summary>
        /// Bosnia and Herzegovina
        /// BA
        /// 70
        /// </summary>
        BIH = 33,
        /// <summary>
        /// Botswana
        /// BW
        /// 72
        /// </summary>
        BWA = 34,
        /// <summary>
        /// Bouvet Island
        /// BV
        /// 74
        /// </summary>
        BVT = 35,
        /// <summary>
        /// Brazil
        /// BR
        /// 76
        /// </summary>
        BRA = 36,
        /// <summary>
        /// British Indian Ocean Territory (the)
        /// IO
        /// 86
        /// </summary>
        IOT = 37,
        /// <summary>
        /// Brunei Darussalam
        /// BN
        /// 96
        /// </summary>
        BRN = 38,
        /// <summary>
        /// Bulgaria
        /// BG
        /// 100
        /// </summary>
        BGR = 39,
        /// <summary>
        /// Burkina Faso
        /// BF
        /// 854
        /// </summary>
        BFA = 40,
        /// <summary>
        /// Burundi
        /// BI
        /// 108
        /// </summary>
        BDI = 41,
        /// <summary>
        /// Cabo Verde
        /// CV
        /// 132
        /// </summary>
        CPV = 42,
        /// <summary>
        /// Cambodia
        /// KH
        /// 116
        /// </summary>
        KHM = 43,
        /// <summary>
        /// Cameroon
        /// CM
        /// 120
        /// </summary>
        CMR = 44,
        /// <summary>
        /// Canada
        /// CA
        /// 124
        /// </summary>
        CAN = 45,
        /// <summary>
        /// Cayman Islands (the)
        /// KY
        /// 136
        /// </summary>
        CYM = 46,
        /// <summary>
        /// Central African Republic (the)
        /// CF
        /// 140
        /// </summary>
        CAF = 47,
        /// <summary>
        /// Chad
        /// TD
        /// 148
        /// </summary>
        TCD = 48,
        /// <summary>
        /// Chile
        /// CL
        /// 152
        /// </summary>
        CHL = 49,
        /// <summary>
        /// China
        /// CN
        /// 156
        /// </summary>
        CHN = 50,
        /// <summary>
        /// Christmas Island
        /// CX
        /// 162
        /// </summary>
        CXR = 51,
        /// <summary>
        /// Cocos (Keeling) Islands (the)
        /// CC
        /// 166
        /// </summary>
        CCK = 52,
        /// <summary>
        /// Colombia
        /// CO
        /// 170
        /// </summary>
        COL = 53,
        /// <summary>
        /// Comoros (the)
        /// KM
        /// 174
        /// </summary>
        COM = 54,
        /// <summary>
        /// Congo (the Democratic Republic of the)
        /// CD
        /// 180
        /// </summary>
        COD = 55,
        /// <summary>
        /// Congo (the)
        /// CG
        /// 178
        /// </summary>
        COG = 56,
        /// <summary>
        /// Cook Islands (the)
        /// CK
        /// 184
        /// </summary>
        COK = 57,
        /// <summary>
        /// Costa Rica
        /// CR
        /// 188
        /// </summary>
        CRI = 58,
        /// <summary>
        /// Croatia
        /// HR
        /// 191
        /// </summary>
        HRV = 59,
        /// <summary>
        /// Cuba
        /// CU
        /// 192
        /// </summary>
        CUB = 60,
        /// <summary>
        /// Cura�ao
        /// CW
        /// 531
        /// </summary>
        CUW = 61,
        /// <summary>
        /// Cyprus
        /// CY
        /// 196
        /// </summary>
        CYP = 62,
        /// <summary>
        /// Czechia (Czech Republic)
        /// CZ
        /// 203
        /// </summary>
        CZE = 63,
        /// <summary>
        /// C�te d'Ivoire
        /// CI
        /// 384
        /// </summary>
        CIV = 64,
        /// <summary>
        /// Denmark
        /// DK
        /// 208
        /// </summary>
        DNK = 65,
        /// <summary>
        /// Djibouti
        /// DJ
        /// 262
        /// </summary>
        DJI = 66,
        /// <summary>
        /// Dominica
        /// DM
        /// 212
        /// </summary>
        DMA = 67,
        /// <summary>
        /// Dominican Republic (the)
        /// DO
        /// 214
        /// </summary>
        DOM = 68,
        /// <summary>
        /// Ecuador
        /// EC
        /// 218
        /// </summary>
        ECU = 69,
        /// <summary>
        /// Egypt
        /// EG
        /// 818
        /// </summary>
        EGY = 70,
        /// <summary>
        /// El Salvador
        /// SV
        /// 222
        /// </summary>
        SLV = 71,
        /// <summary>
        /// Equatorial Guinea
        /// GQ
        /// 226
        /// </summary>
        GNQ = 72,
        /// <summary>
        /// Eritrea
        /// ER
        /// 232
        /// </summary>
        ERI = 73,
        /// <summary>
        /// Estonia
        /// EE
        /// 233
        /// </summary>
        EST = 74,
        /// <summary>
        /// Eswatini
        /// SZ
        /// 748
        /// </summary>
        SWZ = 75,
        /// <summary>
        /// Ethiopia
        /// ET
        /// 231
        /// </summary>
        ETH = 76,
        /// <summary>
        /// Falkland Islands (the) [Malvinas]
        /// FK
        /// 238
        /// </summary>
        FLK = 77,
        /// <summary>
        /// Faroe Islands (the)
        /// FO
        /// 234
        /// </summary>
        FRO = 78,
        /// <summary>
        /// Fiji
        /// FJ
        /// 242
        /// </summary>
        FJI = 79,
        /// <summary>
        /// Finland
        /// FI
        /// 246
        /// </summary>
        FIN = 80,
        /// <summary>
        /// France
        /// FR
        /// 250
        /// </summary>
        FRA = 81,
        /// <summary>
        /// French Guiana
        /// GF
        /// 254
        /// </summary>
        GUF = 82,
        /// <summary>
        /// French Polynesia
        /// PF
        /// 258
        /// </summary>
        PYF = 83,
        /// <summary>
        /// French Southern Territories (the)
        /// TF
        /// 260
        /// </summary>
        ATF = 84,
        /// <summary>
        /// Gabon
        /// GA
        /// 266
        /// </summary>
        GAB = 85,
        /// <summary>
        /// Gambia (the)
        /// GM
        /// 270
        /// </summary>
        GMB = 86,
        /// <summary>
        /// Georgia
        /// GE
        /// 268
        /// </summary>
        GEO = 87,
        /// <summary>
        /// Germany
        /// DE
        /// 276
        /// </summary>
        DEU = 88,
        /// <summary>
        /// Ghana
        /// GH
        /// 288
        /// </summary>
        GHA = 89,
        /// <summary>
        /// Gibraltar
        /// GI
        /// 292
        /// </summary>
        GIB = 90,
        /// <summary>
        /// Greece
        /// GR
        /// 300
        /// </summary>
        GRC = 91,
        /// <summary>
        /// Greenland
        /// GL
        /// 304
        /// </summary>
        GRL = 92,
        /// <summary>
        /// Grenada
        /// GD
        /// 308
        /// </summary>
        GRD = 93,
        /// <summary>
        /// Guadeloupe
        /// GP
        /// 312
        /// </summary>
        GLP = 94,
        /// <summary>
        /// Guam
        /// GU
        /// 316
        /// </summary>
        GUM = 95,
        /// <summary>
        /// Guatemala
        /// GT
        /// 320
        /// </summary>
        GTM = 96,
        /// <summary>
        /// Guernsey
        /// GG
        /// 831
        /// </summary>
        GGY = 97,
        /// <summary>
        /// Guinea
        /// GN
        /// 324
        /// </summary>
        GIN = 98,
        /// <summary>
        /// Guinea-Bissau
        /// GW
        /// 624
        /// </summary>
        GNB = 99,
        /// <summary>
        /// Guyana
        /// GY
        /// 328
        /// </summary>
        GUY = 100,
        /// <summary>
        /// Haiti
        /// HT
        /// 332
        /// </summary>
        HTI = 101,
        /// <summary>
        /// Heard Island and McDonald Islands
        /// HM
        /// 334
        /// </summary>
        HMD = 102,
        /// <summary>
        /// Holy See (the)
        /// VA
        /// 336
        /// </summary>
        VAT = 103,
        /// <summary>
        /// Honduras
        /// HN
        /// 340
        /// </summary>
        HND = 104,
        /// <summary>
        /// Hong Kong
        /// HK
        /// 344
        /// </summary>
        HKG = 105,
        /// <summary>
        /// Hungary
        /// HU
        /// 348
        /// </summary>
        HUN = 106,
        /// <summary>
        /// Iceland
        /// IS
        /// 352
        /// </summary>
        ISL = 107,
        /// <summary>
        /// India
        /// IN
        /// 356
        /// </summary>
        IND = 108,
        /// <summary>
        /// Indonesia
        /// ID
        /// 360
        /// </summary>
        IDN = 109,
        /// <summary>
        /// Iran (Islamic Republic of)
        /// IR
        /// 364
        /// </summary>
        IRN = 110,
        /// <summary>
        /// Iraq
        /// IQ
        /// 368
        /// </summary>
        IRQ = 111,
        /// <summary>
        /// Ireland
        /// IE
        /// 372
        /// </summary>
        IRL = 112,
        /// <summary>
        /// Isle of Man
        /// IM
        /// 833
        /// </summary>
        IMN = 113,
        /// <summary>
        /// Israel
        /// IL
        /// 376
        /// </summary>
        ISR = 114,
        /// <summary>
        /// Italy
        /// IT
        /// 380
        /// </summary>
        ITA = 115,
        /// <summary>
        /// Jamaica
        /// JM
        /// 388
        /// </summary>
        JAM = 116,
        /// <summary>
        /// Japan
        /// JP
        /// 392
        /// </summary>
        JPN = 117,
        /// <summary>
        /// Jersey
        /// JE
        /// 832
        /// </summary>
        JEY = 118,
        /// <summary>
        /// Jordan
        /// JO
        /// 400
        /// </summary>
        JOR = 119,
        /// <summary>
        /// Kazakhstan
        /// KZ
        /// 398
        /// </summary>
        KAZ = 120,
        /// <summary>
        /// Kenya
        /// KE
        /// 404
        /// </summary>
        KEN = 121,
        /// <summary>
        /// Kiribati
        /// KI
        /// 296
        /// </summary>
        KIR = 122,
        /// <summary>
        /// Korea (the Democratic People's Republic of)
        /// KP
        /// 408
        /// </summary>
        PRK = 123,
        /// <summary>
        /// Korea (the Republic of)
        /// KR
        /// 410
        /// </summary>
        KOR = 124,
        /// <summary>
        /// Kuwait
        /// KW
        /// 414
        /// </summary>
        KWT = 125,
        /// <summary>
        /// Kyrgyzstan
        /// KG
        /// 417
        /// </summary>
        KGZ = 126,
        /// <summary>
        /// Lao People's Democratic Republic (the)
        /// LA
        /// 418
        /// </summary>
        LAO = 127,
        /// <summary>
        /// Latvia
        /// LV
        /// 428
        /// </summary>
        LVA = 128,
        /// <summary>
        /// Lebanon
        /// LB
        /// 422
        /// </summary>
        LBN = 129,
        /// <summary>
        /// Lesotho
        /// LS
        /// 426
        /// </summary>
        LSO = 130,
        /// <summary>
        /// Liberia
        /// LR
        /// 430
        /// </summary>
        LBR = 131,
        /// <summary>
        /// Libya
        /// LY
        /// 434
        /// </summary>
        LBY = 132,
        /// <summary>
        /// Liechtenstein
        /// LI
        /// 438
        /// </summary>
        LIE = 133,
        /// <summary>
        /// Lithuania
        /// LT
        /// 440
        /// </summary>
        LTU = 134,
        /// <summary>
        /// Luxembourg
        /// LU
        /// 442
        /// </summary>
        LUX = 135,
        /// <summary>
        /// Macao
        /// MO
        /// 446
        /// </summary>
        MAC = 136,
        /// <summary>
        /// Madagascar
        /// MG
        /// 450
        /// </summary>
        MDG = 137,
        /// <summary>
        /// Malawi
        /// MW
        /// 454
        /// </summary>
        MWI = 138,
        /// <summary>
        /// Malaysia
        /// MY
        /// 458
        /// </summary>
        MYS = 139,
        /// <summary>
        /// Maldives
        /// MV
        /// 462
        /// </summary>
        MDV = 140,
        /// <summary>
        /// Mali
        /// ML
        /// 466
        /// </summary>
        MLI = 141,
        /// <summary>
        /// Malta
        /// MT
        /// 470
        /// </summary>
        MLT = 142,
        /// <summary>
        /// Marshall Islands (the)
        /// MH
        /// 584
        /// </summary>
        MHL = 143,
        /// <summary>
        /// Martinique
        /// MQ
        /// 474
        /// </summary>
        MTQ = 144,
        /// <summary>
        /// Mauritania
        /// MR
        /// 478
        /// </summary>
        MRT = 145,
        /// <summary>
        /// Mauritius
        /// MU
        /// 480
        /// </summary>
        MUS = 146,
        /// <summary>
        /// Mayotte
        /// YT
        /// 175
        /// </summary>
        MYT = 147,
        /// <summary>
        /// Mexico
        /// MX
        /// 484
        /// </summary>
        MEX = 148,
        /// <summary>
        /// Micronesia (Federated States of)
        /// FM
        /// 583
        /// </summary>
        FSM = 149,
        /// <summary>
        /// Moldova (the Republic of)
        /// MD
        /// 498
        /// </summary>
        MDA = 150,
        /// <summary>
        /// Monaco
        /// MC
        /// 492
        /// </summary>
        MCO = 151,
        /// <summary>
        /// Mongolia
        /// MN
        /// 496
        /// </summary>
        MNG = 152,
        /// <summary>
        /// Montenegro
        /// ME
        /// 499
        /// </summary>
        MNE = 153,
        /// <summary>
        /// Montserrat
        /// MS
        /// 500
        /// </summary>
        MSR = 154,
        /// <summary>
        /// Morocco
        /// MA
        /// 504
        /// </summary>
        MAR = 155,
        /// <summary>
        /// Mozambique
        /// MZ
        /// 508
        /// </summary>
        MOZ = 156,
        /// <summary>
        /// Myanmar
        /// MM
        /// 104
        /// </summary>
        MMR = 157,
        /// <summary>
        /// Namibia
        /// NA
        /// 516
        /// </summary>
        NAM = 158,
        /// <summary>
        /// Nauru
        /// NR
        /// 520
        /// </summary>
        NRU = 159,
        /// <summary>
        /// Nepal
        /// NP
        /// 524
        /// </summary>
        NPL = 160,
        /// <summary>
        /// Netherlands (the)
        /// NL
        /// 528
        /// </summary>
        NLD = 161,
        /// <summary>
        /// New Caledonia
        /// NC
        /// 540
        /// </summary>
        NCL = 162,
        /// <summary>
        /// New Zealand
        /// NZ
        /// 554
        /// </summary>
        NZL = 163,
        /// <summary>
        /// Nicaragua
        /// NI
        /// 558
        /// </summary>
        NIC = 164,
        /// <summary>
        /// Niger (the)
        /// NE
        /// 562
        /// </summary>
        NER = 165,
        /// <summary>
        /// Nigeria
        /// NG
        /// 566
        /// </summary>
        NGA = 166,
        /// <summary>
        /// Niue
        /// NU
        /// 570
        /// </summary>
        NIU = 167,
        /// <summary>
        /// Norfolk Island
        /// NF
        /// 574
        /// </summary>
        NFK = 168,
        /// <summary>
        /// North Macedonia
        /// MK
        /// 807
        /// </summary>
        MKD = 169,
        /// <summary>
        /// Northern Mariana Islands (the)
        /// MP
        /// 580
        /// </summary>
        MNP = 170,
        /// <summary>
        /// Norway
        /// NO
        /// 578
        /// </summary>
        NOR = 171,
        /// <summary>
        /// Oman
        /// OM
        /// 512
        /// </summary>
        OMN = 172,
        /// <summary>
        /// Pakistan
        /// PK
        /// 586
        /// </summary>
        PAK = 173,
        /// <summary>
        /// Palau
        /// PW
        /// 585
        /// </summary>
        PLW = 174,
        /// <summary>
        /// Palestine State of
        /// PS
        /// 275
        /// </summary>
        PSE = 175,
        /// <summary>
        /// Panama
        /// PA
        /// 591
        /// </summary>
        PAN = 176,
        /// <summary>
        /// Papua New Guinea
        /// PG
        /// 598
        /// </summary>
        PNG = 177,
        /// <summary>
        /// Paraguay
        /// PY
        /// 600
        /// </summary>
        PRY = 178,
        /// <summary>
        /// Peru
        /// PE
        /// 604
        /// </summary>
        PER = 179,
        /// <summary>
        /// Philippines (the)
        /// PH
        /// 608
        /// </summary>
        PHL = 180,
        /// <summary>
        /// Pitcairn
        /// PN
        /// 612
        /// </summary>
        PCN = 181,
        /// <summary>
        /// Poland
        /// PL
        /// 616
        /// </summary>
        POL = 182,
        /// <summary>
        /// Portugal
        /// PT
        /// 620
        /// </summary>
        PRT = 183,
        /// <summary>
        /// Puerto Rico
        /// PR
        /// 630
        /// </summary>
        PRI = 184,
        /// <summary>
        /// Qatar
        /// QA
        /// 634
        /// </summary>
        QAT = 185,
        /// <summary>
        /// Romania
        /// RO
        /// 642
        /// </summary>
        ROU = 186,
        /// <summary>
        /// Russian Federation (the)
        /// RU
        /// 643
        /// </summary>
        RUS = 187,
        /// <summary>
        /// Rwanda
        /// RW
        /// 646
        /// </summary>
        RWA = 188,
        /// <summary>
        /// R�union
        /// RE
        /// 638
        /// </summary>
        REU = 189,
        /// <summary>
        /// Saint Barth�lemy
        /// BL
        /// 652
        /// </summary>
        BLM = 190,
        /// <summary>
        /// Saint Helena Ascension and Tristan da Cunha
        /// SH
        /// 654
        /// </summary>
        SHN = 191,
        /// <summary>
        /// Saint Kitts and Nevis
        /// KN
        /// 659
        /// </summary>
        KNA = 192,
        /// <summary>
        /// Saint Lucia
        /// LC
        /// 662
        /// </summary>
        LCA = 193,
        /// <summary>
        /// Saint Martin (French part)
        /// MF
        /// 663
        /// </summary>
        MAF = 194,
        /// <summary>
        /// Saint Pierre and Miquelon
        /// PM
        /// 666
        /// </summary>
        SPM = 195,
        /// <summary>
        /// Saint Vincent and the Grenadines
        /// VC
        /// 670
        /// </summary>
        VCT = 196,
        /// <summary>
        /// Samoa
        /// WS
        /// 882
        /// </summary>
        WSM = 197,
        /// <summary>
        /// San Marino
        /// SM
        /// 674
        /// </summary>
        SMR = 198,
        /// <summary>
        /// Sao Tome and Principe
        /// ST
        /// 678
        /// </summary>
        STP = 199,
        /// <summary>
        /// Saudi Arabia
        /// SA
        /// 682
        /// </summary>
        SAU = 200,
        /// <summary>
        /// Senegal
        /// SN
        /// 686
        /// </summary>
        SEN = 201,
        /// <summary>
        /// Serbia
        /// RS
        /// 688
        /// </summary>
        SRB = 202,
        /// <summary>
        /// Seychelles
        /// SC
        /// 690
        /// </summary>
        SYC = 203,
        /// <summary>
        /// Sierra Leone
        /// SL
        /// 694
        /// </summary>
        SLE = 204,
        /// <summary>
        /// Singapore
        /// SG
        /// 702
        /// </summary>
        SGP = 205,
        /// <summary>
        /// Sint Maarten (Dutch part)
        /// SX
        /// 534
        /// </summary>
        SXM = 206,
        /// <summary>
        /// Slovakia
        /// SK
        /// 703
        /// </summary>
        SVK = 207,
        /// <summary>
        /// Slovenia
        /// SI
        /// 705
        /// </summary>
        SVN = 208,
        /// <summary>
        /// Solomon Islands
        /// SB
        /// 90
        /// </summary>
        SLB = 209,
        /// <summary>
        /// Somalia
        /// SO
        /// 706
        /// </summary>
        SOM = 210,
        /// <summary>
        /// South Africa
        /// ZA
        /// 710
        /// </summary>
        ZAF = 211,
        /// <summary>
        /// South Georgia and the South Sandwich Islands
        /// GS
        /// 239
        /// </summary>
        SGS = 212,
        /// <summary>
        /// South Sudan
        /// SS
        /// 728
        /// </summary>
        SSD = 213,
        /// <summary>
        /// Spain
        /// ES
        /// 724
        /// </summary>
        ESP = 214,
        /// <summary>
        /// Sri Lanka
        /// LK
        /// 144
        /// </summary>
        LKA = 215,
        /// <summary>
        /// Sudan (the)
        /// SD
        /// 729
        /// </summary>
        SDN = 216,
        /// <summary>
        /// Suriname
        /// SR
        /// 740
        /// </summary>
        SUR = 217,
        /// <summary>
        /// Svalbard and Jan Mayen
        /// SJ
        /// 744
        /// </summary>
        SJM = 218,
        /// <summary>
        /// Sweden
        /// SE
        /// 752
        /// </summary>
        SWE = 219,
        /// <summary>
        /// Switzerland
        /// CH
        /// 756
        /// </summary>
        CHE = 220,
        /// <summary>
        /// Syrian Arab Republic (the)
        /// SY
        /// 760
        /// </summary>
        SYR = 221,
        /// <summary>
        /// Taiwan (Province of China)
        /// TW
        /// 158
        /// </summary>
        TWN = 222,
        /// <summary>
        /// Tajikistan
        /// TJ
        /// 762
        /// </summary>
        TJK = 223,
        /// <summary>
        /// Tanzania the United Republic of
        /// TZ
        /// 834
        /// </summary>
        TZA = 224,
        /// <summary>
        /// Thailand
        /// TH
        /// 764
        /// </summary>
        THA = 225,
        /// <summary>
        /// Timor-Leste
        /// TL
        /// 626
        /// </summary>
        TLS = 226,
        /// <summary>
        /// Togo
        /// TG
        /// 768
        /// </summary>
        TGO = 227,
        /// <summary>
        /// Tokelau
        /// TK
        /// 772
        /// </summary>
        TKL = 228,
        /// <summary>
        /// Tonga
        /// TO
        /// 776
        /// </summary>
        TON = 229,
        /// <summary>
        /// Trinidad and Tobago
        /// TT
        /// 780
        /// </summary>
        TTO = 230,
        /// <summary>
        /// Tunisia
        /// TN
        /// 788
        /// </summary>
        TUN = 231,
        /// <summary>
        /// Turkey
        /// TR
        /// 792
        /// </summary>
        TUR = 232,
        /// <summary>
        /// Turkmenistan
        /// TM
        /// 795
        /// </summary>
        TKM = 233,
        /// <summary>
        /// Turks and Caicos Islands (the)
        /// TC
        /// 796
        /// </summary>
        TCA = 234,
        /// <summary>
        /// Tuvalu
        /// TV
        /// 798
        /// </summary>
        TUV = 235,
        /// <summary>
        /// Uganda
        /// UG
        /// 800
        /// </summary>
        UGA = 236,
        /// <summary>
        /// Ukraine
        /// UA
        /// 804
        /// </summary>
        UKR = 237,
        /// <summary>
        /// United Arab Emirates (the)
        /// AE
        /// 784
        /// </summary>
        ARE = 238,
        /// <summary>
        /// United Kingdom of Great Britain and Northern Ireland (the)
        /// GB
        /// 826
        /// </summary>
        GBR = 239,
        /// <summary>
        /// United States Minor Outlying Islands (the)
        /// UM
        /// 581
        /// </summary>
        UMI = 240,
        /// <summary>
        /// United States of America (the)
        /// US
        /// 840
        /// </summary>
        USA = 241,
        /// <summary>
        /// Uruguay
        /// UY
        /// 858
        /// </summary>
        URY = 242,
        /// <summary>
        /// Uzbekistan
        /// UZ
        /// 860
        /// </summary>
        UZB = 243,
        /// <summary>
        /// Vanuatu
        /// VU
        /// 548
        /// </summary>
        VUT = 244,
        /// <summary>
        /// Venezuela (Bolivarian Republic of)
        /// VE
        /// 862
        /// </summary>
        VEN = 245,
        /// <summary>
        /// Viet Nam
        /// VN
        /// 704
        /// </summary>
        VNM = 246,
        /// <summary>
        /// Virgin Islands (British)
        /// VG
        /// 92
        /// </summary>
        VGB = 247,
        /// <summary>
        /// Virgin Islands (U.S.)
        /// VI
        /// 850
        /// </summary>
        VIR = 248,
        /// <summary>
        /// Wallis and Futuna
        /// WF
        /// 876
        /// </summary>
        WLF = 249,
        /// <summary>
        /// Western Sahara*
        /// EH
        /// 732
        /// </summary>
        ESH = 250,
        /// <summary>
        /// Yemen
        /// YE
        /// 887
        /// </summary>
        YEM = 251,
        /// <summary>
        /// Zambia
        /// ZM
        /// 894
        /// </summary>
        ZMB = 252,
        /// <summary>
        /// Zimbabwe
        /// ZW
        /// 716
        /// </summary>
        ZWE = 253,
        /// <summary>
        /// �land Islands
        /// AX
        /// 248
        /// </summary>
        ALA = 254,
    }

}
