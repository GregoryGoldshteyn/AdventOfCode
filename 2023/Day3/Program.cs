﻿using System.Drawing;

string puzzleInput = ".......855.442......190..................................969..........520.......59.............................................172..........\r\n.......................-....@...21...........971........................*..............965.......577=..........316..465*169.................\r\n........881.......881....635......*..........*.............%.577.....864.......873.........................742...*...............714..244...\r\n.......*..../..................602......351...423....939.906...*.........899..-..........833..60..%....965...*....309......43......*.*......\r\n....737......294..........321*.......................$.......337....511.*.........58..............305.*.......153.............130.....638...\r\n..............................821.544*282.........#......391............165...............836..........112.......................*..........\r\n..............$.....456.....................281....847...................................*....+.....................-448.@728....833........\r\n.......830...34.......%.......911..........$............553........702......21....279.........226....................................*......\r\n..........*......................+.....745......./...........&......../.....*......*...................192...247...40................504....\r\n...........304..938.........258..................679...702..742..$.........656..645..916.......*........*...+........-...263&...............\r\n...841*168.....*.......169../...........@.................%.......633.-758..........*.......993......410.........920.............*195...492.\r\n..............988.186....................689............&.........................554...........@...................*245......794.......@...\r\n....+489..............@.....866..........................354...........567.............949.969...913.....&10....&...........................\r\n350...........691...72..787*..........189.....639.............+...........*771............*....................736.........#..........639...\r\n.................................561.*........&.....449......693.192...........344.....-...........847.....................496.192.39*......\r\n...912....792...................=.....925.............*..........-....175.232.....*.....887.156.........378.........183.................782.\r\n.........*....217....955.644*...............609.....728.................*....*.....966.......*............*........*........427.494#........\r\n.....+...49......-.....*.....389........*......*812...................811...327............600..........233........320.&10...&..............\r\n...155...............259..........629.646..............*194...111...............%...................998.....292................872..........\r\n.......444.......648.....730.154....*.....657..$....816........*.....%.......618..123.....-...........*.......@........772.@....+.......*200\r\n..........*.........*.....&....*............*..208......168#..305....510...........*.....907.........901.........582.....$.238........50....\r\n........544.......935.........344..........106............................271.......849......-............890...............................\r\n.....................................791.......=.................447*55.....*.............504.............*...........504............439....\r\n..675...........................#547.$...211.197.......814....22.............115.....................-...39..................307.499*.......\r\n....*..........169.....%......%..........*..............*.....*...229................................887.....974....+875....*...............\r\n..933......696.........909.682............624..594*.....622.367....*........-.....-218..........358*............&........319....748.978.....\r\n......546.....*.....................817............636...........562.........716..........730.......195.....897.....-.......................\r\n..18...*......206...890............/............*.......3...-..........286.....................................$...817......................\r\n.....404............*...334..........706...924..153.800..+.683......1.......685........*160.................................29..........579.\r\n..................312.........498.......*....*.......@.............*....495....*....435............498..........83............*618..-.......\r\n......./................*255............756..132.595...../......373..#.....#.286....................*......901..............*......526......\r\n.......283...351.....472..........990*..............*..42............815.........85..............996..........*......*418...486.............\r\n426...........................=.......254..........305..........859..........#..-.......491.-.............204.355.780.............../.......\r\n....976.........$.........582.500.............67...........937...$.........267......551.@...915..$........*.........................653.....\r\n........801.....441...740*......................*....145..$.........................*............442...990..........494.................183.\r\n..1........&...............$.................96..950...*......................429..592./....................922....@........................\r\n.......427...%.....%..680...798..63............*......163....580..........283*..........700...882............*..............=....423*.......\r\n...........524..474......*........*....843.456...670...........*..96*986..........839.......=...&....952.330.726....@.......484........916..\r\n......500................632....27..*......=.......*..=.............................#..739.953.........&.*..........929.978...........*.....\r\n..........157........................821........384..95............*531...489..478....&...................950......................295......\r\n......@.........=.........................................31....346...............*...................779........247.......761..............\r\n854.6..10.....174...........726%.965..........-852.......*...........642.=260...+.462....457...........*............-.......*.........-.....\r\n...*...................32$..........................272*........89.....*......310.........#.......894...83...251.............408.721.303....\r\n.............................................771........406......*......................*........$..........*.....227$.............*........\r\n........*.260..758.......*360.....213.......#......425#........49....968........944*131.645..410......*240...354........611.....528.........\r\n.....716.....*........412...........+...................470.............$.......................*..155......................256.............\r\n..........867.........................348..........69......*852..................419...........798........605.........*787.=.......3*994....\r\n.....443......565.......*....793..744.*..............*270................529......+.................432...........323........+...*..........\r\n.................*...159.467.....#....612.....=.214............-....805./....911................49.....*.............+.878*..704.382.%900...\r\n.490...542........46........................878...*..........512......*........#....336...445........898........212*........................\r\n....+.-......868...................................19................508.....$......@........*..............192.....143....636..............\r\n...............*.............592............176.......608-........*......%..290.-........#....620.....+........*..........*..............814\r\n............*...586.......60....*.......-.....@.545.@............99....536......815....820........./...598...373.....501....331.........$...\r\n....985..776..........4...*......704.217.........+...531....709............308...................339............................746.........\r\n....*...........359..+..869....................................*...........*..........262.................139...........164...........981...\r\n.....951...........&..........408...315.564.................222..........781.................249.....995...+..........$.*....205.404.*......\r\n..............351@............*............*.......*../............289.......711......946...*....................102.34.7.......*....65.....\r\n.................../102....550............137...254....772..599+....*...+..%................734.@.......+...................................\r\n....715......591.................................................926...767..719..322............229..721...................../.......*563...\r\n.......*889...$..@..........*.......188......401.......566......................%................................*873.....801.....%.........\r\n.................690.....948...908.@....&....*.../622.....%..............%..........655...676...404.374.....=.747.............622..144......\r\n...*409.......=.................*.....379..340......................817.850..780.......+.*............*...510.....886..974.......*..........\r\n844.........622....241*313...475.............................170......*........*.........371..147.............532.........*325....778...802.\r\n.......................................155.&.................@.....480...566..731..440.........*...........%...=..-373......................\r\n........931..................787....26*....178........372................@........=.........890............540............./........580.500.\r\n.../.....-......988.......94.*.................494....*....*900..339..........652................177.4................%..762................\r\n..112.............*.606.......423................#.831..227............696..............814......*..................215.............428.....\r\n......247*.....172..=...................955...................%...132......493............*.....43....276.........&.........&...............\r\n..........10.............508..383..409...&..............285..860.%..........%.........916..406..............685....760....473.834...........\r\n..620.395......................-....*......*.......+...%................................*.......496............................*............\r\n....$.%...760.......$......390.....361..991.285.522....................................437....&........332#.60................302.533.......\r\n..........*.........828........648................................@....864..........*.......632....190............................*.........\r\n220.209.626...802.................................198..961.......901....../.135..294..................*...843.......178............980.$....\r\n....#...........*.....................493...42.....#.........&.............................582......993..*..........*...908.............916.\r\n..............207..............983......./.*.........269-.223..187.....104...206...827..73.*............542.901.583..78....*................\r\n.......................97.627...../.........856................*...716......$........#.%....357.............*.............238.........70....\r\n.........................*..../................................168...=.....................................186.....747-................*....\r\n....374....747-......*.....525.....92...449.....&..................#...........376...88.........580..447.........................342.814....\r\n191*..............156.868............*.*.....33.973...........910.176......433...*....*.........%.................*792............*.........\r\n.......+......&...........246......767.133..*.....................................629..928.............233.....945......459....778...849....\r\n.....493....268..........-...................508...619.....%420....67$.....458....................=.......%./............*..................\r\n.............................110*....623*331......./.......................#.........263....610.297.........902.......100.....-.473...231...\r\n.........................336.....482................................502................&....*....................-.........542...*...%......\r\n.924....................*.....................#....853......518......*...371.....905+.....412.................817.................97........\r\n....*671.770...891.%...374...589.....774...757.....*.................8......*............................................708..............79\r\n...............-...638..........*.....*.............431.....................104..........552.........346.........%.........*................\r\n.................................44...995.................................................*..........*..........369........177.....996......\r\n......949................-.....................351.........................557...........777..........454..538......625................120..\r\n.......*......242.....201.............953........*......$..957.163...636......-...............-.............*...777..*..............&.......\r\n......169.....$............538...249.......840...900...256....*........*.229...........110.196..............699....*..502..........861.*....\r\n..........239................................*.......................465...*......&914...=.....*.......*412......147...................392..\r\n..........*........526......=..........670....613.............625.55...................*.....572....322..............235..........515.......\r\n214....333........*......975.....358....*..&........205.......%...=......487........272.779......................107.%...........*..........\r\n............215........................556..549.............................*................492..........+......*......359.......944.......\r\n..899..........#..846...........446.............797...98..795.991..........248.+15....457..................664.115........@.................\r\n....+.+.........................*.................#...$......*.......27...................842*86.............................580.813.....481\r\n......683................288.582...159..................../...............457....................656.....464..99.....................753....\r\n937*.............752.361*............*..........759=.......635.*550................810@.200*44....*...../.....*...@........927..........*519\r\n...........*401.*...........41....568................$674...............*977.................................383.306..........*826..........\r\n........413......143.670....*............620....................%.................957..150.138.33.489..............................916......\r\n.............542......*.....322.....................808......585.....-.646.......-........*.......*..........#959....732...724*328...*..59..\r\n.......4......+.....520..%.................294..483*...............56...*........................514....13*.............*..........35.......\r\n........*712....234.....241............712*...................92.........370.....*550.......798............365...........922.....+....550...\r\n....145......&..................498.&....................434.......291.........51...........+.......*.........................902.....*.....\r\n.....@........776...*..........*.....877.....87....*.997*..........*..................285........775.845.........962.....651........509..321\r\n82...................184.....418..........54*....35.........782%..201...........=734..*......$...................*........../...866.....*...\r\n......416%........................749..................*816...........................830.204.................277......890.....&.........33.\r\n....................961............*....*......319..861..................917..................976..$..............995....*..................\r\n..920......#828.84..............338..348.64....@........614..............$.....781@............*..29.....875..229*....234.....312...........\r\n.......456......-...&......................................*.................9............280.235..........*..............280*..............\r\n......&.....277......841.....83.......554....442*769.......418.+603..15*882...%..........*...............920..759...............$.......876.\r\n......................................*..............553..........................784.759......................@...533.......770..=.........\r\n..........936...............*435....29...382.#.........*...603.......121....%..#...*....................&.........../............52......137\r\n..................340....121.............*....260.....339......11.....*...991..255.970...928.294.........17..457............................\r\n.......238.518....#..................569..163..............487..=.....578...................*.....*..........*.........86..362.......926....\r\n.......#....*........*...........467...+.........610.=......&..................@19.....892.....678......44.893..%..627*....*...359..........\r\n..........431.....450.146.................603...=....872.............745.................@...............@.....987............+.............\r\n..........................$.........848..*..................%....745................443........591...957............................816*72..\r\n.....892*.....87..191....33....@...+........424........780..611...%..........184%......*...831*......&.....948...............726............\r\n............-...*...*..........301...904*.....*..........+........................527..494.......123..............................&.........\r\n150.......183...530..872.................710...868.........436.824....727..577...*................*..............#498......&532.842.........\r\n...............................-.....174......................*....&.....=...*.762...............340.312..705...........+...................\r\n..........269....162...873*.....915.....*729.........995..321....102.*.....443........%....205........*....=......15...808......792.........\r\n.333.......*...............425..........................$.*..........286...........556.......*......572...........*............%......348...\r\n........520..766.=.....74*............692...813............81............152............%.....................@....91.......................\r\n............+....670......720..169*......#........164..193......971...........+......991...%..559.288..720*....706........402..18...........\r\n........383........................705.....763....*......*.........*.......6.270..........873....*.........109.............@....-....254*...\r\n..........*....................226.........*...841....+...252...884.......*......48.....*..........................678=..................539\r\n......911..713...192.594..570...*...........33.....786...............851.807....*....472.890......563......................=.522..../.......\r\n.894%..*............*.........25....&671.................*475....145.%.......137.............953..*...36..125..249*......774...*.549....696.\r\n.......90..273........94.........=...........667......132.......#........120.....*.......697..*..910...*....*......567.......240.......*....\r\n.....@......*..........*.........294...@.......*..........595............*.....506.......*...655.....295.777......................%..896....\r\n477.448.179..370....829..356.611......474......76...........*.........972..............726.......................642....829....287..........\r\n.........................*.....*...........................384.............-................431....291.459#............*....................\r\n.........296.......715.794..759...............590.................410.......233.............*.....#.....................477..342....729*....\r\n.....989*...........................568..571.....*.488..98.......*........................123.577.............988...........*....$......285.\r\n...............667.857*127............*....*..343..*............506...702..........295.................*......*.........600.....626.*.......\r\n.......*563......*........................349.....945.................+......@........*....964%......33.642...431.......*............968....\r\n....229..........48....=....*.....447......................%....745$..........569...787.........*.....................887...................\r\n.......................369...515..............100...........174..............................633.973........................................";

