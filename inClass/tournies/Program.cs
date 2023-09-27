using System.ComponentModel.DataAnnotations;

Player ronaldo = new Player("Christiano Ronaldo", 7);
ronaldo.Display();

Player bryce = new Player("Bryce Woodland", 89);
bryce.Display();

Player momma = new Player("Joe Momma", 74);

Player jake = new Player ("Jake from State Farm", 12);

Team cardinals = new Team("Cardinals");

Team sunshine = new Team("Sunshine");

cardinals.AddPlayer(ronaldo);
cardinals.AddPlayer(bryce);

cardinals.DisplayRoster();

sunshine.AddPlayer(momma);
sunshine.AddPlayer(jake);

sunshine.DisplayRoster();

Match match1 = new Match(cardinals, sunshine);

match1.DisplayMatch();