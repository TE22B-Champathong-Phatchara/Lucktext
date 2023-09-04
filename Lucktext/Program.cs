// See https://aka.ms/new-console-template for more information

string? name;
string? food;
string? animal;
string? num;






Console.WriteLine("Write name");
name = Console.ReadLine();

Console.WriteLine("Write your favorite food");
food = Console.ReadLine();

Console.WriteLine("Wrtie your favorite animal");
animal = Console.ReadLine();

Console.WriteLine("Last question, is 2 + 2 = 4?");
num = Console.ReadLine();

Console.WriteLine("In the deepest forest, there is a guy named " + num + ". His favorite food is " + animal + " and he has a " + food + "as a pet. Sometime he'd like to hanging around with " + name +"!");


Console.ReadKey();
