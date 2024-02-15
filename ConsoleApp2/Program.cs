// See https://aka.ms/new-console-template for more information
class Program
{
 static void Main (string[] args)
{


Cars Ford = new Cars();
Ford.Color="Blue";
Console.WriteLine(Ford.Color);
Ford.fullThrottle();

Cars Bmw = new Cars();
Bmw.Color="Orange";

Console.WriteLine(Bmw.Color);
Console.WriteLine(Ford.Color);



}
}

