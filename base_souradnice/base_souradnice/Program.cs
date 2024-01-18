using base_souradnice;

Coord c1 = new Coord(10, 10);
Coord c2 = new Coord(10, 10);

Console.WriteLine(c1 == c2); // False
Console.WriteLine(c2.Equals(c2)); // True
Console.WriteLine(Coord.CoordAddition(c1, c2));
Console.WriteLine(Coord.CoordMultiplication(c1, 5));