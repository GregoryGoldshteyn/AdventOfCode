using System;
using System.Runtime.ExceptionServices;
using System.Xml.Serialization;

namespace Day5
{
    public readonly struct Mapping
    {
        public long Source { get; init; }
        public long Destination { get; init; }
        public long Range { get; init; }

        public Mapping(string mappingEntry)
        {
            string[] mappingInfo = mappingEntry.Trim().Split(" ");
            Destination = long.Parse(mappingInfo[0]);
            Source = long.Parse(mappingInfo[1]);
            Range = long.Parse(mappingInfo[2]);
        }

        public override string ToString()
        {
            return string.Format("source: {0}, destination {1}, range {2}", Source, Destination, Range);
        }
    }

    public readonly struct Map
    {
        public List<Mapping> mappings { get; init; }
        public Map(string mapEntry)
        {
            mappings = new List<Mapping>();
            string[] mappingsString = mapEntry.Trim().Split("\r\n");
            foreach (string mapping in mappingsString)
            {
                mappings.Add(new Mapping(mapping));
            }
        }

        public override string ToString()
        {
            string retString = string.Empty;

            foreach (Mapping mapping in mappings)
            {
                retString += mapping.ToString();
                retString += "\r\n";
            }

            return retString;
        }
    }

    public readonly struct LongRange
    {
        // The start of a range is inclusive
        public long Start { get; init; }
        // The end of a range is exclusive (a range does not contain its end)
        public long End { get; init; }
        public LongRange(string rangeStart, string rangeLength)
        {
            Start = long.Parse(rangeStart);
            End = Start + long.Parse(rangeLength);
        }
        public LongRange(long rangeStart, long rangeEnd)
        {
            Start = rangeStart;
            End = rangeEnd;
        }

        public override string ToString()
        {
            return string.Format("start: {0}, end: {1}, length: {2}", Start, End, End - Start);
        }
    }

    public class LongRangeComparer() {}

