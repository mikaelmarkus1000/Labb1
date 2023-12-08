﻿
// Frågar användaren om Input på namn och ålder på olika personer.
Console.WriteLine("Enter the name of person 1");
string name1 = Console.ReadLine();
Console.WriteLine("Enter the age of person 1");
string age1 = Console.ReadLine();
Console.WriteLine("Enter the name of person 2");
string name2 = Console.ReadLine();
Console.WriteLine("Enter the age of person 2");
string age2 = Console.ReadLine();
Console.WriteLine("Enter the name of person 3");
string name3 = Console.ReadLine();
Console.WriteLine("Enter the age of person 3");
string age3 = Console.ReadLine();
Console.WriteLine("Enter the name of person 4");
string name4 = Console.ReadLine();
Console.WriteLine("Enter the age of person 4");
string age4 = Console.ReadLine();

// Skriver ut åldrar
Console.WriteLine(name1 + " is " + age1 + " years old");
Console.WriteLine(name2 + " is " + age2 + " years old");
Console.WriteLine(name3 + " is " + age3 + " years old");
Console.WriteLine(name4 + " is " + age4 + " years old"); 

// Parsear alla ålder strängar till ints så man kan göra matte med dem. 
int intAge1 = int.Parse(age1);
int intAge2 = int.Parse(age2);
int intAge3 = int.Parse(age3);
int intAge4 = int.Parse(age4);

//Gör avrageNumber till en float och sedan räknar ut avrage från alla ints
float avragenNumber = (intAge1 + intAge2 + intAge3 + intAge4) / 4;
Console.WriteLine($"Average of all ages: {avrageNumber:F2}");
Console.ReadLine();