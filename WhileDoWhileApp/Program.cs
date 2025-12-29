// See https://aka.ms/new-console-template for more information
// This is a simple console application demonstrating while and do-while loops in C#
//WHILE LOOP

//initialize the counter variable
int counter = 0;
//evaluate the condition before executing the loop body
while (counter < 5)
{
    //clearly show where the coutner is at each iteration
    Console.WriteLine("The counter is currently at: " + counter);
    //increment the counter variable
    counter++;
}
//coutner goes up each iteration until it reaches 5

//DO WHILE LOOP

//initialize the greeting variable
int greeting;
//start do while loop
do
{
    //display menu options in console
    Console.WriteLine("Choices: ");
    Console.WriteLine("1. Say Hello!");
    Console.WriteLine("2. Say Goodbye!");
    Console.WriteLine("3. Ask about the weather");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice (1-4): ");

    //convert user input from string to integer
    greeting = Convert.ToInt32(Console.ReadLine());

    //evaluate the user input greeting variable using switch statement
    switch (greeting)
    {
        case 1:
            Console.WriteLine("Hello!");
            break;

        case 2:
            Console.WriteLine("Goodbye!");
            break;

        case 3:
            Console.WriteLine("It's a sunny day!");
            break;
        default:
            Console.WriteLine("That is not an option :(");
            break;
    }
    //boolean condition to continue or exit the loop
} while (greeting != 4);