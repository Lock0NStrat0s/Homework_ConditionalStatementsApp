
//ask for their name
Console.Write("What is your name: ");
string? firstName = Console.ReadLine();

//using if statement determine if user is the professor or student and welcome them

//if (firstName.ToLower() == "tim" || firstName.ToLower() == "timothy")
//{
//    Console.WriteLine("Welcome Professor!");
//}
//else
//{
//    Console.WriteLine("Welcome Student!");
//}

//now do the same with switch statement

switch (firstName.ToLower())
{
    case "tim" or "timothy":
        Console.WriteLine("Welcome Professor!");
        break;
    default:
        Console.WriteLine("Welcome Student!");
        break;
}