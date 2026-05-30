/*Console.WriteLine("Hello, user!");
Console.WriteLine("Enter your name");
string name = Console.ReadLine();
Console.WriteLine("Enter your age");
int age = int.Parse(Console.ReadLine());
if (age < 18){
    Console.WriteLine($"Sorry {name} you cant vote for now");
}
else{
    Console.WriteLine($"{name} You can vote ");
}*/

/*int[] array = [100,20,3];
int BIG = 0;
for (var i = 0; i < array.Length; i++)
{
    int member = array[i];
    if (BIG < member)
    {
        BIG = member;
    }
}
Console.WriteLine(BIG);*/




Console.WriteLine("Enter first number");
var a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number");
var b = int.Parse(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("Result");
    Console.WriteLine((a+b)*3);
}
else
{
    Console.WriteLine("Result");
    Console.WriteLine(a+b);
}