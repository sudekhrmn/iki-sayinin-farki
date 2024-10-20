Console.WriteLine("birinci sayıyı giriniz");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("ikinci sayıyı giriniz");
int b = Int32.Parse(Console.ReadLine());

if (a > b)
{
    int c = a - b;
    Console.WriteLine("sayıların farkı: " + c);
}

else if (b > a)
{
    int c2 = b - a;
    Console.WriteLine("sayıların farkı: " + c2);
}

else
{
    Console.WriteLine("sayıların farkı 0");
}
Console.ReadKey();