string[] lines = puzzleInput.Split("\r\n");

int accumulator = 0;

HashSet<Tuple<int, int>> symbolLocs = new HashSet<Tuple<int, int>>();
HashSet<Tuple<int, int>> candidateNumberLocs = new HashSet<Tuple<int, int>>();

Dictionary<Tuple<int, int>, HashSet<Tuple<int, int>>> gearConnections = new Dictionary<Tuple<int, int>, HashSet<Tuple<int, int>>>();
HashSet<Tuple<int, int>> gearLocs = new HashSet<Tuple<int, int>>();

const string numericalChars = "0123456789";
const string nonSymbolChars = numericalChars + ".";

HashSet<Tuple<int, int>> neighborhood = new HashSet<Tuple<int, int>> {
    new Tuple<int, int>(-1, -1),
    new Tuple<int, int>(-1, 0),
    new Tuple<int, int>(-1, 1),
    new Tuple<int, int>(0, -1),
    new Tuple<int, int>(0, 1),
    new Tuple<int, int>(1, -1),
    new Tuple<int, int>(1, 0),
    new Tuple<int, int>(1, 1),
};

Dictionary<char, int> numCharToNumInt = new Dictionary<char, int>
{
    { '0', 0 },
    { '1', 1 },
    { '2', 2 },
    { '3', 3 },
    { '4', 4 },
    { '5', 5 },
    { '6', 6 },
    { '7', 7 },
    { '8', 8 },
    { '9', 9 },
};

