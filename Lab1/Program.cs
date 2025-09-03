//Step 1
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

c = a - b;
Console.WriteLine(c);

//Step 2
a = 5;
b = 4;
c = 2;
int d = a + b * c;
Console.WriteLine(d);

d = (a + b) * c;
Console.WriteLine(d);

d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

a = 7;
b = 4;
c = 3;
d = (a + b) / c;
Console.WriteLine(d);

//Step 3
a = 7;
b = 4;
c = 3;
d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"an example of overflow: {what}");

//Step 4
double aa = 5;
double bb = 4;
double cc = 2;
double dd = (aa + bb) / cc;
Console.WriteLine(dd);

aa = 19;
bb = 23;
cc = 8;
dd = (a + b) / c;
Console.WriteLine(dd);

double dMax = double.MaxValue;
double dMin = double.MinValue;
Console.WriteLine($"The range of double is {dMin} to {dMax}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

//Step 5
decimal deMin = decimal.MinValue;
decimal deMax = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {deMin} to {deMax}");

aa = 1.0;
bb = 3.0;
Console.WriteLine(aa / bb);

decimal ccc = 1.0M;
decimal ddd = 3.0M;
Console.WriteLine(ccc / ddd);

//Step 6
double radius = 2.5;
double area = (radius * radius) * Math.PI;

Console.WriteLine($"The area for a circle with a radius of {radius} is {area}");