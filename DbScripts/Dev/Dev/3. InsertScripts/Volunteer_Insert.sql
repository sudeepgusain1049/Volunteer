
/***************************************************************************************************************************************/
IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblApiConsumers' )
BEGIN

SET IDENTITY_INSERT [dbo].[TblApiConsumers] ON 

INSERT [dbo].[TblApiConsumers] ([Id], [UserId], [ConsumerKey], [ConsumerSecret], [CallBackUrl], [RegistrationDate]) VALUES (1, 1, N'key', N'secret', N'ddd', N'2014-10-1')
SET IDENTITY_INSERT [dbo].[TblApiConsumers] OFF
INSERT [dbo].[TblMasterCategories] ([Id], [CategoryName], [IsActive]) VALUES (1, N'Unskilled volunteering', 1)
INSERT [dbo].[TblMasterCategories] ([Id], [CategoryName], [IsActive]) VALUES (2, N'Environmental volunteering', 1)
INSERT [dbo].[TblMasterCategories] ([Id], [CategoryName], [IsActive]) VALUES (3, N'Skills-based volunteering', 1)
INSERT [dbo].[TblMasterCategories] ([Id], [CategoryName], [IsActive]) VALUES (4, N'Volunteering in an emergency', 1)
INSERT [dbo].[TblMasterCategories] ([Id], [CategoryName], [IsActive]) VALUES (5, N'Volunteering in developing countries', 1)
INSERT [dbo].[TblMasterCategories] ([Id], [CategoryName], [IsActive]) VALUES (6, N'Volunteering in schools', 1)
INSERT [dbo].[TblMasterCategories] ([Id], [CategoryName], [IsActive]) VALUES (7, N'Virtual Volunteering', 1)
INSERT [dbo].[TblMasterCategories] ([Id], [CategoryName], [IsActive]) VALUES (8, N'Micro-volunteering', 1)
INSERT [dbo].[TblMasterCategories] ([Id], [CategoryName], [IsActive]) VALUES (9, N'Community voluntary work', 1)
INSERT [dbo].[TblMasterCategories] ([Id], [CategoryName], [IsActive]) VALUES (10, N'International work-camps', 1)
INSERT [dbo].[TblMasterCategories] ([Id], [CategoryName], [IsActive]) VALUES (11, N'Corporate volunteering', 1)

END


/***************************************************************************************************************************************/
IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterCountry' )
BEGIN
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AD', N'Andorra')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AE', N'United Arab Emirates')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AF', N'Afghanistan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AG', N'Antigua and Barbuda')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AI', N'Anguilla')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AL', N'Albania')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AM', N'Armenia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AN', N'Netherlands Antilles')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AO', N'Angola')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AQ', N'Antarctica')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AR', N'Argentina')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AS', N'American Samoa')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AT', N'Austria')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AU', N'Australia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AW', N'Aruba')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AX', N'Åland Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'AZ', N'Azerbaijan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BA', N'Bosnia and Herzegovina')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BB', N'Barbados')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BD', N'Bangladesh')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BE', N'Belgium')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BF', N'Burkina Faso')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BG', N'Bulgaria')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BH', N'Bahrain')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BI', N'Burundi')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BJ', N'Benin')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BL', N'Saint Barthélemy')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BM', N'Bermuda')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BN', N'Brunei')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BO', N'Bolivia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BQ', N'British Antarctic Territory')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BR', N'Brazil')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BS', N'Bahamas')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BT', N'Bhutan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BV', N'Bouvet Island')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BW', N'Botswana')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BY', N'Belarus')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'BZ', N'Belize')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CA', N'Canada')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CC', N'Cocos [Keeling] Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CD', N'Congo - Kinshasa')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CF', N'Central African Republic')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CG', N'Congo - Brazzaville')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CH', N'Switzerland')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CI', N'Côte d’Ivoire')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CK', N'Cook Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CL', N'Chile')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CM', N'Cameroon')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CN', N'China')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CO', N'Colombia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CR', N'Costa Rica')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CS', N'Serbia and Montenegro')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CT', N'Canton and Enderbury Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CU', N'Cuba')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CV', N'Cape Verde')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CX', N'Christmas Island')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CY', N'Cyprus')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'CZ', N'Czech Republic')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'DD', N'East Germany')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'DE', N'Germany')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'DJ', N'Djibouti')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'DK', N'Denmark')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'DM', N'Dominica')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'DO', N'Dominican Republic')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'DZ', N'Algeria')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'EC', N'Ecuador')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'EE', N'Estonia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'EG', N'Egypt')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'EH', N'Western Sahara')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'ER', N'Eritrea')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'ES', N'Spain')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'ET', N'Ethiopia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'FI', N'Finland')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'FJ', N'Fiji')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'FK', N'Falkland Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'FM', N'Micronesia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'FO', N'Faroe Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'FQ', N'French Southern and Antarctic Territories')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'FR', N'France')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'FX', N'Metropolitan France')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GA', N'Gabon')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GB', N'United Kingdom')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GD', N'Grenada')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GE', N'Georgia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GF', N'French Guiana')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GG', N'Guernsey')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GH', N'Ghana')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GI', N'Gibraltar')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GL', N'Greenland')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GM', N'Gambia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GN', N'Guinea')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GP', N'Guadeloupe')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GQ', N'Equatorial Guinea')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GR', N'Greece')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GS', N'South Georgia and the South Sandwich Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GT', N'Guatemala')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GU', N'Guam')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GW', N'Guinea-Bissau')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'GY', N'Guyana')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'HK', N'Hong Kong SAR China')


INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'HM', N'Heard Island and McDonald Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'HN', N'Honduras')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'HR', N'Croatia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'HT', N'Haiti')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'HU', N'Hungary')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'ID', N'Indonesia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'IE', N'Ireland')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'IL', N'Israel')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'IM', N'Isle of Man')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'IN', N'India')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'IO', N'British Indian Ocean Territory')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'IQ', N'Iraq')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'IR', N'Iran')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'IS', N'Iceland')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'IT', N'Italy')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'JE', N'Jersey')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'JM', N'Jamaica')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'JO', N'Jordan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'JP', N'Japan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'JT', N'Johnston Island')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'KE', N'Kenya')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'KG', N'Kyrgyzstan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'KH', N'Cambodia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'KI', N'Kiribati')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'KM', N'Comoros')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'KN', N'Saint Kitts and Nevis')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'KP', N'North Korea')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'KR', N'South Korea')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'KW', N'Kuwait')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'KY', N'Cayman Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'KZ', N'Kazakhstan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'LA', N'Laos')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'LB', N'Lebanon')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'LC', N'Saint Lucia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'LI', N'Liechtenstein')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'LK', N'Sri Lanka')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'LR', N'Liberia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'LS', N'Lesotho')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'LT', N'Lithuania')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'LU', N'Luxembourg')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'LV', N'Latvia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'LY', N'Libya')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MA', N'Morocco')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MC', N'Monaco')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MD', N'Moldova')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'ME', N'Montenegro')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MF', N'Saint Martin')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MG', N'Madagascar')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MH', N'Marshall Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MI', N'Midway Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MK', N'Macedonia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'ML', N'Mali')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MM', N'Myanmar [Burma]')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MN', N'Mongolia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MO', N'Macau SAR China')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MP', N'Northern Mariana Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MQ', N'Martinique')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MR', N'Mauritania')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MS', N'Montserrat')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MT', N'Malta')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MU', N'Mauritius')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MV', N'Maldives')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MW', N'Malawi')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MX', N'Mexico')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MY', N'Malaysia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'MZ', N'Mozambique')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NA', N'Namibia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NC', N'New Caledonia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NE', N'Niger')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NF', N'Norfolk Island')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NG', N'Nigeria')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NI', N'Nicaragua')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NL', N'Netherlands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NO', N'Norway')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NP', N'Nepal')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NQ', N'Dronning Maud Land')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NR', N'Nauru')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NT', N'Neutral Zone')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NU', N'Niue')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'NZ', N'New Zealand')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'OM', N'Oman')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PA', N'Panama')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PC', N'Pacific Islands Trust Territory')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PE', N'Peru')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PF', N'French Polynesia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PG', N'Papua New Guinea')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PH', N'Philippines')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PK', N'Pakistan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PL', N'Poland')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PM', N'Saint Pierre and Miquelon')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PN', N'Pitcairn Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PR', N'Puerto Rico')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PS', N'Palestinian Territories')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PT', N'Portugal')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PU', N'U.S. Miscellaneous Pacific Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PW', N'Palau')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PY', N'Paraguay')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'PZ', N'Panama Canal Zone')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'QA', N'Qatar')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'RE', N'Réunion')


INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'RO', N'Romania')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'RS', N'Serbia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'RU', N'Russia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'RW', N'Rwanda')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SA', N'Saudi Arabia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SB', N'Solomon Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SC', N'Seychelles')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SD', N'Sudan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SE', N'Sweden')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SG', N'Singapore')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SH', N'Saint Helena')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SI', N'Slovenia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SJ', N'Svalbard and Jan Mayen')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SK', N'Slovakia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SL', N'Sierra Leone')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SM', N'San Marino')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SN', N'Senegal')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SO', N'Somalia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SR', N'Suriname')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'ST', N'São Tomé and Príncipe')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SU', N'Union of Soviet Socialist Republics')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SV', N'El Salvador')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SY', N'Syria')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'SZ', N'Swaziland')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TC', N'Turks and Caicos Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TD', N'Chad')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TF', N'French Southern Territories')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TG', N'Togo')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TH', N'Thailand')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TJ', N'Tajikistan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TK', N'Tokelau')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TL', N'Timor-Leste')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TM', N'Turkmenistan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TN', N'Tunisia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TO', N'Tonga')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TR', N'Turkey')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TT', N'Trinidad and Tobago')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TV', N'Tuvalu')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TW', N'Taiwan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'TZ', N'Tanzania')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'UA', N'Ukraine')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'UG', N'Uganda')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'UM', N'U.S. Minor Outlying Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'US', N'United States')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'UY', N'Uruguay')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'UZ', N'Uzbekistan')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'VA', N'Vatican City')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'VC', N'Saint Vincent and the Grenadines')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'VD', N'North Vietnam')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'VE', N'Venezuela')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'VG', N'British Virgin Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'VI', N'U.S. Virgin Islands')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'VN', N'Vietnam')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'VU', N'Vanuatu')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'WF', N'Wallis and Futuna')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'WK', N'Wake Island')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'WS', N'Samoa')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'YD', N'People''s Democratic Republic of Yemen')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'YE', N'Yemen')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'YT', N'Mayotte')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'ZA', N'South Africa')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'ZM', N'Zambia')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'ZW', N'Zimbabwe')
INSERT [dbo].[TblMasterCountry] ([Id], [Name]) VALUES (N'ZZ', N'Unknown or Invalid Region')
END

/***************************************************************************************************************************************/

IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterDaysOfWeek' )
BEGIN


INSERT [dbo].[TblMasterDaysOfWeek] ([Id], [DaysOfWeek], [IsActive]) VALUES (1, N'Monday', 1)
INSERT [dbo].[TblMasterDaysOfWeek] ([Id], [DaysOfWeek], [IsActive]) VALUES (2, N'Tuesday', 1)
INSERT [dbo].[TblMasterDaysOfWeek] ([Id], [DaysOfWeek], [IsActive]) VALUES (3, N'Wednesday', 1)
INSERT [dbo].[TblMasterDaysOfWeek] ([Id], [DaysOfWeek], [IsActive]) VALUES (4, N'Thursday', 1)
INSERT [dbo].[TblMasterDaysOfWeek] ([Id], [DaysOfWeek], [IsActive]) VALUES (5, N'Friday', 1)
INSERT [dbo].[TblMasterDaysOfWeek] ([Id], [DaysOfWeek], [IsActive]) VALUES (6, N'Saturday', 1)
INSERT [dbo].[TblMasterDaysOfWeek] ([Id], [DaysOfWeek], [IsActive]) VALUES (7, N'Sunday', 1)

END


/***************************************************************************************************************************************/

IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterInterval' )
BEGIN


INSERT [dbo].[TblMasterInterval] ([Id], [Interval], [IsActive]) VALUES (1, N'Full Day', 1)
INSERT [dbo].[TblMasterInterval] ([Id], [Interval], [IsActive]) VALUES (2, N'Morning', 1)
INSERT [dbo].[TblMasterInterval] ([Id], [Interval], [IsActive]) VALUES (3, N'Afternoon', 1)
INSERT [dbo].[TblMasterInterval] ([Id], [Interval], [IsActive]) VALUES (4, N'Evening', 1)
INSERT [dbo].[TblMasterInterval] ([Id], [Interval], [IsActive]) VALUES (5, N'Late Night', 1)


END

/***************************************************************************************************************************************/
IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterJobAppropriateForInfo' )
BEGIN