void populateGearSet(HashSet<Tuple<int, int>> gearLocs, string[] lines)
{
    for(int i = 0; i < lines.Length; i += 1)
    {
        for(int j = 0; j < lines[i].Length; j += 1)
        {
            if (lines[i].ElementAt(j)== '*')
            {
                gearLocs.Add(new Tuple<int, int>(i, j));
                //Console.WriteLine("({0}, {1})", j, i);
            }
        }
    }
}

void populateSymbolSet(HashSet<Tuple<int, int>> symbolLocs, string[] lines)
{
    for (int i = 0; i < lines.Length; i += 1)
    {
        for (int j = 0; j < lines[i].Length; j += 1)
        {
            if (!nonSymbolChars.Contains(lines[i].ElementAt(j)))
            {
                symbolLocs.Add(new Tuple<int, int>(i, j));
                //Console.WriteLine("({0}, {1})", j, i);
            }
        }
    }
}

void populateCandidateNumberLocs(HashSet<Tuple<int, int>> candidateNumberLocs, HashSet<Tuple<int, int>> symbolLocs, string[] lines)
{
    foreach(Tuple<int, int> coord in symbolLocs)
    {
        foreach(Tuple<int, int> offset in neighborhood)
        {
            if (numericalChars.Contains(lines[coord.Item1 + offset.Item1].ElementAt(coord.Item2 + offset.Item2)))
            {
                addCandidateLeftmost(candidateNumberLocs, new Tuple<int, int>(coord.Item1 + offset.Item1, coord.Item2 + offset.Item2), lines);
            }
        }
    }
}

