using Cw2_programowanie;

Circle parameterless = new Circle();
Console.WriteLine(parameterless.Ray);

Circle c2 = new Circle(2);
Console.WriteLine(c2.Ray);

c2.Ray = 0;

Console.WriteLine(c2.Ray);