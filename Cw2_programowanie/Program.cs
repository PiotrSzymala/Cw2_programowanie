using Cw2_programowanie.OrderingSystem;
using Cw2_programowanie.RegisteringBookSystem;
using Cw2_programowanie.RegisteringBookSystem.Models;

/*Circle parameterless = new Circle();
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

Console.WriteLine(ReplaceCharacters("aabcdefghijklmnoprstuwxyz"));

ElectricityUsage e1 = new ElectricityUsage(144);

e1.ActualUsage = 145;

Console.WriteLine(e1.ActualUsage);


Client firstClient = new Client("Kamil", "Ślimak");

Order firstOrder = new Order(firstClient, new Dictionary<string, int>()
{
    {"Shrimps", 1},
    {"Penne Arrabiata", 1},
    {"Sparkling water", 2},
    {"flan",2}
});

OrderDisplayer.Display(firstOrder);*/

//OrderCreator.CreateOrder();


// Author a1 = new Author("Joseph", null, "Conrad", "Josh");
// Author a2 = new Author("Leopold", null, "Tyrmand", null);
//
//
// Book b1 = new Book(a1, "Jądro ciemności", "Heart of the Darkness", new DateTime(1899, 04, 03), "WorldCat", 2342455);
// Book b2 = new Book(a2, "Zły", "Zły", new DateTime(1959, 04, 23), "Wrzos", 34294);
//
// var books = new List<Book>()
// {
//     b1, b2
// };
//
// BookDisplayer.DisplayBooks(books);

BookManager.Run();
 static string ReplaceCharacters(string text)
 {
     char[] toReplace = new char[] { 'a', 'ą', 'e', 'ę', 'o', 'u', 'ó', 'i', 'y' };

     for (int i = 0; i < text.Length; i++)
     {
         char currentCharacter = text[i];

         if (toReplace.Contains(currentCharacter))
         {
             text = text.Replace(currentCharacter, '*');
         }
     }

     return text;
 }
 
static int SumIndividualDigits(int N)
{
    List<int> numbersThatMeetCondition = new List<int>();

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 10; l++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        for (int n = 0; n < 10; n++)
                        {
                            if (i + j + k + l + m + n == N)
                            {
                                string numbersToString = (i + j.ToString() + k.ToString()+l.ToString() +m.ToString() +n.ToString());

                                if (int.TryParse(numbersToString, out int b))
                                {
                                    numbersThatMeetCondition.Add(b);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    return numbersThatMeetCondition.Min();
}

static int SliceOfArray(int[] A) 
{
    int startIndex = 0;
    int endIndex = 0;
    
    for (int i = 2; i < A.Length; i++)
    {
        if (A[i - 2] >= 0 && A[i-1] <= 0 && A[i]>=0)
        {
            endIndex=i;
        }
        else if (A[i - 2] <= 0 && A[i-1] >= 0 && A[i]<=0)
        {
            endIndex=i;
        }
        else
        {
            startIndex = i-1;
        }
    }

    return startIndex > endIndex-startIndex? startIndex : endIndex-startIndex+1;
}