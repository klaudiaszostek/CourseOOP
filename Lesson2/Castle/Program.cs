Civilian civilian1 = new Civilian(35);
Civilian civilian2 = new Civilian(28);
Civilian civilian3 = new Civilian(37);
Civilian civilian4 = new Civilian(32);
Civilian civilian5 = new Civilian(33);

Crossbowman crossbowman1 = new Crossbowman(51);
Crossbowman crossbowman2 = new Crossbowman(55);
Crossbowman crossbowman3 = new Crossbowman(53);
Crossbowman crossbowman4 = new Crossbowman(49);
Crossbowman crossbowman5 = new Crossbowman(50);
Crossbowman crossbowman6 = new Crossbowman(62);

Pikeman pikeman1 = new Pikeman(65);
Pikeman pikeman2 = new Pikeman(70);
Pikeman pikeman3 = new Pikeman(59);
Pikeman pikeman4 = new Pikeman(68);


List<Inhabitant> allInhabitants =
[
    civilian1,
    civilian2,
    civilian3,
    civilian4,
    civilian5,
    crossbowman1,
    crossbowman2,
    crossbowman3,
    crossbowman4,
    crossbowman5,
    crossbowman6,
    pikeman1,
    pikeman2,
    pikeman3,
    pikeman4,
];

foreach (Inhabitant inhabitant in allInhabitants) Console.WriteLine(inhabitant.ToString() + " Rations: " + inhabitant.Eat());

Console.WriteLine("\n");

List<Crossbowman> allCrossbowmen =
[
    crossbowman1,
    crossbowman2,
    crossbowman3,
    crossbowman4,
    crossbowman5,
    crossbowman6,
];

foreach (Crossbowman crossbowman in allCrossbowmen) Console.WriteLine(crossbowman.ReadyToFight());

Console.WriteLine("\n");

List<Guardian> allGuardians =
[
    crossbowman1,
    crossbowman2,
    crossbowman3,
    crossbowman4,
    crossbowman5,
    crossbowman6,
    pikeman1,
    pikeman2,
    pikeman3,
    pikeman4,
];

foreach (Guardian guardian in allGuardians) Console.WriteLine(guardian.ReadyToFight());

Console.ReadKey();
