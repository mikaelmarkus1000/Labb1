
// Frågar anvaändaren om Input på namn och ålder på olika personer.
Console.WriteLine("Write the name of person 1");
string name1 = Console.ReadLine();
Console.WriteLine("Write the age of person 1");
string age1 = Console.ReadLine();
Console.WriteLine("Write the name person 2");
string name2 = Console.ReadLine();
Console.WriteLine("Write the age of person 2");
string age2 = Console.ReadLine();
Console.WriteLine("Write the name of person 3");
string name3 = Console.ReadLine();
Console.WriteLine("Write the age of person 3");
string age3 = Console.ReadLine();
Console.WriteLine("Write the name of person 4"); 
string name4 = Console.ReadLine();
Console.WriteLine("Write the age of person 4");
string age4 = Console.ReadLine();


// Skriver ut åldrar
Console.WriteLine(name1 + "är " + age1 + " gammal");
Console.WriteLine(name2 + "är" + age2 + " gammal");
Console.WriteLine(name3 + "är " + age3 + " gammal");
Console.WriteLine(name4 + "är" + age4 + " gammal");


// Gör alla åldar till int
int intAge1 = int.Parse(age1);
int intAge2 = int.Parse(age2);
int intAge3 = int.Parse(age3);
int intAge4 = int.Parse(age4);

//Gör medianNumber till en float och sedan ränkar ut medianen från alla 
float medianNumber = (intAge1 + intAge2 + intAge3 + intAge4) / 4;
Console.WriteLine("Median is " + medianNumber);  