void populateGearConnections(Dictionary<Tuple<int, int>, HashSet<Tuple<int, int>>> gearConnections, HashSet<Tuple<int, int>> gearLocs, string[] lines)
{
    foreach (Tuple<int, int> coord in gearLocs)
    {
        foreach (Tuple<int, int> offset in neighborhood)
        {
            if (numericalChars.Contains(lines[coord.Item1 + offset.Item1].ElementAt(coord.Item2 + offset.Item2)))
            {
                var numCoord = getLeftmostNumCoord(new Tuple<int, int>(coord.Item1 + offset.Item1, coord.Item2 + offset.Item2), lines);
                if (!gearConnections.ContainsKey(coord))
                {
                    gearConnections[coord] = new HashSet<Tuple<int, int>>();
                }
                gearConnections[coord].Add(numCoord);
            }
        }
    }
}

Tuple<int, int> getLeftmostNumCoord(Tuple<int, int> coord, string[] lines)
{
    int y = coord.Item1;
    int x = coord.Item2;

    while (x >= 0 && numericalChars.Contains(lines[y].ElementAt(x)))
    {
        x -= 1;
    }

    return new Tuple<int, int>(x + 1, y);
}

void addCandidateLeftmost(HashSet<Tuple<int, int>> candidateNumberLocs, Tuple<int, int> coord, string[] lines)
{
    int y = coord.Item1;
    int x = coord.Item2;

    while (x >= 0 && numericalChars.Contains(lines[y].ElementAt(x)))
    {
        x -= 1;
    }

    candidateNumberLocs.Add(new Tuple<int, int>(x + 1, y));
}