INSERT [dbo].[TblMasterJobAppropriateForInfo] ([Id], [AppropriateForInfo], [IsActive]) VALUES (1, N'Family', 1)
INSERT [dbo].[TblMasterJobAppropriateForInfo] ([Id], [AppropriateForInfo], [IsActive]) VALUES (2, N'Groups', 1)

END

/***************************************************************************************************************************************/
IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterJobIntVolunteerInfo' )
BEGIN

INSERT [dbo].[TblMasterJobIntVolunteerInfo] ([Id], [IntVolunteerInfo], [IsActive]) VALUES (1, N'Housing available', 1)
INSERT [dbo].[TblMasterJobIntVolunteerInfo] ([Id], [IntVolunteerInfo], [IsActive]) VALUES (2, N'Language/cultural support available', 1)
INSERT [dbo].[TblMasterJobIntVolunteerInfo] ([Id], [IntVolunteerInfo], [IsActive]) VALUES (3, N'International volunteers welcome', 1)
END

/***************************************************************************************************************************************/
IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterJobAdditionalInfo' )
BEGIN

INSERT [dbo].[TblMasterJobAdditionalInfo] ([Id], [AdditionalInfo], [IsActive]) VALUES (1, N'Training provided', 1)
INSERT [dbo].[TblMasterJobAdditionalInfo] ([Id], [AdditionalInfo], [IsActive]) VALUES (2, N'Fee required', 1)
INSERT [dbo].[TblMasterJobAdditionalInfo] ([Id], [AdditionalInfo], [IsActive]) VALUES (3, N'Stipend provided', 1)
END


/***************************************************************************************************************************************/
IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterDiploma' )
BEGIN

INSERT [dbo].[TblMasterDiploma] ([Id], [DiplomaName], [IsActive]) VALUES (1, N'First Aid Diploma', 1)
INSERT [dbo].[TblMasterDiploma] ([Id], [DiplomaName], [IsActive]) VALUES (2, N'Football Referee License', 1)
INSERT [dbo].[TblMasterDiploma] ([Id], [DiplomaName], [IsActive]) VALUES (3, N'Active Volunteering', 1)
INSERT [dbo].[TblMasterDiploma] ([Id], [DiplomaName], [IsActive]) VALUES (4, N'Training and Assessmement', 1)
INSERT [dbo].[TblMasterDiploma] ([Id], [DiplomaName], [IsActive]) VALUES (5, N'Program Coordination', 1)
INSERT [dbo].[TblMasterDiploma] ([Id], [DiplomaName], [IsActive]) VALUES (6, N'Community Service Coordination', 1)
INSERT [dbo].[TblMasterDiploma] ([Id], [DiplomaName], [IsActive]) VALUES (7, N'Effective Communication', 1)
INSERT [dbo].[TblMasterDiploma] ([Id], [DiplomaName], [IsActive]) VALUES (8, N'Negotiation', 1)
INSERT [dbo].[TblMasterDiploma] ([Id], [DiplomaName], [IsActive]) VALUES (9, N'Customer Service', 1)
INSERT [dbo].[TblMasterDiploma] ([Id], [DiplomaName], [IsActive]) VALUES (10, N'Risk Management', 1)


END


/***************************************************************************************************************************************/
IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterOrganizationType' )
BEGIN

INSERT [dbo].[TblMasterOrganizationType] ([Id], [OrganizationType], [IsActive]) VALUES (1, N'Company', 1)
INSERT [dbo].[TblMasterOrganizationType] ([Id], [OrganizationType], [IsActive]) VALUES (2, N'Social entreprise', 1)
INSERT [dbo].[TblMasterOrganizationType] ([Id], [OrganizationType], [IsActive]) VALUES (3, N'Governement', 1)
INSERT [dbo].[TblMasterOrganizationType] ([Id], [OrganizationType], [IsActive]) VALUES (4, N'Non-profit', 1)
INSERT [dbo].[TblMasterOrganizationType] ([Id], [OrganizationType], [IsActive]) VALUES (5, N'Volunteer organization', 1)
END