    public static class Program
    {
        private const string seedString = "919339981 562444630 3366006921 67827214 1496677366 101156779 4140591657 5858311 2566406753 71724353 2721360939 35899538 383860877 424668759 3649554897 442182562 2846055542 49953829 2988140126 256306471";
        private const string mapString = "seed-to-soil map:\r\n627617777 1691901751 235673208\r\n2425244517 2483951770 157286279\r\n1339042890 1549225044 142676707\r\n481294110 381503165 89539853\r\n863290985 1007717708 39103521\r\n570833963 324719351 56783814\r\n3953140805 3714151881 155523737\r\n902394506 1941176275 61481385\r\n963875891 675869083 331848625\r\n1922840702 1046821229 502403815\r\n1481719597 1927574959 13601316\r\n1820040264 573068645 102800438\r\n1295724516 2641238049 43318374\r\n0 2002657660 481294110\r\n1495320913 0 324719351\r\n2582530796 471043018 102025627\r\n3714151881 3869675618 238988924\r\n\r\nsoil-to-fertilizer map:\r\n1288462652 3191328122 309853381\r\n3216116191 1774097401 151922673\r\n1739360920 2276789875 44162492\r\n220941763 1080382821 325206789\r\n2416141229 3949354107 345613189\r\n1783523412 765967805 117439234\r\n2876214366 1010215130 70167691\r\n2761754418 3142514478 48813644\r\n3840090062 3541735844 44042641\r\n2946382057 1417076798 106871618\r\n3750331405 3501181503 29948437\r\n1105413398 1405589610 11487188\r\n2867709608 3585778485 8504758\r\n3053253675 3594283243 162862516\r\n15940804 0 90040993\r\n2192246779 537548320 223894450\r\n210335859 3531129940 10605904\r\n546148552 2351877346 559264846\r\n1598316033 883407039 110119908\r\n2851021425 993526947 16688183\r\n0 90040993 15940804\r\n4134281688 3757145759 160685608\r\n3718808665 3917831367 31522740\r\n1116900586 2970952412 171562066\r\n2810568062 210335859 40453363\r\n3780279842 2911142192 59810220\r\n1900962646 761442770 4525035\r\n1905487681 250789222 286759098\r\n3368038864 1926020074 350769801\r\n1708435941 2320952367 30924979\r\n3884132703 1523948416 250148985\r\n\r\nfertilizer-to-water map:\r\n2450598719 3993777626 178688420\r\n990387307 2284751995 36035279\r\n1479519873 1430606124 25388869\r\n2928263979 2233553333 51198662\r\n1825810145 1093816339 30855096\r\n3131362216 1499369679 38622365\r\n2629287139 1980229176 243592551\r\n2979462641 1827354243 146328983\r\n937194740 3188384434 9817881\r\n2069360741 1973683226 975358\r\n1856665241 3781082126 212695500\r\n642830371 945238436 148577903\r\n4114154511 1124671435 95554104\r\n3777484412 483834992 305990165\r\n3264059981 2427531551 296117669\r\n272170557 2723649220 370659814\r\n262438951 2223821727 9731606\r\n1615429560 1220225539 210380585\r\n1028349507 226445100 83554339\r\n4209708615 3198202315 85258681\r\n3169984581 3094309034 94075400\r\n4083474577 309999439 30679934\r\n2872879690 115495593 55384289\r\n2138362191 340679373 4164957\r\n947012621 1455994993 43374686\r\n791408274 1606018136 145786466\r\n1026422586 1825427322 1926921\r\n1578531462 789825157 8469921\r\n3670740135 2320787274 106744277\r\n2272532251 170879882 55565218\r\n3125791624 1974658584 5570592\r\n1111903846 3283460996 367616027\r\n2070336099 1537992044 68026092\r\n1504908742 1751804602 73622720\r\n2142527148 3651077023 130005103\r\n2328097469 4172466046 122501250\r\n1587001383 344844330 28428177\r\n3560177650 373272507 110562485\r\n115495593 798295078 146943358\r\n\r\nwater-to-light map:\r\n220561404 643114856 123713527\r\n1087373312 4123526389 171440907\r\n0 766828383 220561404\r\n2907464644 3955968868 167557521\r\n376259478 31984547 611130309\r\n344274931 0 31984547\r\n4209967986 1266450159 84999310\r\n3234177104 1246528251 19921908\r\n4075482989 2729348487 134484997\r\n1258814219 1870560966 858787521\r\n3075022165 1087373312 159154939\r\n2439602258 3906331676 49637192\r\n2297013316 3685217461 142588942\r\n2567764723 1530861045 339699921\r\n3254099012 2863833484 821383977\r\n2489239450 3827806403 78525273\r\n2117601740 1351449469 179411576\r\n\r\nlight-to-temperature map:\r\n83647742 560398800 311449275\r\n4201716419 3337900402 93250877\r\n1071565427 3024001249 4392221\r\n3424420254 3520028211 161472091\r\n1227070419 2828368402 116428819\r\n0 2744720660 83647742\r\n4199359339 3431151279 2357080\r\n1807547949 2359072262 384093366\r\n3336003529 3486377667 33650544\r\n1075957648 871848075 149557739\r\n3585892345 3681500302 613466994\r\n955495817 2243002652 116069610\r\n2191641315 1406250497 836752155\r\n3369654073 3433508359 52869308\r\n1343499238 2944797221 79204028\r\n3422523381 3336003529 1896873\r\n395097017 0 560398800\r\n1225515387 2743165628 1555032\r\n1422703266 1021405814 384844683\r\n\r\ntemperature-to-humidity map:\r\n3340701300 3627322367 174281926\r\n3514983226 4012096602 282870694\r\n403969772 2344934648 125307793\r\n356249525 1299750763 47720247\r\n529277565 0 19150241\r\n2425473363 606907612 15105367\r\n1622667408 1693081570 188915118\r\n1858084350 1347471010 47053630\r\n4223873328 2752952198 71093968\r\n2749048741 3035669808 188955792\r\n0 2134178305 190659232\r\n1112200615 96440819 510466793\r\n4148180263 2749048741 3903457\r\n1811582526 1113827741 11131074\r\n548427806 2324837537 20097111\r\n1905137980 2051821050 82357255\r\n3116507691 3224625600 224193609\r\n1822713600 1657710820 35370750\r\n568524917 622012979 491814762\r\n2440578730 66777108 29663711\r\n2250681415 1124958815 174791948\r\n4009477562 3873393901 138702701\r\n190659232 1881996688 165590293\r\n1987495235 1394524640 263186180\r\n1107966546 2047586981 4234069\r\n1060339679 19150241 47626867\r\n4210822392 3801604293 13050936\r\n2938004533 3448819209 178503158\r\n3797853920 2824046166 211623642\r\n4152083720 3814655229 58738672\r\n\r\nhumidity-to-location map:\r\n2102802203 2756269781 87468599\r\n2877112183 2931341663 22549647\r\n3494879649 1477788233 182041959\r\n2436026725 2953891310 81993792\r\n2899661830 373999642 244663414\r\n2190270802 850802545 169763790\r\n3866824018 90439080 13573105\r\n320139638 1659830192 113214403\r\n1131501111 1773044595 246249128\r\n2417984929 828638896 16505804\r\n3839766923 845144700 5657845\r\n4161134012 2843738380 87603283\r\n3731370785 3801964390 108396138\r\n1003659815 3442085055 127841296\r\n918426975 3986208955 85232840\r\n433354041 618663056 209975840\r\n2811371438 0 65740745\r\n2518020517 1329719948 148068285\r\n651651860 3035885102 266775115\r\n0 2256642811 320139638\r\n2666088802 228717006 145282636\r\n4136435677 65740745 24698335\r\n3144325244 1046598285 188874270\r\n1657153777 2576782449 179487332\r\n1844732214 3569926351 232038039\r\n643329881 2077244060 8321979\r\n1471997632 4071441795 175759508\r\n2076770253 1020566335 26031950\r\n3676921608 3931759778 54449177\r\n3997010839 3302660217 139424838\r\n3845424768 3910360528 21399250\r\n1836641109 104012185 8091105\r\n3333199514 2085566039 161680135\r\n3880397123 112103290 116613716\r\n2360034592 2019293723 57950337\r\n1377750239 1235472555 94247393\r\n1647757140 2247246174 9396637\r\n2434490733 4247201303 1535992";
        
