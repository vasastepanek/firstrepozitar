using System.ComponentModel.Design;

int a = 25;

a += 4;

Console.WriteLine(a);

int b = 8;

b++;

Console.WriteLine(b);

// input1
// pro sudé číslo hodnotu zvětším 3*
// pro liché čislo hodnotu zvětším 2*
// na konci číslo vypište

int input1 = 3;

if (input1 % 2 == 0)
{
    input1 *= 3;
}
else
{
    input1 *= 2;
}
Console.WriteLine(input1);

string s = "ahoj, ";

Console.WriteLine(s);

string x = "";
string.IsNullOrWhiteSpace(x);

if (string.IsNullOrWhiteSpace(x))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}

string g = "ahoj, ";
string input2 = "pepa";
if (string.IsNullOrWhiteSpace(input2))
{
    Console.WriteLine("hello world");
}
else
{
    g += input2;
    Console.WriteLine(g);
}

string input3 = "MyNameIsNotVasek";
if (input3.Length > 5 && input3.Length < 25)
{
    Console.WriteLine("heslo je ok");
}
else
{
    Console.WriteLine("heslo neni ok");
}

Console.WriteLine("zadej slovo");
string userInput = Console.ReadLine();

Console.WriteLine("uzivatel zadal " + userInput);
Console.WriteLine($"uzivatel zadal {userInput}");
