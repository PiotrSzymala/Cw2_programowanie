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