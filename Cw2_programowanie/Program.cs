using Cw2_programowanie;

Circle parameterless = new Circle();
Console.WriteLine(parameterless.Ray);

Circle c2 = new Circle(2);
Console.WriteLine(c2.Ray);

c2.Ray = 1;

Console.WriteLine(c2.Ray);
Console.WriteLine(c2.Field);
Console.WriteLine(c2.Circumference);

c2.Diameter = 8;
Console.WriteLine(c2.Diameter);
Console.WriteLine(c2.Ray);

Circle c3 = new Circle(4);
Console.WriteLine(c3.Diameter);

Console.WriteLine(Circle.AreCirclesEven(c2,c3));

Point a = new Point(-2, 3);
Point b = new Point(4, 3);
Point c = new Point(-2, -5);
Point d = new Point(4, -5);
Quadruple q1 = new Quadruple(a, b, c, d);


q1.Circumference = Quadruple.CalculateCircumference(a,b,c,d);
var ab = Quadruple.CalculateDistance(a, b);

Console.WriteLine(ab);
Console.WriteLine(q1.Circumference);