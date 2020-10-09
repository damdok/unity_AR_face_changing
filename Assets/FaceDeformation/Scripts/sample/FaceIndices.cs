using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
 
public class FaceIndices {

	private static int[] addingIndices = new int[]{       
			//左目
			1074 , 1064 , 1063 ,
			1075 , 1063 , 1062 ,
			1073 , 1065 , 1064 ,
			1071 , 1066 , 1065 ,
			1073 , 1072 , 1065 ,
			1070 , 1067 , 1066 ,
			1068 , 1067 , 1070 ,
			1061 , 1077 , 1076 ,
			1084 , 1078 , 1077 ,
			1079 , 1078 , 1084 ,
			1080 , 1079 , 1083 ,
			1082 , 1081 , 1080 ,
			1075 , 1074 , 1063 ,
			1076 , 1075 , 1062 ,
			1074 , 1073 , 1064 ,
			1072 , 1071 , 1065 ,
			1071 , 1070 , 1066 ,
			1069 , 1068 , 1070 ,
			1062 , 1061 , 1076 ,
			1061 , 1084 , 1077 ,
			1083 , 1079 , 1084 ,
			1082 , 1080 , 1083,
			//右目
			1093 , 1086 , 1085 ,
			1094 , 1085 , 1108 ,
			1092 , 1087 , 1086 ,
			1090 , 1088 , 1087 ,
			1091 , 1090 , 1087 ,
			1090 , 1089 , 1088 ,
			1107 , 1096 , 1095 ,
			1106 , 1097 , 1096 ,
			1098 , 1097 , 1106 ,
			1099 , 1098 , 1105 ,
			1100 , 1099 , 1104 ,
			1102 , 1101 , 1100 ,
			1094 , 1093 , 1085 ,
			1095 , 1094 , 1108 ,
			1093 , 1092 , 1086 ,
			1092 , 1091 , 1087 ,
			1108 , 1107 , 1095 ,
			1107 , 1106 , 1096 ,
			1105 , 1098 , 1106 ,
			1104 , 1099 , 1105 ,
			1103 , 1100 , 1104 ,
			1103 , 1102 , 1100 ,
			//口
			709 , 691 , 690 ,
			725 , 690 , 689 ,
			24 , 691 , 700 ,
			709 , 700 , 691 ,
			256 , 24 , 25 ,
			256 , 265 , 274 ,
			255 , 274 , 290 ,
			254 , 290 , 275 ,
			253 , 247 , 248 ,
			275 , 247 , 253 ,
			252 , 248 , 305 ,
			305 , 404 , 251 ,
			250 , 251 , 404 ,
			249 , 393 , 250 ,
			688 , 682 , 710 ,
			683 , 682 , 688 ,
			687 , 740 , 683 ,
			686 , 834 , 740 ,
			685 , 684 , 834 ,
			685 , 823 , 684 ,
			725 , 709 , 690 ,
			710 , 725 , 689 ,
			25 , 24 , 700 ,
			265 , 256 , 25 ,
			255 , 256 , 274 ,
			254 , 255 , 290 ,
			253 , 254 , 275 ,
			252 , 253 , 248 ,
			251 , 252 , 305 ,
			249 , 250 , 404 ,
			689 , 688 , 710 ,
			687 , 683 , 688 ,
			687 , 686 , 740 ,
			686 , 685 , 834
		};

