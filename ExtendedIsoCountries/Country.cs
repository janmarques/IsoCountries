using System;
using System.Collections.Generic;

namespace ExtendedIsoCountries
{
    public sealed class Country
    {
        static Country()
        {
            Countries = new List<Country>()
            {
                new Country("Afghanistan", "AF", "AFG",4, "Afghani", "Afghani"),
                new Country("Åland Islands", "AX", "ALA",248, "Ålandic", "Ålandic"),
                new Country("Albania", "AL", "ALB",8, "Albanian", "Albanian"),
                new Country("Algeria", "DZ", "DZA",12, "Algerian", "Algerian"),
                new Country("American Samoa", "AS", "ASM",16, "Samoan", "Samoan"),
                new Country("Andorra", "AD", "AND",20, "Andorran", "Andorran"),
                new Country("Angola", "AO", "AGO",24, "Angolan", "Angolan"),
                new Country("Anguilla", "AI", "AIA",660, "Anguillan", "Anguillan"),
                new Country("Antarctica", "AQ", "ATA",10, "Antarctic", null),
                new Country("Antigua and Barbuda", "AG", "ATG",28, "Antiguan", "Antiguan"),
                new Country("Argentina", "AR", "ARG",32, "Argentine", "Argentine"),
                new Country("Armenia", "AM", "ARM",51, "Armenian", "Armenian"),
                new Country("Aruba", "AW", "ABW",533, "Arubian", "Arubian"),
                new Country("Australia", "AU", "AUS",36, "Australian", "Australian"),
                new Country("Austria", "AT", "AUT",40, "Austrian", "Austrian"),
                new Country("Azerbaijan", "AZ", "AZE",31, "Azerbaijani", "Azerbaijani"),
                new Country("Bahamas (the)", "BS", "BHS",44, "Bahameese", "Bahameese"),
                new Country("Bahrain", "BH", "BHR",48, "Bahrainian", "Bahrainian"),
                new Country("Bangladesh", "BD", "BGD",50, "Bangladeshi", "Bangladeshi"),
                new Country("Barbados", "BB", "BRB",52, "Barbadian", "Barbadian"),
                new Country("Belarus", "BY", "BLR",112, "Belarusian", "Belarusian"),
                new Country("Belgium", "BE", "BEL",56, "Belgian", "Belgian"),
                new Country("Belize", "BZ", "BLZ",84, "Belizean", "Belizean"),
                new Country("Benin", "BJ", "BEN",204, "Beninese", "Beninese"),
                new Country("Bermuda", "BM", "BMU",60, "Bermudan", "Bermudan"),
                new Country("Bhutan", "BT", "BTN",64, "Bhutanese", "Bhutanese"),
                new Country("Bolivia", "BO", "BOL",68, "Bolivian", "Bolivian"),
                new Country("Bonaire, Sint Eustatius and Saba", "BQ", "BES",535, null, null),
                new Country("Bosnia and Herzegovina", "BA", "BIH",70, null, null),
                new Country("Botswana", "BW", "BWA",72, "Motswana", "Motswana"),
                new Country("Bouvet Island", "BV", "BVT",74, null, null),
                new Country("Brazil", "BR", "BRA",76, "Brazilian", "Brazilian"),
                new Country("British Indian Ocean Territory", "IO", "IOT",86, "BIOT", "British"),
                new Country("Brunei Darussalam", "BN", "BRN",96, "Bruneian", "Bruneian"),
                new Country("Bulgaria", "BG", "BGR",100, "Bulgarian", "Bulgarian"),
                new Country("Burkina Faso", "BF", "BFA",854, "Burkinabe", "Burkinabe"),
                new Country("Burundi", "BI", "BDI",108, "Burundian", "Burundian"),
                new Country("Cabo Verde", "CV", "CPV",132, "Cape Verdean", "Cape Verdean"),
                new Country("Cambodia", "KH", "KHM",116, "Cambodian", "Cambodian"),
                new Country("Cameroon", "CM", "CMR",120, "Cameroonian", "Cameroonian"),
                new Country("Canada", "CA", "CAN",124, "Canadian", "Canadian"),
                new Country("Cayman Islands", "KY", "CYM",136, "Caymanian", "Caymanian"),
                new Country("Central African Republic", "CF", "CAF",140, "Central African", "Central African"),
                new Country("Chad", "TD", "TCD",148, "Chadian", "Chadian"),
                new Country("Chile", "CL", "CHL",152, "Chilean", "Chilean"),
                new Country("China", "CN", "CHN",156, "Chinese", "Chinese"),
                new Country("Christmas Island", "CX", "CXR",162, "Christmas Island", "Christmas Islander"),
                new Country("Cocos (Keeling) Islands", "CC", "CCK",166, "Cocossian", "Cocossian"),
                new Country("Colombia", "CO", "COL",170, "Colombian", "Colombian"),
                new Country("Comoros", "KM", "COM",174, "Comoran", "Comoran"),
                new Country("Democratic Republic of the Congo", "CD", "COD",180, "Congolese", "Congolese"),
                new Country("Congo", "CG", "COG",178, "Congolese", "Congolese"),
                new Country("Cook Islands (the)", "CK", "COK",184, "Cook Islander", "Cook Islander"),
                new Country("Costa Rica", "CR", "CRI",188, "Costa Rican", "Costa Rican"),
                new Country("Côte d'Ivoire", "CI", "CIV",384, "Ivorian", "Ivorian"),
                new Country("Croatia", "HR", "HRV",191, "Croatian", "Croatian"),
                new Country("Cuba", "CU", "CUB",192, "Cuban", "Cuban"),
                new Country("Curaçao", "CW", "CUW",531, "Curaçaoan", "Curaçaoan"),
                new Country("Cyprus", "CY", "CYP",196, "Cypriot", "Cypriot"),
                new Country("Czechia", "CZ", "CZE",203, "Czech", "Czech"),
                new Country("Denmark", "DK", "DNK",208, "Danish", "Danish"),
                new Country("Djibouti", "DJ", "DJI",262, "Djiboutian", "Djiboutian"),
                new Country("Dominica", "DM", "DMA",212, "Dominican", "Dominican"),
                new Country("Dominican Republic", "DO", "DOM",214, "Dominican", "Dominican"),
                new Country("Ecuador", "EC", "ECU",218, "Ecuadorean", "Ecuadorean"),
                new Country("Egypt", "EG", "EGY",818, "Egyptian", "Egyptian"),
                new Country("El Salvador", "SV", "SLV",222, "Salvadorean", "Salvadorean"),
                new Country("Equatorial Guinea", "GQ", "GNQ",226, "Equatorial Guinean", "Equatorial Guinean"),
                new Country("Eritrea", "ER", "ERI",232, "Eritrean", "Eritrean"),
                new Country("Estonia", "EE", "EST",233, "Estonian", "Estonian"),
                new Country("Ethiopia", "ET", "ETH",231, "Ethiopian", "Ethiopian"),
                new Country("Falkland Islands", "FK", "FLK",238, "Falkland Island", "Falkland Islander"),
                new Country("Faroe Islands", "FO", "FRO",234, "Faroese", "Faroese"),
                new Country("Fiji", "FJ", "FJI",242, "Fijian", "Fijian"),
                new Country("Finland", "FI", "FIN",246, "Finnish", "Finnish"),
                new Country("France", "FR", "FRA",250, "French", "French"),
                new Country("French Guiana", "GF", "GUF",254, "French Guianese", "French Guianese"),
                new Country("French Polynesia", "PF", "PYF",258, "French Polynesian", "French Polynesian"),
                new Country("French Southern Territories", "TF", "ATF",260, "French Southern Territories", null),
                new Country("Gabon", "GA", "GAB",266, "Gabonese", "Gabonese"),
                new Country("Gambia", "GM", "GMB",270, "Gambian", "Gambian"),
                new Country("Georgia", "GE", "GEO",268, "Georgian", "Georgian"),
                new Country("Germany", "DE", "DEU",276, "German", "German"),
                new Country("Ghana", "GH", "GHA",288, "Ghanaian", "Ghanaian"),
                new Country("Gibraltar", "GI", "GIB",292, "Gibralterian", "Gibralterian"),
                new Country("Greece", "GR", "GRC",300, "Greek", "Greek"),
                new Country("Greenland", "GL", "GRL",304, "Greenlandic", "Greenlander"),
                new Country("Grenada", "GD", "GRD",308, "Grenadian", "Grenadian"),
                new Country("Guadeloupe", "GP", "GLP",312, "Guadeloupean", "Guadeloupean"),
                new Country("Guam", "GU", "GUM",316, "Guamanian", "Guamanian"),
                new Country("Guatemala", "GT", "GTM",320, "Guatemalan", "Guatemalan"),
                new Country("Guernsey", "GG", "GGY",831, "Channel Island", "Channel Island"),
                new Country("Guinea", "GN", "GIN",324, "Guinean", "Guinean"),
                new Country("Guinea-Bissau", "GW", "GNB",624, "Guinean", "Guinean"),
                new Country("Guyana", "GY", "GUY",328, "Guyanese", "Guyanese"),
                new Country("Haiti", "HT", "HTI",332, "Haitian", "Haitian"),
                new Country("Heard Island and McDonald Islands", "HM", "HMD",334, null, null),
                new Country("Holy See", "VA", "VAT",336, "Vatican", "Vatican"),
                new Country("Honduras", "HN", "HND",340, "Honduran", "Honduran"),
                new Country("Hong Kong", "HK", "HKG",344, "Hong Kong", "Hongkonger"),
                new Country("Hungary", "HU", "HUN",348, "Hungarian", "Hungarian"),
                new Country("Iceland", "IS", "ISL",352, "Icelandic", "Icelander"),
                new Country("India", "IN", "IND",356, "Indian", "Indian"),
                new Country("Indonesia", "ID", "IDN",360, "Indonesian", "Indonesian"),
                new Country("Iran", "IR", "IRN",364, "Iranian", "Iranian"),
                new Country("Iraq", "IQ", "IRQ",368, "Iraqi", "Iraqi"),
                new Country("Ireland", "IE", "IRL",372, "Irish", "Irish"),
                new Country("Isle of Man", "IM", "IMN",833, "Manx", "Manx"),
                new Country("Israel", "IL", "ISR",376, "Israeli", "Israeli"),
                new Country("Italy", "IT", "ITA",380, "Italian", "Italian"),
                new Country("Jamaica", "JM", "JAM",388, "Jamaican", "Jamaican"),
                new Country("Japan", "JP", "JPN",392, "Japanese", "Japanese"),
                new Country("Jersey", "JE", "JEY",832, "Channel Island", "Channel Islander"),
                new Country("Jordan", "JO", "JOR",400, "Jordanian", "Jordanian"),
                new Country("Kazakhstan", "KZ", "KAZ",398, "Kazakhstani", "Kazakhstani"),
                new Country("Kenya", "KE", "KEN",404, "Kenyan", "Kenyan"),
                new Country("Kiribati", "KI", "KIR",296, "I-Kiribati", "I-Kiribati"),
                new Country("Democratic People's Republic of Korea", "KP", "PRK",408, "North Korean", "North Korean"),
                new Country("Republic ofKorea", "KR", "KOR",410, "South Korean", "South Korean"),
                new Country("Kuwait", "KW", "KWT",414, "Kuwaiti", "Kuwaiti"),
                new Country("Kyrgyzstan", "KG", "KGZ",417, "Kyrgyzstani", "Kyrgyzstani"),
                new Country("Lao People's Democratic Republic", "LA", "LAO",418, "Laotian", "Laotian"),
                new Country("Latvia", "LV", "LVA",428, "Latvian", "Latvian"),
                new Country("Lebanon", "LB", "LBN",422, "Lebanese", "Lebanese"),
                new Country("Lesotho", "LS", "LSO",426, "Mosotho", "Mosotho"),
                new Country("Liberia", "LR", "LBR",430, "Liberian", "Liberian"),
                new Country("Libya", "LY", "LBY",434, "Libyan", "Libyan"),
                new Country("Liechtenstein", "LI", "LIE",438, "Liechtensteiner", "Liechtensteiner"),
                new Country("Lithuania", "LT", "LTU",440, "Lithunian", "Lithunian"),
                new Country("Luxembourg", "LU", "LUX",442, "Luxembourger", "Luxembourger"),
                new Country("Macao", "MO", "MAC",446, "Macanese", "Macanese"),
                new Country("Macedonia (the former Yugoslav Republic of)", "MK", "MKD",807, "Macedonian", "Macedonian"),
                new Country("Madagascar", "MG", "MDG",450, "Malagasy", "Malagasy"),
                new Country("Malawi", "MW", "MWI",454, "Malawian", "Malawian"),
                new Country("Malaysia", "MY", "MYS",458, "Malaysian", "Malaysian"),
                new Country("Maldives", "MV", "MDV",462, "Maldivan", "Maldivan"),
                new Country("Mali", "ML", "MLI",466, "Malian", "Malian"),
                new Country("Malta", "MT", "MLT",470, "Maltese", "Maltese"),
                new Country("Marshall Islands", "MH", "MHL",584, "Marshallese", "Marshallese"),
                new Country("Martinique", "MQ", "MTQ",474, "Martinican", "Martinican"),
                new Country("Mauritania", "MR", "MRT",478, "Mauritanian", "Mauritanian"),
                new Country("Mauritius", "MU", "MUS",480, "Mauritian", "Mauritian"),
                new Country("Mayotte", "YT", "MYT",175, "Mahoran", "Mahoran"),
                new Country("Mexico", "MX", "MEX",484, "Mexican", "Mexican"),
                new Country("Micronesia", "FM", "FSM",583, "Micronesian", "Micronesian"),
                new Country("Moldova", "MD", "MDA",498, "Moldovan", "Moldovan"),
                new Country("Monaco", "MC", "MCO",492, "Monacan", "Monacan"),
                new Country("Mongolia", "MN", "MNG",496, "Mongolian", "Mongolian"),
                new Country("Montenegro", "ME", "MNE",499, "Montenegrin", "Montenegrin"),
                new Country("Montserrat", "MS", "MSR",500, "Montserratian", "Montserratian"),
                new Country("Morocco", "MA", "MAR",504, "Moroccan", "Moroccan"),
                new Country("Mozambique", "MZ", "MOZ",508, "Mozambican", "Mozambican"),
                new Country("Myanmar", "MM", "MMR",104, "Myanmarese", "Myanmarese"),
                new Country("Namibia", "NA", "NAM",516, "Namibian", "Namibian"),
                new Country("Nauru", "NR", "NRU",520, "Nauruan", "Nauruan"),
                new Country("Nepal", "NP", "NPL",524, "Nepalese", "Nepalese"),
                new Country("Netherlands", "NL", "NLD",528, "Dutch", "Dutch"),
                new Country("New Caledonia", "NC", "NCL",540, "New Caledonian", "New Caledonian"),
                new Country("New Zealand", "NZ", "NZL",554, "New Zealander", "New Zealander"),
                new Country("Nicaragua", "NI", "NIC",558, "Nicaraguan", "Nicaraguan"),
                new Country("Niger", "NE", "NER",562, "Nigerien", "Nigerien"),
                new Country("Nigeria", "NG", "NGA",566, "Nigerian", "Nigerian"),
                new Country("Niue", "NU", "NIU",570, "Niuean", "Niuean"),
                new Country("Norfolk Island", "NF", "NFK",574, "Norfolk Island", "Norfolk Islander"),
                new Country("Northern Mariana Islands", "MP", "MNP",580, "Northern Mariana Island", "Northern Mariana Islander"),
                new Country("Norway", "NO", "NOR",578, "Norwegian", "Norwegian"),
                new Country("Oman", "OM", "OMN",512, "Omani", "Omani"),
                new Country("Pakistan", "PK", "PAK",586, "Pakistani", "Pakistani"),
                new Country("Palau", "PW", "PLW",585, "Palauan", "Palauan"),
                new Country("Palestine, State of", "PS", "PSE",275, "Palestinian", "Palestinian"),
                new Country("Panama", "PA", "PAN",591, "Panamanian", "Panamanian"),
                new Country("Papua New Guinea", "PG", "PNG",598, "Papua New Guinean", "Papua New Guinean"),
                new Country("Paraguay", "PY", "PRY",600, "Paraguayan", "Paraguayan"),
                new Country("Peru", "PE", "PER",604, "Peruvian", "Peruvian"),
                new Country("Philippines", "PH", "PHL",608, "Filipino", "Filipino"),
                new Country("Pitcairn", "PN", "PCN",612, "Pitcairn Islander", "Pitcairn Islander"),
                new Country("Poland", "PL", "POL",616, "Polish", "Polish"),
                new Country("Portugal", "PT", "PRT",620, "Portuguese", "Portuguese"),
                new Country("Puerto Rico", "PR", "PRI",630, "Puerto Rican", "Puerto Rican"),
                new Country("Qatar", "QA", "QAT",634, "Qatari", "Qatari"),
                new Country("Réunion", "RE", "REU",638, "Réunionnais", "Réunionnais"),
                new Country("Romania", "RO", "ROU",642, "Romanian", "Romanian"),
                new Country("Russian Federation", "RU", "RUS",643, "Russian", "Russian"),
                new Country("Rwanda", "RW", "RWA",646, "Rwandan", "Rwandan"),
                new Country("Saint Barthélemy", "BL", "BLM",652, "Barthélemois", "Barthélemois"),
                new Country("Saint Helena, Ascension and Tristan da Cunha", "SH", "SHN",654, "Saint Helenian", "Saint Helenian"),
                new Country("Saint Kitts and Nevis", "KN", "KNA",659, "Kittian", "Kittian"),
                new Country("Saint Lucia", "LC", "LCA",662, "Saint Lucian", "Saint Lucian"),
                new Country("Saint Martin", "MF", "MAF",663, "Saint-Martinoise", "Saint-Martinoise"),
                new Country("Saint Pierre and Miquelon", "PM", "SPM",666, "Saint-Pierrais", "Saint-Pierrais"),
                new Country("Saint Vincent and the Grenadines", "VC", "VCT",670, "Saint Vincentian", "Saint Vincentian"),
                new Country("Samoa", "WS", "WSM",882, "Samoan", "Samoan"),
                new Country("San Marino", "SM", "SMR",674, "Sanmarinese", "Sanmarinese"),
                new Country("Sao Tome and Principe", "ST", "STP",678, "São Tomean", "São Tomean"),
                new Country("Saudi Arabia", "SA", "SAU",682, "Saudi Arabian", "Saudi Arabian"),
                new Country("Senegal", "SN", "SEN",686, "Senegalese", "Senegalese"),
                new Country("Serbia", "RS", "SRB",688, "Serbian", "Serbian"),
                new Country("Seychelles", "SC", "SYC",690, "Seychellois", "Seychellois"),
                new Country("Sierra Leone", "SL", "SLE",694, "Sierra Leonean", "Sierra Leonean"),
                new Country("Singapore", "SG", "SGP",702, "Singaporean", "Singaporean"),
                new Country("Sint Maarten", "SX", "SXM",534, "Sint Maarten", "Sint Maarten"),
                new Country("Slovakia", "SK", "SVK",703, "Slovakian", "Slovakian"),
                new Country("Slovenia", "SI", "SVN",705, "Slovenian", "Slovenian"),
                new Country("Solomon Islands", "SB", "SLB",90, "Solomon Islander", "Solomon Islander"),
                new Country("Somalia", "SO", "SOM",706, "Somali", "Somali"),
                new Country("South Africa", "ZA", "ZAF",710, "South African", "South African"),
                new Country("South Georgia and the South Sandwich Islands", "GS", "SGS",239, null, null),
                new Country("South Sudan", "SS", "SSD",728, "Sudanese", "Sudanese"),
                new Country("Spain", "ES", "ESP",724, "Spanish", "Spaniard"),
                new Country("Sri Lanka", "LK", "LKA",144, "Sri Lankan", "Sri Lankan"),
                new Country("Sudan", "SD", "SDN",729, "Sudanese", "Sudanese"),
                new Country("Suriname", "SR", "SUR",740, "Surinamer", "Surinamer"),
                new Country("Svalbard and Jan Mayen", "SJ", "SJM",744, null, null),
                new Country("Swaziland", "SZ", "SWZ",748, "Swazi", "Swazi"),
                new Country("Sweden", "SE", "SWE",752, "Swedish", "Swede"),
                new Country("Switzerland", "CH", "CHE",756, "Swiss", "Swiss"),
                new Country("Syrian Arab Republic", "SY", "SYR",760, "Syrian", "Syrian"),
                new Country("Taiwan", "TW", "TWN",158, "Taiwanese", "Taiwanese"),
                new Country("Tajikistan", "TJ", "TJK",762, "Tajikistani", "Tajikistani"),
                new Country("Tanzania, United Republic of", "TZ", "TZA",834, "Tanzanian", "Tanzanian"),
                new Country("Thailand", "TH", "THA",764, "Thai", "Thai"),
                new Country("Timor-Leste", "TL", "TLS",626, "Timorese", "Timorese"),
                new Country("Togo", "TG", "TGO",768, "Togolese", "Togolese"),
                new Country("Tokelau", "TK", "TKL",772, "Tokelauan", "Tokelauan"),
                new Country("Tonga", "TO", "TON",776, "Tongan", "Tongan"),
                new Country("Trinidad and Tobago", "TT", "TTO",780, "Trinidadian", "Trinidadian"),
                new Country("Tunisia", "TN", "TUN",788, "Tunisian", "Tunisian"),
                new Country("Turkey", "TR", "TUR",792, "Turkish", "Turkish"),
                new Country("Turkmenistan", "TM", "TKM",795, "Turkmen", "Turkmen"),
                new Country("Turks and Caicos Islands", "TC", "TCA",796, "Turks and Caicos Island", "Turks and Caicos Islander"),
                new Country("Tuvalu", "TV", "TUV",798, "Tuvaluan", "Tuvaluan"),
                new Country("Uganda", "UG", "UGA",800, "Ugandan", "Ugandan"),
                new Country("Ukraine", "UA", "UKR",804, "Ukrainian", "Ukrainian"),
                new Country("United Arab Emirates", "AE", "ARE",784, "Emirian", "Emirian"),
                new Country("United Kingdom", "GB", "GBR",826, "British", "British"),
                new Country("United States Minor Outlying Islands", "UM", "UMI",581, null, null),
                new Country("United States of America", "US", "USA",840, "American", "American"),
                new Country("Uruguay", "UY", "URY",858, "Uruguayan", "Uruguayan"),
                new Country("Uzbekistan", "UZ", "UZB",860, "Uzbekistani", "Uzbekistani"),
                new Country("Vanuatu", "VU", "VUT",548, "Ni-Vanuatu", "Ni-Vanuatu"),
                new Country("Venezuela", "VE", "VEN",862, "Venezuelan", "Venezuelan"),
                new Country("Viet Nam", "VN", "VNM",704, "Vietnamese", "Vietnamese"),
                new Country("British Virgin Islands", "VG", "VGB",92, "Virgin Island", "Virgin Islander"),
                new Country("U.S. Virgin Islands", "VI", "VIR",850, "Virgin Island", "Virgin Islander"),
                new Country("Wallis and Futuna", "WF", "WLF",876, "Wallisian", "Wallisian"),
                new Country("Western Sahara*", "EH", "ESH",732, "Western Saharan", "Western Saharan"),
                new Country("Yemen", "YE", "YEM",887, "Yemeni", "Yemeni"),
                new Country("Zambia", "ZM", "ZMB",894, "Zambian", "Zambian"),
                new Country("Zimbabwe", "ZW", "ZWE",716, "Zimbabwean", "Zimbabwean"),
            };
        }

