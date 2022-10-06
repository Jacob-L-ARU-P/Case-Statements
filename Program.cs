// Case Statements

// Get number
int day;
Console.Write("Please enter a number between 1 and 7: ");
// Loop(tm)?

    // Checks for valid input
    try {
        day = Convert.ToInt32(Console.ReadLine());
        // Big 'n' Easy IF statement
        switch(day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Numbers between 1 (One) and 7 (Seven) only");
                break;

        }
    }
    // Error Message
    catch 
    {
        Console.WriteLine("Invalid Input.");
    }


// Console Hold Line
Console.ReadKey();