/***************************************************************************************************************************************/
IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterSkills' )
BEGIN
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (1, N'Answering Telephones', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (2, N'Accounting', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (3, N'Administration', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (4, N'Business Correspondence', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (5, N'Client Relations', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (6, N'Communication', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (7, N'Crowd Control', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (8, N'Crime & Safety', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (9, N'Customer Service', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (10, N'Clerical', 1)

INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (11, N'Document Management', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (12, N'Disaster Relief', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (13, N'Document Management', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (14, N'Event Coordination', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (15, N'Employee Relations', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (16, N'Legal Familiarity', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (17, N'Meeting Planning', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (18, N'Office Administration', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (19, N'Organizational Skills', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (20, N'Public Relations', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (21, N'Public Speaking', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (22, N'People Management', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (23, N'Receptionist', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (24, N'Stenography', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (25, N'Travel Arrangements', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (26, N'Word Processing', 1)
INSERT [dbo].[TblMasterSkills] ([Id], [SkillName], [IsActive]) VALUES (27, N'Written Communication', 1)




END

/***************************************************************************************************************************************/

IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterWorkArea' )
BEGIN

INSERT [dbo].[TblMasterWorkArea] ([Id], [WorkAreaName], [IsActive]) VALUES (1, N'Agriculture', 1)
INSERT [dbo].[TblMasterWorkArea] ([Id], [WorkAreaName], [IsActive]) VALUES (2, N'Animals', 1)
INSERT [dbo].[TblMasterWorkArea] ([Id], [WorkAreaName], [IsActive]) VALUES (3, N'Arts', 1)
INSERT [dbo].[TblMasterWorkArea] ([Id], [WorkAreaName], [IsActive]) VALUES (4, N'Civic engegement', 1)
INSERT [dbo].[TblMasterWorkArea] ([Id], [WorkAreaName], [IsActive]) VALUES (5, N'Communications access', 1)
INSERT [dbo].[TblMasterWorkArea] ([Id], [WorkAreaName], [IsActive]) VALUES (6, N'Community development', 1)
INSERT [dbo].[TblMasterWorkArea] ([Id], [WorkAreaName], [IsActive]) VALUES (7, N'Conflict resolution', 1)
INSERT [dbo].[TblMasterWorkArea] ([Id], [WorkAreaName], [IsActive]) VALUES (8, N'Consumer protection', 1)
INSERT [dbo].[TblMasterWorkArea] ([Id], [WorkAreaName], [IsActive]) VALUES (9, N'Crime & Safety', 1)
INSERT [dbo].[TblMasterWorkArea] ([Id], [WorkAreaName], [IsActive]) VALUES (10, N'Disability', 1)

END

/***************************************************************************************************************************************/
IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblUsers' )
BEGIN

INSERT [dbo].[TblUsers] ([Id], [FirstName], [LastName], [Email], [UserName], [Password], [City], [Country], [IsEmailSubsription], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (1, N'magdy', N'gameel', N'magdy.bedeer@gmail.com', N'magdyBedeer', N'password', N'tanta', 10, 1, CAST(0x0000A3D5013B70A9 AS DateTime), NULL, 1)
INSERT [dbo].[TblUsers] ([Id], [FirstName], [LastName], [Email], [UserName], [Password], [City], [Country], [IsEmailSubsription], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (2, N'magdy', N'gameel', N'magdy.bedeer@gmail.com', N'magdyBedeer', N'password', N'tanta', 10, 1, CAST(0x0000A3D600D9E1AF AS DateTime), NULL, 1)
INSERT [dbo].[TblUsers] ([Id], [FirstName], [LastName], [Email], [UserName], [Password], [City], [Country], [IsEmailSubsription], [CreatedDate], [UpdatedDate], [IsActive]) VALUES (3, N'magdy', N'gameel', N'magdy.bedeer@gmail.com', N'magdyBedeer', N'password', N'tanta', 10, 1, CAST(0x0000A3D701651D31 AS DateTime), NULL, 1)

END

/***************************************************************************************************************************************/

IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterTimeCommitments' )
BEGIN
INSERT [dbo].[TblMasterTimeCommitments] ([Id], [Commitment], [IsActive]) VALUES (1, N'Occasional (weekly or monthly)', 1)
INSERT [dbo].[TblMasterTimeCommitments] ([Id], [Commitment], [IsActive]) VALUES (2, N'Part-time (10+ hours/week)', 1)
INSERT [dbo].[TblMasterTimeCommitments] ([Id], [Commitment], [IsActive]) VALUES (3, N'Full time (30-40 hours/week)', 1)
INSERT [dbo].[TblMasterTimeCommitments] ([Id], [Commitment], [IsActive]) VALUES (4, N'One day or evening (a few hours or less)', 1)

END

/***************************************************************************************************************************************/


IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterLanguages' )
BEGIN
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (1, N'Afrikaans', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (2, N'Albanian ', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (3, N'Arabic', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (4, N'Armenian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (5, N'Azerbaijani', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (6, N'Basque', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (7, N'Belarusian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (8, N'Bengali', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (9, N'Bosnian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (10, N'Bulgarian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (11, N'Catalan', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (12, N'Cebuano', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (13, N'Chinese', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (14, N'Danish', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (15, N'Dutch', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (16, N'English', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (17, N'Esperanto', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (18, N'Estonian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (19, N'Filipino', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (20, N'French', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (21, N'Georgian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (22, N'German', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (23, N'Greek', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (24, N'Hausa', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (25, N'Hebrew', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (26, N'Hindi', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (27, N'Hungarian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (28, N'Indonesian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (29, N'Irish', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (30, N'Italian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (31, N'Japanese', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (32, N'Korean', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (33, N'Lao', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (34, N'Latin', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (35, N'Mongolian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (36, N'Norwegian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (37, N'Persian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (38, N'Portuguese', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (39, N'Punjabi', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (40, N'Romanian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (41, N'Russian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (42, N'Serbian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (43, N'Spanish', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (44, N'Swedish', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (45, N'Thai', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (46, N'Turkish', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (47, N'Ukrainian', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (48, N'Urdu', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (49, N'Vietnamese', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (50, N'Welsh', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (51, N'Yoruba', 1)
INSERT [dbo].[TblMasterLanguages] ([Id], [Language], [IsActive]) VALUES (52, N'Zulu', 1)


END

/***************************************************************************************************************************************/


IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterScreeningQuestions' )
BEGIN
INSERT [dbo].[TblMasterScreeningQuestions] ([Id], [Question], [IsActive]) VALUES (1, N'Have you taken any Volunteer tests and done well on them that you think are relevant to this job?', 1)
INSERT [dbo].[TblMasterScreeningQuestions] ([Id], [Question], [IsActive]) VALUES (2, N'Why did you apply to this particular job?', 1)
INSERT [dbo].[TblMasterScreeningQuestions] ([Id], [Question], [IsActive]) VALUES (3, N'Which part of the project do you think will take the most time?', 1)
INSERT [dbo].[TblMasterScreeningQuestions] ([Id], [Question], [IsActive]) VALUES (4, N'Do you have any questions about the job description?', 1)
INSERT [dbo].[TblMasterScreeningQuestions] ([Id], [Question], [IsActive]) VALUES (5, N'Do you have any suggestions to make this project run successfully?', 1)
INSERT [dbo].[TblMasterScreeningQuestions] ([Id], [Question], [IsActive]) VALUES (6, N'Why do you think you are a good fit for this particular project?', 1)
INSERT [dbo].[TblMasterScreeningQuestions] ([Id], [Question], [IsActive]) VALUES (7, N'What challenging part of this job are you most experienced in?', 1)
INSERT [dbo].[TblMasterScreeningQuestions] ([Id], [Question], [IsActive]) VALUES (8, N'Which of the required job skills do you feel you you are strongest at?', 1)
INSERT [dbo].[TblMasterScreeningQuestions] ([Id], [Question], [IsActive]) VALUES (9, N'What questions do you have about the project?', 1)
INSERT [dbo].[TblMasterScreeningQuestions] ([Id], [Question], [IsActive]) VALUES (10, N'What past project or job have you had that is most like this one and why?', 1)
INSERT [dbo].[TblMasterScreeningQuestions] ([Id], [Question], [IsActive]) VALUES (11, N'Additional-Question', 1)
END

/***************************************************************************************************************************************/




IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterJobTypes' )
BEGIN
INSERT [dbo].[TblMasterJobTypes] ([Id], [JobType], [IsActive]) VALUES (1, N'Job', 1)
INSERT [dbo].[TblMasterJobTypes] ([Id], [JobType], [IsActive]) VALUES (2, N'Internship', 1)
INSERT [dbo].[TblMasterJobTypes] ([Id], [JobType], [IsActive]) VALUES (3, N'Event', 1)

END

/***************************************************************************************************************************************/
