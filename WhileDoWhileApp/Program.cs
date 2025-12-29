// See https://aka.ms/new-console-template for more information
// This is a simple console application demonstrating while and do-while loops in C#
//while loop


int counter = 0;
//evaluate the condition before executing the loop body
while (counter < 5)
{
    Console.WriteLine("The counter is currently at: " + counter);
    counter++;
}

//do while loop

int greeting;

do
{
    Console.WriteLine("Choices: ");
    Console.WriteLine("1. Say Hello!");
    Console.WriteLine("2. Say Goodbye!");
    Console.WriteLine("3. Ask about the weather");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice (1-4): ");

    greeting= Convert.ToInt32(Console.ReadLine());

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
} while (greeting != 4);