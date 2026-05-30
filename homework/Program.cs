Console.WriteLine("Hello, user!");
Console.WriteLine("Enter your name");
string name = Console.ReadLine();
Console.WriteLine("Enter your age");
int age = int.Parse(Console.ReadLine());
if (age < 18){
    Console.WriteLine($"Sorry {name} you cant vote for now");
}
else{
    Console.WriteLine($"{name} You can vote ");
}