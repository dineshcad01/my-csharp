// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("First demo of C#");

long a=8524898874;
Console.WriteLine("Value of a is.."+a);

float b=1.5f;
Console.WriteLine("value" +b);

double c=150;
Console.WriteLine("Value of c is " +c);
Console.WriteLine(c.GetType());


char d='s';
Console.WriteLine("Value of c is " +d);
Console.WriteLine(d.GetType());

string str="welcome";
Console.WriteLine("Value of c is " +str);
Console.WriteLine(str.GetType());


     Console.WriteLine(Math.Sqrt(64)); 

if (20<30)
Console.WriteLine("20 is greater than 40");

Console.WriteLine(Math.Max(5, 10));
Console.WriteLine(Math.Min(5, 10));
Console.WriteLine(Math.Sqrt(64));
Console.WriteLine(Math.Abs(-64.4));
Console.WriteLine(Math.Abs(64.4));

string greeting = "Hello";
Console.WriteLine(greeting);



string txt = "We are called \"Gladiators\" around the world.";
Console.WriteLine(txt);

int time=24;
if (time <10)
{
    Console.WriteLine("This is morning");
}
else if (time < 20){
    Console.WriteLine("This is night");
}
else {
    Console.WriteLine("This is a day");
}