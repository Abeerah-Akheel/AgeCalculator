AgeCalculatorApp();

void AgeCalculatorApp()
{
    Console.WriteLine("Welcome to the Age Calculator App!");

    //Ask for user's name
    Console.WriteLine("Please enter your name");
    string name = Console.ReadLine();

    //Ask for user's age
    Console.WriteLine("Please enter your age");
    int age = Convert.ToInt32(Console.ReadLine());

    //Calculate age in 5 years
    int ageInFiveYears = age + 5;

    //Display age in 5 years
    Console.WriteLine($"Hello {name}, you will be {ageInFiveYears} in 5 years.");
}