int getIntValAtCoord(Tuple<int, int> coord, string[] lines)
{
    int accumulator = 0;
    int x = coord.Item1;
    int y = coord.Item2;

    while(x < lines[0].Length && numericalChars.Contains(lines[y].ElementAt(x)))
    {
        accumulator *= 10;
        accumulator += numCharToNumInt[lines[y].ElementAt(x)];
        x += 1;
    }

    return accumulator;
}

void printGearSet(Dictionary<Tuple<int, int>, HashSet<Tuple<int, int>>> gearConnections)
{
    foreach(var gearLoc in gearConnections)
    {
        Console.WriteLine(gearLoc.Key);
        foreach(var numLoc in gearLoc.Value)
        {
            Console.WriteLine("\t{0}", numLoc);
        }
    }
}

int getSumOfGearRatios(Dictionary<Tuple<int, int>, HashSet<Tuple<int, int>>> gearConnections, string[] lines)
{
    int accumulator = 0;

    foreach (var gearLoc in gearConnections)
    {
        if(gearLoc.Value.Count == 2)
        {
            accumulator += getIntValAtCoord(gearLoc.Value.ElementAt(0), lines) * getIntValAtCoord(gearLoc.Value.ElementAt(1), lines);
        }
    }

    return accumulator;
}

/* Problem 1
populateSymbolSet(symbolLocs, lines);
populateCandidateNumberLocs(candidateNumberLocs, symbolLocs, lines);

foreach(var coord in candidateNumberLocs)
{
    accumulator += getIntValAtCoord(coord, lines);
}

Console.WriteLine(accumulator);
*/

/* Problem 2 */

populateGearSet(gearLocs, lines);
populateGearConnections(gearConnections, gearLocs, lines);

Console.WriteLine(getSumOfGearRatios(gearConnections, lines));