	public static int[] indicies = new int[]{
1201,45,44,1200,45,1201,1200,42,45,1199,42,1200,1197,47,40,1196,47,1197,1196,48,47,1195,48,1196,1188,52,1189,51,52,1188,1185,55,53,1184,55,1185,1184,56,55,1183,56,1184,0,90,83,1,90,0,85,100,84,99,100,85,84,102,101,100,102,84,58,191,112,109,191,58,260,29,30,261,29,260,134,145,146,133,145,134,133,138,145,144,138,133,148,65,64,147,65,148,13,157,158,12,157,13,52,1190,1189,169,1190,52,172,409,173,408,409,172,173,410,174,409,410,173,174,411,175,410,411,174,411,176,175,412,176,411,148,181,180,64,181,148,402,181,401,180,181,402,64,182,181,63,182,64,401,182,400,181,182,401,400,183,399,182,183,400,182,62,183,63,62,182,399,184,398,183,184,399,398,185,397,184,185,398,30,259,260,31,259,30,118,115,110,119,115,118,119,123,116,1212,123,119,111,191,109,192,191,111,110,192,111,115,192,110,119,194,115,116,194,119,115,195,192,194,195,115,192,193,191,195,193,192,269,261,260,270,261,269,116,279,280,123,279,116,165,198,164,201,198,165,199,197,198,162,197,199,198,200,199,201,200,198,132,201,165,166,201,132,6,428,126,37,428,6,126,429,125,428,429,126,125,430,71,429,430,125,71,431,72,430,431,71,101,185,184,102,185,101,101,291,84,62,291,101,184,62,101,183,62,184,64,205,63,65,205,64,199,227,228,200,227,199,199,229,162,228,229,199,230,209,210,231,209,230,23,237,22,93,237,23,97,238,95,239,238,97,97,240,239,105,240,97,105,241,240,106,241,105,106,242,241,103,242,106,103,243,242,187,243,103,187,395,243,394,395,187,121,277,246,276,277,121,289,272,288,273,272,289,273,263,272,264,263,273,26,263,264,27,263,26,25,264,265,26,264,25,274,264,273,265,264,274,290,273,289,274,273,290,275,121,247,276,121,275,1218,247,121,248,247,1218,106,253,252,105,253,106,105,254,253,97,254,105,254,95,255,97,95,254,24,93,23,256,93,24,275,289,276,290,289,275,276,288,277,289,288,276,280,286,285,279,286,280,113,58,112,59,58,113,80,203,142,67,203,80,56,1156,55,1133,1156,56,55,1155,53,1156,1155,55,51,1151,52,1152,1151,51,1151,161,207,1152,161,1151,52,1150,169,1151,1150,52,1150,207,170,1151,207,1150,48,1144,47,1145,1144,48,47,1143,40,1144,1143,47,42,1140,45,1141,1140,42,45,1139,44,1140,1139,45,140,298,143,294,298,140,143,141,140,137,141,143,156,10,9,302,10,156,144,160,135,133,160,144,133,49,160,134,49,133,63,291,62,205,291,63,84,296,85,291,296,84,70,98,89,91,98,70,142,294,140,203,294,142,83,91,70,90,91,83,238,93,95,237,93,238,95,256,255,93,256,95,305,1218,306,248,1218,305,189,406,244,405,406,189,404,189,249,405,189,404,394,250,393,187,250,394,187,251,250,103,251,187,103,252,251,106,252,103,22,92,21,237,92,22,1,92,90,21,92,1,237,94,92,238,94,237,90,94,91,92,94,90,238,96,94,239,96,238,91,96,98,94,96,91,239,108,96,240,108,239,98,85,89,99,85,98,108,98,96,99,98,108,240,107,108,241,107,240,108,100,99,107,100,108,241,104,107,242,104,241,107,102,100,104,102,107,104,185,102,186,185,104,242,186,104,243,186,242,243,396,186,395,396,243,186,397,185,396,397,186,244,407,190,406,407,244,306,1219,245,1218,1219,306,122,1212,120,123,1212,122,121,1219,1218,246,1219,121,246,278,122,277,278,246,122,279,123,278,279,122,277,287,278,288,287,277,278,286,279,287,286,278,286,269,285,270,269,286,288,271,287,272,271,288,287,270,286,271,270,287,272,262,271,263,262,272,270,262,261,271,262,270,263,28,262,27,28,263,262,29,261,28,29,262,89,88,70,86,88,89,70,293,83,88,293,70,83,2,0,293,2,83,89,296,86,85,296,89,205,296,291,309,296,205,65,309,205,310,309,65,65,311,310,147,311,65,147,320,311,150,320,147,310,438,309,437,438,310,296,440,86,439,440,296,438,296,309,439,296,438,204,308,312,297,308,204,304,138,144,281,138,304,315,303,316,139,303,315,281,317,138,314,317,281,316,137,143,301,137,316,139,314,281,313,314,139,437,311,436,310,311,437,304,139,281,303,139,304,144,136,304,135,136,144,316,299,301,303,299,316,136,303,304,299,303,136,302,365,300,363,365,302,300,12,11,157,12,300,10,300,11,302,300,10,206,66,297,68,66,206,203,68,206,67,68,203,69,68,67,1205,68,69,297,87,308,66,87,297,86,307,88,440,307,86,436,320,435,311,320,436,138,318,145,317,318,138,145,319,146,318,319,145,1143,41,40,1142,41,1143,41,1197,40,1198,1197,41,321,435,320,434,435,321,322,434,321,433,434,322,1142,42,41,1141,42,1142,88,323,293,307,323,88,2,323,3,293,323,2,316,298,315,143,298,316,139,292,313,315,292,139,203,202,294,206,202,203,206,204,202,297,204,206,204,325,202,292,325,204,298,202,325,294,202,298,204,313,292,312,313,204,292,298,325,315,298,292,42,1198,41,1199,1198,42,1188,50,51,1187,50,1188,1186,50,1187,54,50,1186,198,326,164,197,326,198,50,1152,51,1153,1152,50,1152,163,161,1153,163,1152,161,328,207,327,328,161,231,159,209,232,159,231,210,328,327,209,328,210,229,334,162,333,334,229,230,334,333,210,334,230,162,335,197,334,335,162,334,327,335,210,327,334,327,163,335,161,163,327,1155,54,53,1154,54,1155,54,1153,50,1154,1153,54,197,163,326,335,163,197,54,1185,53,1186,1185,54,112,193,196,191,193,112,113,196,114,112,196,113,344,34,35,257,34,344,258,268,259,267,268,258,258,31,32,259,31,258,258,33,346,32,33,258,257,33,34,346,33,257,346,267,258,345,267,346,280,284,336,285,284,280,336,116,280,194,116,336,194,337,195,336,337,194,195,338,193,337,338,195,114,340,341,196,340,114,196,338,340,193,338,196,336,283,337,284,283,336,337,339,338,283,339,337,338,282,340,339,282,338,340,342,341,282,342,340,285,268,284,269,268,285,260,268,269,259,268,260,284,267,283,268,267,284,267,339,283,345,339,267,346,266,345,257,266,346,339,266,282,345,266,339,257,343,266,344,343,257,282,343,342,266,343,282,169,1149,171,1150,1149,169,1149,170,168,1150,170,1149,1191,169,171,1190,169,1191,1146,48,426,1145,48,1146,44,1138,43,1139,1138,44,1192,171,357,1191,171,1192,1138,356,43,1137,356,1138,1149,357,171,1148,357,1149,158,364,361,157,364,158,302,362,363,156,362,302,157,365,364,300,365,157,362,129,372,156,129,362,71,128,125,374,128,71,125,127,126,128,127,125,372,127,128,129,127,372,156,8,129,9,8,156,126,7,6,127,7,126,129,7,127,8,7,129,1137,378,377,1138,378,1137,1139,378,1138,379,378,1139,1140,379,1139,380,379,1140,1141,380,1140,381,380,1141,1141,382,381,1142,382,1141,1143,382,1142,383,382,1143,1144,383,1143,384,383,1144,1145,384,1144,385,384,1145,1145,386,385,1146,386,1145,378,153,155,379,153,378,379,154,153,380,154,379,380,322,154,381,322,380,322,382,433,381,382,322,319,384,146,383,384,319,233,159,232,349,159,233,158,14,13,387,14,158,36,387,427,14,387,36,158,367,387,361,367,158,207,329,170,328,329,207,359,347,360,168,347,359,367,427,387,366,427,367,209,329,328,159,329,209,168,420,347,348,420,168,422,18,421,19,18,422,347,15,360,16,15,347,329,349,348,159,349,329,347,17,16,420,17,347,421,17,420,18,17,421,43,1201,44,1202,1201,43,1136,377,388,1137,377,1136,388,389,353,377,389,388,389,378,155,377,378,389,189,393,249,394,393,189,394,244,395,189,244,394,395,190,396,244,190,395,396,188,397,190,188,396,398,188,172,397,188,398,173,398,172,399,398,173,174,399,173,400,399,174,175,400,174,401,400,175,176,401,175,402,401,176,404,306,405,305,306,404,405,245,406,306,245,405,406,117,407,245,117,406,1211,407,117,1210,407,1211,118,1210,1211,408,1210,118,408,110,409,118,110,408,409,111,410,110,111,409,410,109,411,111,109,410,411,58,412,109,58,411,412,59,413,58,59,412,132,419,166,418,419,132,417,1133,56,1134,1133,417,356,1202,43,1203,1202,356,1204,356,416,1203,356,1204,1137,416,356,1136,416,1137,56,1182,417,1183,1182,56,48,1194,426,1195,1194,48,170,348,168,329,348,170,233,421,349,422,421,233,349,420,348,421,420,349,366,360,427,359,360,366,36,360,15,427,360,36,433,383,319,382,383,433,433,318,434,319,318,433,434,317,435,318,317,434,314,435,317,436,435,314,313,436,314,437,436,313,437,312,438,313,312,437,438,308,439,312,308,438,439,87,440,308,87,439,440,441,307,87,441,440,66,441,87,442,441,66,68,442,66,1205,442,68,386,134,385,49,134,386,146,385,134,384,385,146,320,151,321,150,151,320,154,321,151,322,321,154,147,149,150,148,149,147,148,179,149,180,179,148,179,402,403,180,402,179,412,177,176,413,177,412,402,177,403,176,177,402,154,152,153,151,152,154,150,447,151,149,447,150,153,354,155,152,354,153,179,449,448,403,449,179,149,448,447,179,448,149,447,452,451,448,452,447,152,447,451,151,447,152,354,451,455,152,451,354,418,355,419,415,355,418,388,355,415,353,355,388,46,1134,417,1135,1134,46,1136,46,416,1135,46,1136,46,1204,416,1181,1204,46,417,1181,46,1182,1181,417,358,1194,1193,426,1194,358,1192,358,1193,357,358,1192,1148,358,357,1147,358,1148,358,1146,426,1147,1146,358,1148,432,1147,359,432,1148,432,366,370,359,366,432,1146,432,386,1147,432,1146,371,49,370,160,49,371,386,370,49,432,370,386,160,368,135,371,368,160,370,367,371,366,367,370,369,135,368,136,135,369,367,368,371,361,368,367,368,364,369,361,364,368,446,136,369,299,136,446,299,445,301,446,445,299,364,446,369,365,446,364,301,444,137,445,444,301,365,445,446,363,445,365,137,373,141,444,373,137,445,362,444,363,362,445,142,141,82,140,141,142,373,82,141,374,82,373,444,372,373,362,372,444,128,373,372,374,373,128,201,234,200,166,234,201,355,178,375,353,178,355,178,389,390,353,389,178,389,354,390,155,354,389,458,178,459,375,178,458,390,455,456,354,455,390,459,390,463,178,390,459,463,456,469,390,456,463,234,419,235,166,419,234,474,235,475,234,235,474,419,375,235,355,375,419,375,475,235,458,475,375,200,474,227,234,474,200,469,457,470,456,457,469,403,450,449,177,450,403,177,414,450,413,414,177,414,479,450,478,479,414,452,449,453,448,449,452,449,479,453,450,479,449,456,454,457,455,454,456,455,452,454,451,452,455,479,480,481,478,480,479,457,483,476,454,483,457,470,476,460,457,476,470,480,484,481,482,484,480,479,483,453,481,483,479,481,476,483,484,476,481,452,483,454,453,483,452,482,476,484,460,476,482,67,79,69,80,79,67,80,82,81,142,82,80,374,81,82,71,81,374,71,443,81,72,443,71,80,443,79,81,443,80,3,324,4,323,324,3,37,124,428,5,124,37,124,38,485,5,38,124,38,324,485,4,324,38,428,75,429,124,75,428,323,76,324,307,76,323,324,486,485,76,486,324,124,486,75,485,486,124,429,73,430,75,73,429,307,77,76,441,77,307,76,487,486,77,487,76,75,487,73,486,487,75,430,74,431,73,74,430,441,78,77,442,78,441,77,488,487,78,488,77,73,488,74,487,488,73,474,473,236,475,473,474,236,466,214,473,466,236,39,945,467,946,945,39,167,949,948,213,949,167,222,217,223,216,217,222,228,223,229,222,223,228,330,951,950,212,951,330,230,332,224,333,332,230,213,950,949,330,950,213,223,331,332,217,331,223,218,332,331,224,332,218,229,332,333,223,332,229,232,350,233,226,350,232,226,351,350,220,351,226,953,352,954,131,352,953,413,60,414,59,60,413,422,350,423,233,350,422,352,955,954,425,955,352,19,423,1041,422,423,19,423,1022,1041,424,1022,423,350,424,423,351,424,350,20,955,425,956,955,20,391,482,461,460,482,391,928,462,905,927,462,928,928,935,927,936,935,928,480,461,482,61,461,480,926,462,927,392,462,926,968,467,945,57,467,968,945,1023,968,466,1023,945,473,458,472,475,458,473,472,459,471,458,459,472,931,208,295,930,208,931,463,465,464,469,465,463,931,938,930,939,938,931,471,463,464,459,463,471,922,917,918,998,917,922,998,916,917,997,916,998,915,997,996,916,997,915,39,947,946,130,947,39,227,236,221,474,236,227,167,947,130,948,947,167,216,221,215,222,221,216,221,214,215,236,214,221,228,221,222,227,221,228,211,953,952,131,953,211,232,225,226,231,225,232,951,211,952,212,211,951,224,219,225,218,219,224,220,225,219,226,225,220,230,225,231,224,225,230,923,918,919,922,918,923,922,989,988,923,989,922,924,919,920,923,919,924,929,208,930,904,208,929,465,470,468,469,470,465,928,904,929,905,904,928,928,937,936,929,937,928,930,937,929,938,937,930,460,468,470,391,468,460,914,996,995,915,996,914,925,392,926,921,392,925,480,477,61,478,477,480,924,921,925,920,921,924,924,933,932,925,933,924,926,933,925,934,933,926,414,477,478,60,477,414,967,295,376,931,295,967,968,376,57,967,376,968,1094,1189,1093,1188,1189,1094,1086,1195,1196,1087,1195,1086,1086,1197,1085,1196,1197,1086,1085,1198,1108,1197,1198,1085,1107,1198,1199,1108,1198,1107,1106,1199,1200,1107,1199,1106,1106,1201,1105,1200,1201,1106,1105,1202,1104,1201,1202,1105,1104,1203,1103,1202,1203,1104,1103,1204,1102,1203,1204,1103,1102,1181,1101,1204,1181,1102,1100,1181,1182,1101,1181,1100,1099,1182,1183,1100,1182,1099,1096,1185,1186,1097,1185,1096,490,1165,1164,497,1165,490,498,1165,497,1166,1165,498,494,1161,1160,495,1161,494,492,1161,495,1162,1161,492,503,1177,1176,505,1177,503,1179,506,847,1178,506,1179,506,1177,505,1178,1177,506,502,1173,1172,501,1173,502,1171,502,1172,618,502,1171,1125,501,502,1126,501,1125,1130,506,505,1131,506,1130,539,0,532,1,0,539,549,534,533,548,534,549,551,533,550,549,533,551,640,507,561,558,507,640,29,695,30,696,695,29,594,583,595,582,583,594,587,582,594,593,582,587,514,597,513,596,597,514,606,13,607,12,13,606,1124,502,618,1125,502,1124,839,621,622,838,621,839,840,622,623,839,622,840,841,623,624,840,623,841,625,841,624,842,841,625,630,597,629,513,597,630,630,832,831,629,832,630,631,513,630,512,513,631,631,831,830,630,831,631,632,830,829,631,830,632,511,631,632,512,631,511,633,829,828,632,829,633,634,828,827,633,828,634,694,30,695,31,30,694,1209,567,1207,838,567,1209,564,567,559,568,567,564,640,560,558,641,560,640,641,559,560,564,559,641,643,568,564,565,568,643,644,564,641,643,564,644,642,641,640,644,641,642,696,704,695,705,704,696,714,565,715,572,565,714,647,614,613,650,614,647,646,648,647,611,648,646,649,647,648,650,647,649,650,581,614,615,581,650,856,6,575,37,6,856,857,575,574,856,575,857,858,574,520,857,574,858,859,520,521,858,520,859,620,1171,1170,618,1171,620,634,550,633,551,550,634,726,550,533,511,550,726,511,633,550,632,633,511,654,513,512,514,513,654,662,648,663,649,648,662,664,648,611,663,648,664,657,665,658,666,665,657,671,23,22,542,23,671,672,546,544,673,546,672,674,546,673,554,546,674,675,554,674,555,554,675,676,555,675,552,555,676,677,552,676,636,552,677,825,636,677,824,636,825,1217,681,570,680,681,1217,712,570,681,711,570,712,707,724,723,708,724,707,698,708,707,699,708,698,698,26,699,27,26,698,699,25,700,26,25,699,699,709,708,700,709,699,708,725,724,709,725,708,570,710,682,711,710,570,688,555,687,554,555,688,689,554,688,546,554,689,544,689,690,546,689,544,542,24,23,691,24,542,724,710,711,725,710,724,723,711,712,724,711,723,721,715,720,714,715,721,507,562,561,508,562,507,652,529,591,516,529,652,1131,614,581,1130,614,1131,1129,614,1130,613,614,1129,1129,505,503,1130,505,1129,656,1126,1125,610,1126,656,619,1125,1124,656,1125,619,1118,498,497,1119,498,1118,815,1119,1118,816,1119,815,1117,497,490,1118,497,1117,814,1118,1117,815,1118,814,1114,492,495,1115,492,1114,811,1115,1114,812,1115,811,1113,495,494,1114,495,1113,810,1114,1113,811,1114,810,1112,494,493,1113,494,1112,733,589,592,729,589,733,590,592,589,586,592,590,10,605,9,737,605,10,609,593,584,582,593,609,499,582,609,583,582,499,726,512,511,654,512,726,731,533,534,726,533,731,547,519,538,540,519,547,729,591,589,652,591,729,540,532,519,539,532,540,542,672,544,671,672,542,691,544,690,542,544,691,1217,740,741,683,740,1217,679,1217,741,680,1217,679,836,638,678,835,638,836,638,834,684,835,834,638,685,824,823,636,824,685,686,636,685,552,636,686,687,552,686,555,552,687,541,22,21,671,22,541,541,1,539,21,1,541,543,671,541,672,671,543,543,539,540,541,539,543,545,672,543,673,672,545,545,540,547,543,540,545,557,673,545,674,673,557,534,547,538,548,547,534,547,557,545,548,557,547,556,674,557,675,674,556,549,557,548,556,557,549,553,675,556,676,675,553,551,556,549,553,556,551,634,553,551,635,553,634,635,676,553,677,676,635,826,677,635,825,677,826,827,635,634,826,635,827,837,678,639,836,678,837,1209,621,838,637,621,1209,1209,639,637,837,639,1209,569,679,566,680,679,569,837,1207,566,1209,1207,837,571,680,569,681,680,571,713,681,571,712,681,713,714,571,572,713,571,714,722,712,713,723,712,722,721,713,714,722,713,721,704,721,720,705,721,704,706,723,722,707,723,706,705,722,721,706,722,705,697,707,706,698,707,697,697,705,696,706,705,697,28,698,697,27,698,28,29,697,696,28,697,29,537,538,519,535,538,537,728,519,532,537,519,728,2,532,0,728,532,2,731,538,535,534,538,731,731,654,726,744,654,731,744,514,654,745,514,744,746,514,745,596,514,746,755,596,746,599,596,755,866,745,744,865,745,866,868,731,535,867,731,868,731,866,744,867,866,731,743,653,747,732,653,743,587,739,593,716,739,587,738,750,751,588,750,738,752,716,587,749,716,752,586,751,592,736,751,586,749,588,716,748,588,749,746,865,864,745,865,746,588,739,716,738,739,588,585,593,739,584,593,585,734,751,736,738,751,734,738,585,739,734,585,738,796,737,735,794,737,796,12,735,11,606,735,12,735,10,11,737,10,735,515,655,732,517,655,515,517,652,655,516,652,517,536,732,743,515,732,536,742,535,537,868,535,742,755,864,863,746,864,755,753,587,594,752,587,753,754,594,595,753,594,754,813,1117,1116,814,1117,813,1163,490,1164,491,490,1163,863,756,755,862,756,863,862,757,756,861,757,862,813,1115,812,1116,1115,813,1162,491,1163,492,491,1162,758,537,728,742,537,758,758,2,3,728,2,758,733,751,750,592,751,733,727,588,748,750,588,727,651,652,729,655,652,651,653,655,651,732,655,653,760,653,651,727,653,760,651,733,760,729,733,651,748,653,727,747,653,748,733,727,760,750,727,733,500,1175,1174,504,1175,500,500,1173,501,1174,1173,500,1128,613,1129,761,613,1128,761,647,613,646,647,761,1127,504,500,1128,504,1127,1127,501,1126,500,501,1127,612,1126,610,1127,1126,612,763,610,656,762,610,763,608,666,657,667,666,608,763,658,762,657,658,763,767,664,611,766,664,767,767,665,766,658,665,767,768,611,646,767,611,768,762,767,768,658,767,762,612,762,768,610,762,612,1128,612,761,1127,612,1128,612,646,761,768,646,612,1175,503,1176,504,503,1175,642,561,645,640,561,642,645,562,563,561,562,645,34,777,35,692,777,34,703,693,694,702,693,703,31,693,32,694,693,31,33,693,779,32,693,33,33,692,34,779,692,33,702,779,693,778,779,702,719,715,769,720,715,719,565,769,715,643,769,565,770,643,644,769,643,770,771,644,642,770,644,771,773,563,774,645,563,773,771,645,773,642,645,771,718,769,770,719,769,718,772,770,771,718,770,772,717,771,773,772,771,717,775,773,774,717,773,775,703,720,719,704,720,703,703,695,704,694,695,703,702,719,718,703,719,702,772,702,718,778,702,772,701,779,778,692,779,701,701,772,717,778,772,701,776,692,701,777,692,776,776,717,775,701,717,776,1123,618,620,1124,618,1123,617,1124,1123,619,1124,617,1167,498,854,1166,498,1167,817,1119,816,1120,1119,817,809,1113,1112,810,1113,809,1159,494,1160,493,494,1159,788,1170,1169,620,1170,788,1122,617,1123,790,617,1122,808,1112,1111,809,1112,808,1132,506,1131,847,506,1132,1159,787,493,1158,787,1159,795,607,792,606,607,795,793,737,794,605,737,793,796,606,795,735,606,796,578,793,803,605,793,578,577,520,574,805,520,577,576,574,575,577,574,576,576,803,577,578,803,576,8,605,578,9,605,8,7,575,6,576,575,7,7,578,576,8,578,7,602,809,604,810,809,602,603,810,602,811,810,603,757,811,603,812,811,757,813,757,861,812,757,813,815,754,595,814,754,815,608,668,667,782,668,608,14,607,13,818,607,14,818,36,855,14,36,818,798,607,818,792,607,798,764,656,619,763,656,764,780,790,791,617,790,780,855,798,818,797,798,855,764,657,763,608,657,764,850,617,780,781,617,850,18,852,851,19,852,18,15,780,791,16,780,15,782,764,781,608,764,782,17,780,16,850,780,17,17,851,850,18,851,17,819,1111,1110,808,1111,819,820,819,784,808,819,820,809,820,604,808,820,809,823,638,684,824,638,823,678,824,825,638,824,678,639,825,826,678,825,639,637,826,827,639,826,637,637,828,621,827,828,637,828,622,621,829,622,828,829,623,622,830,623,829,830,624,623,831,624,830,831,625,624,832,625,831,741,834,835,740,834,741,679,835,836,741,835,679,566,836,837,679,836,566,559,838,839,567,838,559,560,839,840,559,839,560,558,840,841,560,840,558,507,841,842,558,841,507,508,842,843,507,842,508,849,581,615,848,581,849,1132,581,848,1131,581,1132,846,1158,1157,787,1158,846,781,619,617,764,619,781,851,668,782,852,668,851,850,782,781,851,782,850,791,797,855,790,797,791,791,36,15,855,36,791,814,861,754,813,861,814,753,861,862,754,861,753,752,862,863,753,862,752,863,749,752,864,749,863,864,748,749,865,748,864,747,865,866,748,865,747,743,866,867,747,866,743,536,867,868,743,867,536,869,868,742,536,868,869,869,515,536,870,515,869,583,817,816,499,817,583,816,595,583,815,595,816,600,755,756,599,755,600,756,603,600,757,603,756,598,596,599,597,596,598,628,597,598,629,597,628,832,628,833,629,628,832,626,842,625,843,842,626,626,832,833,625,832,626,601,603,602,600,603,601,875,599,600,598,599,875,785,602,604,601,602,785,877,628,876,833,628,877,876,598,875,628,598,876,880,875,879,876,875,880,875,601,879,600,601,875,879,785,883,601,785,879,786,848,849,845,848,786,1109,848,845,1132,848,1109,786,819,845,784,819,786,1109,819,1110,845,819,1109,1109,847,1132,496,847,1109,1180,846,1157,496,846,1180,1180,847,496,1179,847,1180,789,1169,1168,788,1169,789,1167,789,1168,854,789,1167,1121,854,1120,789,854,1121,860,1122,1121,790,1122,860,860,1120,817,1121,1120,860,797,860,801,790,860,797,499,802,801,609,802,499,801,817,499,860,817,801,799,609,584,802,609,799,798,801,802,797,801,798,584,800,799,585,800,584,799,798,802,792,798,799,795,799,800,792,799,795,585,874,800,734,874,585,873,734,736,874,734,873,874,795,800,796,795,874,872,736,586,873,736,872,873,796,874,794,796,873,804,586,590,872,586,804,793,873,872,794,873,793,590,591,531,589,591,590,531,804,590,805,804,531,803,872,804,793,872,803,804,577,803,805,577,804,669,650,649,615,650,669,627,786,806,784,786,627,820,627,821,784,627,820,785,820,821,604,820,785,627,1046,1045,806,1046,627,883,821,884,785,821,883,821,1045,1044,627,1045,821,884,1044,1043,821,1044,884,849,669,670,615,669,849,670,889,890,669,889,670,806,849,670,786,849,806,670,1046,806,890,1046,670,889,649,662,669,649,889,885,1043,1042,884,1043,885,878,833,877,626,833,878,844,626,878,843,626,844,894,844,878,893,844,894,877,880,881,876,880,877,894,877,881,878,877,894,882,884,885,883,884,882,880,883,882,879,883,880,895,894,896,893,894,895,898,885,891,882,885,898,891,1042,886,885,1042,891,899,895,896,897,895,899,898,894,881,896,894,898,891,896,898,899,896,891,898,880,882,881,880,898,891,897,899,886,897,891,528,516,518,529,516,528,531,529,530,591,529,531,530,805,531,520,805,530,871,520,530,521,520,871,871,529,528,530,529,871,759,3,4,758,3,759,573,37,856,5,37,573,38,573,900,5,573,38,759,38,900,4,38,759,524,856,857,573,856,524,525,758,759,742,758,525,901,759,900,525,759,901,901,573,524,900,573,901,522,857,858,524,857,522,526,742,525,869,742,526,902,525,901,526,525,902,902,524,522,901,524,902,523,858,859,522,858,523,527,869,526,870,869,527,903,526,902,527,526,903,903,522,523,902,522,903,890,1031,1030,889,1031,890,943,489,888,942,489,943,963,616,964,661,616,963,1033,1015,1014,1034,1015,1033,1034,663,664,1033,663,1034,961,765,962,660,765,961,766,1036,1035,665,1036,766,962,661,963,765,661,962,1035,1015,1034,1016,1015,1035,1035,664,766,1034,664,1035,1039,667,668,1038,667,1039,783,959,958,580,959,783,509,843,844,508,843,509,668,1040,1039,852,1040,668,957,783,958,853,783,957,852,1041,1040,19,1041,852,957,20,853,956,20,957,897,1024,887,886,1024,897,887,1058,1057,1024,1058,887,887,895,897,510,895,887,1029,1011,1010,1030,1011,1029,1028,1010,1009,1029,1010,1028,1028,1008,1027,1009,1008,1028,971,1052,1051,970,1052,971,973,1050,982,972,1050,973,941,489,942,579,489,941,889,1032,1031,662,1032,889,941,616,579,964,616,941,1033,1013,1032,1014,1013,1033,662,1033,1032,663,1033,662,959,659,960,580,659,959,666,1038,1037,667,1038,666,659,961,960,660,961,659,1037,1017,1036,1018,1017,1037,1037,665,666,1036,665,1037,969,1052,970,1053,1052,969,1025,1058,1024,1059,1058,1025,983,973,982,974,973,983,994,982,993,983,982,994,510,1055,892,1056,1055,510,892,895,510,893,895,892,1055,509,892,1054,509,1055,892,844,893,509,844,892,822,1006,1005,906,1006,822,1007,906,907,1006,906,1007,990,907,908,1007,907,990,991,908,909,990,908,991,992,909,910,991,909,992,992,911,944,910,911,992,911,993,944,912,993,911,912,994,993,913,994,912,1000,807,730,999,807,1000,989,924,932,923,924,989,935,926,927,934,926,935,972,1051,1050,971,1051,972,510,1057,1056,887,1057,510,60,933,477,932,933,60,61,933,934,477,933,61,934,461,61,935,461,934,935,391,461,936,391,935,391,937,468,936,937,391,465,937,938,468,937,465,464,938,939,465,938,464,471,939,940,464,939,471,1013,942,1012,941,942,1013,214,945,946,466,945,214,946,215,214,947,215,946,216,947,948,215,947,216,948,217,216,949,217,948,949,331,217,950,331,949,950,218,331,951,218,950,218,952,219,951,952,218,952,220,219,953,220,952,220,954,351,953,954,220,954,424,351,955,424,954,424,956,1022,955,956,424,1021,958,1020,957,958,1021,1018,959,960,1019,959,1018,1018,961,1017,960,961,1018,1016,961,962,1017,961,1016,1016,963,1015,962,963,1016,1014,963,964,1015,963,1014,1013,964,941,1014,964,1013,1010,943,965,1011,943,1010,965,888,966,943,888,965,999,966,807,965,966,999,939,967,940,931,967,939,1023,967,968,940,967,1023,969,508,509,562,508,969,563,969,970,562,969,563,774,970,971,563,970,774,775,971,972,774,971,775,776,972,973,775,972,776,777,973,974,776,973,777,35,974,975,777,974,35,344,975,976,35,975,344,343,976,977,344,976,343,342,977,978,343,977,342,341,978,979,342,978,341,114,979,980,341,979,114,113,980,981,114,980,113,59,981,60,113,981,59,977,984,985,976,984,977,978,985,986,977,985,978,979,986,987,978,986,979,979,988,980,987,988,979,980,989,981,988,989,980,60,989,932,981,989,60,985,995,996,984,995,985,986,996,997,985,996,986,987,997,998,986,997,987,988,998,922,987,998,988,1009,965,999,1010,965,1009,1008,999,1000,1009,999,1008,509,1053,969,1054,1053,509,942,1011,1012,943,1011,942,958,1019,1020,959,1019,958,956,1021,1022,957,1021,956,472,940,1023,471,940,472,472,466,473,1023,466,472,1059,1026,1060,1025,1026,1059,1060,1027,1008,1026,1027,1060,1012,1030,1031,1011,1030,1012,1013,1031,1032,1012,1031,1013,1017,1035,1036,1016,1035,1017,1018,1038,1019,1037,1038,1018,1020,1038,1039,1019,1038,1020,1021,1039,1040,1020,1039,1021,1022,1040,1041,1021,1040,1022,1024,1042,1025,886,1042,1024,1025,1043,1026,1042,1043,1025,1026,1044,1027,1043,1044,1026,1027,1045,1028,1044,1045,1027,1029,1045,1046,1028,1045,1029,1030,1046,890,1029,1046,1030,1048,913,1047,994,913,1048,995,1047,914,1048,1047,995,1049,994,1048,983,994,1049,984,1048,995,1049,1048,984,975,983,1049,974,983,975,976,1049,984,975,1049,976,993,1050,944,982,1050,993,944,1051,992,1050,1051,944,991,1051,1052,992,1051,991,990,1052,1053,991,1052,990,1053,1007,990,1054,1007,1053,1006,1054,1055,1007,1054,1006,1006,1056,1005,1055,1056,1006,1004,1056,1057,1005,1056,1004,1003,1057,1058,1004,1057,1003,1002,1058,1059,1003,1058,1002,1002,1060,1001,1059,1060,1002,1001,1008,1000,1060,1008,1001,1164,1062,1163,1061,1062,1164,1163,1063,1162,1062,1063,1163,1162,1064,1161,1063,1064,1162,1161,1065,1160,1064,1065,1161,1160,1066,1159,1065,1066,1160,1159,1067,1158,1066,1067,1159,1157,1067,1068,1158,1067,1157,1180,1068,1069,1157,1068,1180,1180,1070,1179,1069,1070,1180,1179,1071,1178,1070,1071,1179,1178,1072,1177,1071,1072,1178,1176,1072,1073,1177,1072,1176,1176,1074,1175,1073,1074,1176,1174,1074,1075,1175,1074,1174,1174,1076,1173,1075,1076,1174,1173,1077,1172,1076,1077,1173,1171,1077,1078,1172,1077,1171,1170,1078,1079,1171,1078,1170,1169,1079,1080,1170,1079,1169,1168,1080,1081,1169,1080,1168,1168,1082,1167,1081,1082,1168,1167,1083,1166,1082,1083,1167,1166,1084,1165,1083,1084,1166,1165,1061,1164,1084,1061,1165,496,1110,846,1109,1110,496,846,1111,787,1110,1111,846,787,1112,493,1111,1112,787,492,1116,491,1115,1116,492,491,1117,490,1116,1117,491,854,1119,1120,498,1119,854,789,1122,788,1121,1122,789,788,1123,620,1122,1123,788,504,1129,503,1128,1129,504,132,1134,418,1133,1134,132,418,1135,415,1134,1135,418,415,1136,388,1135,1136,415,359,1149,168,1148,1149,359,163,1154,326,1153,1154,163,326,1155,164,1154,1155,326,164,1156,165,1155,1156,164,165,1133,132,1156,1133,165,1098,1183,1184,1099,1183,1098,1098,1185,1097,1184,1185,1098,1096,1187,1095,1186,1187,1096,1094,1187,1188,1095,1187,1094,1093,1190,1092,1189,1190,1093,1092,1191,1091,1190,1191,1092,1091,1192,1090,1191,1192,1091,1090,1193,1089,1192,1193,1090,1088,1193,1194,1089,1193,1088,1087,1194,1195,1088,1194,1087,870,517,515,1206,517,870,517,518,516,1206,518,517,79,74,488,443,74,79,859,871,523,521,871,859,72,74,443,431,74,72,442,69,78,1205,69,442,78,79,488,69,79,78,527,528,518,903,528,527,523,528,903,871,528,523,1206,527,518,870,527,1206,569,1207,1208,566,1207,569,1208,567,568,1207,567,1208,572,569,1208,571,569,572,572,568,565,1208,568,572,190,1210,188,407,1210,190,172,1210,408,188,1210,172,1211,120,1212,117,120,1211,118,1212,119,1211,1212,118,730,1001,1000,1213,1001,730,1213,1002,1001,1214,1002,1213,1003,1214,1215,1002,1214,1003,1215,1004,1003,1216,1004,1215,1216,1005,1004,822,1005,1216,682,1217,570,683,1217,682,245,120,117,1219,120,245,1219,122,120,246,122,1219,1074,1064,1063,1075,1063,1062,1073,1065,1064,1071,1066,1065,1073,1072,1065,1070,1067,1066,1068,1067,1070,1061,1077,1076,1084,1078,1077,1079,1078,1084,1080,1079,1083,1082,1081,1080,1075,1074,1063,1076,1075,1062,1074,1073,1064,1072,1071,1065,1071,1070,1066,1069,1068,1070,1062,1061,1076,1061,1084,1077,1083,1079,1084,1082,1080,1083,1093,1086,1085,1094,1085,1108,1092,1087,1086,1090,1088,1087,1091,1090,1087,1090,1089,1088,1107,1096,1095,1106,1097,1096,1098,1097,1106,1099,1098,1105,1100,1099,1104,1102,1101,1100,1094,1093,1085,1095,1094,1108,1093,1092,1086,1092,1091,1087,1108,1107,1095,1107,1106,1096,1105,1098,1106,1104,1099,1105,1103,1100,1104,1103,1102,1100,709,691,690,725,690,689,24,691,700,709,700,691,256,24,25,256,265,274,255,274,290,254,290,275,253,247,248,275,247,253,252,248,305,305,404,251,250,251,404,249,393,250,688,682,710,683,682,688,687,740,683,686,834,740,685,684,834,685,823,684,725,709,690,710,725,689,25,24,700,265,256,25,255,256,274,254,255,290,253,254,275,252,253,248,251,252,305,249,250,404,689,688,710,687,683,688,687,686,740,686,685,834		
	};


}