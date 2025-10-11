List<int> numbers = new List<int>();
char choice;
do
{
    Console.WriteLine("P - Print numbers");
    Console.WriteLine("A - Add a number");
    Console.WriteLine("M - Display mean of the numbers");
    Console.WriteLine("S - Display the smallest number");
    Console.WriteLine("L - Display the largest number");
    Console.WriteLine("F - Find a number");
    Console.WriteLine("C - Clear the whole list");
    Console.WriteLine("Q - Quit");

    Console.Write("\nEnter your choice: ");
    choice = Char.ToUpper(Console.ReadKey().KeyChar);
    Console.WriteLine();

    switch (choice)
    {
        case 'P':
            if (numbers.Count == 0)
                Console.WriteLine("List is empty.");
            else
            {
                Console.Write("Numbers in list: ");
                for (int i = 0; i < numbers.Count; i++)
                    Console.Write(numbers[i] + " ");
                Console.WriteLine();
            }
            break;

        case 'A':
            Console.Write("Enter a number to add: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numbers.Add(num);
                Console.WriteLine($"{num} added successfully!");
            }
            else
                Console.WriteLine("Invalid input.");
            break;

        case 'M':
            if (numbers.Count == 0)
                Console.WriteLine("List is empty.");
            else
            {
                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                    sum += numbers[i];
                double mean = (double)sum / numbers.Count;
                Console.WriteLine($"Mean of numbers: {mean}");
            }
            break;

        case 'S':
            if (numbers.Count == 0)
                Console.WriteLine("List is empty.");
            else
            {
                int smallest = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                    if (numbers[i] < smallest)
                        smallest = numbers[i];
                Console.WriteLine($"Smallest number: {smallest}");
            }
            break;

        case 'L':
            if (numbers.Count == 0)
                Console.WriteLine("List is empty.");
            else
            {
                int largest = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                    if (numbers[i] > largest)
                        largest = numbers[i];
                Console.WriteLine($"Largest number: {largest}");
            }
            break;

        case 'F':
            if (numbers.Count == 0)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                Console.Write("Enter a number to find: ");
                if (int.TryParse(Console.ReadLine(), out int target))
                {
                    int index = -1;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == target)
                        {
                            index = i;
                            break;
                        }
                    }
                    if (index == -1)
                        Console.WriteLine($"Number {target} not found in list.");
                    else
                        Console.WriteLine($"Number {target} found at index {index}.");
                }
                else
                    Console.WriteLine("Invalid number.");
            }
            break;

        case 'C':
            numbers.Clear();
            Console.WriteLine("List cleared successfully!");
            break;

        case 'Q':
            Console.WriteLine("Exiting program...");
            break;

        default:
            Console.WriteLine("Invalid choice, please try again.");
            break;
    }

} while (choice != 'Q');