        private static List<long> candidateSeeds = new List<long>();
        private static List<Map> maps = new List<Map>();

        private static List<LongRange> seedRanges = new List<LongRange>();

        static void populateMaps(List<Map> maps, string mapString)
        {
            string[] mapStrings = mapString.Split("\r\n\r\n");
            foreach (string map in mapStrings)
            {
                string[] mapNameAndMappings = map.Split(" map:\r\n");
                maps.Add(new Map(mapNameAndMappings[1]));
            }
        }

        static void populateSeedsForPart1(List<long> seeds, string seedString)
        {
            string[] seedArr = seedString.Split(" ");
            foreach (string seed in seedArr)
            {
                seeds.Add(long.Parse(seed));
            }
        }
        static void populateSeedsForPart2(List<LongRange> seedRanges, string seedString)
        {
            string[] seedArr = seedString.Split(" ");
            for(int i = 0; i < seedArr.Length; i+=2) 
            {
                seedRanges.Add(new LongRange(seedArr[i], seedArr[i+1]));
            }
        }

        static List<long> getDestinationsFromSources(Map map, List<long> sources)
        {
            List<long> destinations = new List<long>();
            
            if(sources == null)
            {
                return destinations;
            }
            if(sources.Count == 0)
            {
                return destinations;
            }

            foreach(long source in sources) 
            {
                int mappingsFound = 0;

                foreach(Mapping mapping in map.mappings)
                {
                    if(source < mapping.Source)
                    {
                        continue;
                    }
                    
                    if(source >= mapping.Source + mapping.Range)
                    {
                        continue;
                    }
                    
                    destinations.Add(source - mapping.Source + mapping.Destination);
                    mappingsFound += 1;
                }

                if (mappingsFound < 1)
                {
                    destinations.Add(source);
                }
            }

            return destinations;
        }

        private static void part1()
        {
            long minValue;

            populateSeedsForPart1(candidateSeeds, seedString);
            populateMaps(maps, mapString);

            foreach(Map map in maps)
            {
                candidateSeeds = getDestinationsFromSources(map, candidateSeeds);
            }

            minValue = candidateSeeds[0];

            foreach(long location in candidateSeeds)
            {
                Console.WriteLine(location);
                if (location < minValue) 
                {
                    minValue = location;
                }
            }

            Console.WriteLine(minValue);
        }

        private static void part2()
        {
            populateSeedsForPart2(seedRanges, seedString);
            populateMaps(maps, mapString);
        }

        static void Main()
        {
            //part1();
            part2();
        }
    }
    
}