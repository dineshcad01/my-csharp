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

int day = 1;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
}

int sum1 = 100+100;
Console.WriteLine(sum1);
int sum2 = 100-50;
Console.WriteLine(sum2);
int sum3 = 100*50;
Console.WriteLine(sum3);
int sum4 = 100/50;
Console.WriteLine(sum4);
int sum5 = 100%50;
Console.WriteLine(sum5);
int sum6 = 100;
sum6++;
Console.WriteLine(sum6);
int sum7 = 100;
sum6--;
Console.WriteLine(sum7);

double sum8= 100.50d;
Console.WriteLine(sum8);

string sum9= "Dinesh";
Console.WriteLine(sum9);