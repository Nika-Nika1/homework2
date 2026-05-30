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

int[] array = [100,20,3];
int BIG = 0;
for (var i = 0; i < array.Length; i++)
{
    int member = array[i];
    if (BIG < member)
    {
        BIG = member;
    }
}
Console.WriteLine(BIG);