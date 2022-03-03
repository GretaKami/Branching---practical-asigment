// See https://aka.ms/new-console-template for more information

short var1 = 123;
short var2 = 12345;

Console.WriteLine($"First number is {var1}");
Console.WriteLine($"Second number is {var2}");

if (var1>var2)
{
    Console.WriteLine($"Larger number is {var1}");
}
else
{
    Console.WriteLine($"Larger number is {var2}");
    
}
if (var1>var2)
{
Console.WriteLine($"Smallest number is {var2}");

}
else

{
    Console.WriteLine($"Smallest number is {var1}");
}

if (var1==var2)
{ 
 Console.WriteLine("Both varibles are equal");
}
else
{
    Console.WriteLine("Variables are not equal");
}


if (var1%2 != 0)
{
    Console.WriteLine($"First number {var1} is odd");
}

if (var2 % 2 != 0)
{
    Console.WriteLine($"Second number {var2} is odd");

}
if (var2%2==0)
{
    Console.WriteLine($"Second number {var2} is even");

}
if (var1%2==0)
{
    Console.WriteLine($"First number {var1} is even");

}
if (var1<0 || var2<0)
{
    Console.WriteLine ($"There are a negative value");
}