        public Country(string name, string alpha2Code, string alpha3Code, int numericCode, string adjective, string demonym)
        {
            Name = name;
            Alpha2Code = alpha2Code;
            Alpha3Code = alpha3Code;
            Adjective = adjective;
            Demonym = demonym;
            NumericCode = numericCode;
        }

        /// <summary>
        /// Spain
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Spaniard
        /// </summary>
        public string Demonym { get; private set; }
        /// <summary>
        /// Spanish
        /// </summary>
        public string Adjective { get; private set; }
        /// <summary>
        /// ES
        /// </summary>
        public string Alpha2Code { get; private set; }
        /// <summary>
        /// ESP
        /// </summary>
        public string Alpha3Code { get; private set; }
        /// <summary>
        /// 724
        /// </summary>
        public int NumericCode { get; private set; }

        /// <summary>
        /// A demonym for this country exists and is specified
        /// </summary>
        public bool HasDemonym => !string.IsNullOrEmpty(Demonym);
        /// <summary>
        /// An adjective for this country exists and is specified
        /// </summary>
        public bool HasAdjective => !string.IsNullOrEmpty(Adjective);

        public static List<Country> Countries;

        public static Country GetBy2CharacterCode(string code)
        {
            if (code == null || code.Length != 2)
            {
                throw new ArgumentException($"Code '{code}' should be 2 characters long");
            }
            return Countries.Find(x => x.Alpha2Code == code);
        }

        public static Country GetBy3CharacterCode(string code)
        {
            if (code == null || code.Length != 3)
            {
                throw new ArgumentException($"Code '{code}' should be 3 characters long");
            }
            return Countries.Find(x => x.Alpha3Code == code);
        }

        public static Country GetByNumericCode(int code)
        {
            return Countries.Find(x => x.NumericCode == code);
        }
    }
}
