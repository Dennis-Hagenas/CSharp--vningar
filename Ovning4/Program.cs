namespace Ovning4
{
    /*
     * 
     * 1. Stacken är en kö eller lista där det första objektet som läggs i minnet är det sista som tas bort
     * Heapen är ett minnesområde där object lagras mer persistent med minneshantering och garbagecollection
     * 
     * 2. ValueTypes är de primitiver som deklareras i C# som int, double. Dessa kan ligga på stacken eller heapen
     * Reference types är objekt som alltid ligger på heapen och ärver från System.Object
     * 
     * 3. y innehåller en referens till x, när y sätts till 4 sätts också x till fyra,
     * i det första exemplet sätts inte x till 4 när y sätts till 4
     * 
     * 
     * 
     */


    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 6, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. ReverseString"
                    + "\n6. RecursiveEven"
                    + "\n7. Fibonacci"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        ReverseString();
                        break;
                    case '6':
                        RecursiveEvenInteract();
                        break;
                    case '7':
                        FibonacciInteract();
                        break;
                    case '8':
                        IterativeEvenInteract();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }


        /*
         *  F: Den iterativa varianten bör vara mer minnesvänlig,
         *  variablerna behöver bara allokeras en gång istället för varje metodanrop
         * 
         */


        private static void IterativeEvenInteract()
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int i = int.Parse(input);
            Console.WriteLine($"The {i} even number is {IterativeEven(i)}");
        }

        private static object IterativeEven(int n)
        {
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result += 2;
            }
            return result;
        }

        private static void FibonacciInteract()
        {
            Console.WriteLine("Enter series length");
            string input = Console.ReadLine();
            int i = int.Parse(input);
            for (int k = 0; k < i; k++)
            {
                Console.Write($"{Fibonacci(k)} ");
            }
            Console.WriteLine();
        }

        private static int Fibonacci(int i)
        {
            if (i == 0) return 0;
            if (i == 1) return 1;
            return Fibonacci(i - 1) + Fibonacci(i - 2);
        }

        private static void RecursiveEvenInteract()
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int i = int.Parse(input);
            Console.WriteLine($"The {i} even number is {RecursiveEven(i)}");
        }

        private static int RecursiveEven(int i)
        {
            if (i == 1) return 2;
            return RecursiveEven(i - 1) + 2;
        }

        private static void ReverseString()
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input.ElementAt(i));
            }
            foreach (char c in stack)
                Console.Write(c);
            Console.WriteLine();
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * 
             * 
             * 2. Listan ökar när 5 element lagts till
             * 3. Listan dubblerar i storlek
             * 4. För att spara på cpu tid och minnesfragmentering
             * 5. Kapaciteten minskar inte när element tas bort ur listan
             * 6.
             * 
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();

            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter a string");
                Console.WriteLine($"List Capacity: {theList.Capacity} Length: {theList.Count()}");

                string input;
                char nav;
                string value;

                try
                {
                    input = Console.ReadLine();
                    nav = input[0];
                    value = input.Substring(1);
                }
                catch (Exception)
                {
                    nav = 'A';
                    value = "A";
                }

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    case 'l':
                        foreach (string str in theList)
                        {
                            Console.Write($" {str} ");
                        }
                        Console.WriteLine();
                        break;
                    case '0':
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Use + or - to add or remove items from the list\nl to print list\n0 to exit to main menu");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * 
             * 
             * 
             * 
             * 
             * 
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue<string> theQueue = new Queue<string>();

            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter a string");
                Console.WriteLine($"Queue Length: {theQueue.Count()}");

                string input;
                char nav;
                string value;

                try
                {
                    input = Console.ReadLine();
                    nav = input[0];
                    value = input.Substring(1);
                }
                catch (Exception)
                {
                    nav = 'A';
                    value = "A";
                }

                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(value);
                        break;
                    case '-':
                        theQueue.Dequeue();
                        break;
                    case 'l':
                        Console.Write("Queue: ");
                        foreach (string str in theQueue)
                        {
                            Console.Write($" {str} ");
                        }
                        Console.WriteLine();
                        break;
                    case '0':
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Use + to queue an item, - to dequeue\nl to print list\n0 to exit to main menu");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * 1. Den som kommer sist till kön för förtur
             * 
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            Stack<string> theStack = new Stack<string>();

            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter a string");
                Console.WriteLine($"Stack Length: {theStack.Count()}");

                string input;
                char nav;
                string value;

                try
                {
                    input = Console.ReadLine();
                    nav = input[0];
                    value = input.Substring(1);
                }
                catch (Exception)
                {
                    nav = 'A';
                    value = "A";
                }

                switch (nav)
                {
                    case '+':
                        theStack.Push(value);
                        break;
                    case '-':
                        theStack.Pop();
                        break;
                    case 'l':
                        Console.Write("Queue: ");
                        foreach (string str in theStack)
                        {
                            Console.Write($" {str} ");
                        }
                        Console.WriteLine();
                        break;
                    case '0':
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Use + to push an item, - to pop\nl to print list\n0 to exit to main menu");
                        break;
                }
            }

        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */


            Console.WriteLine("Enter a string with parenthesis (){}[]");
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool wellFormed = true;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if ((c == '(') || (c == '{') || (c == '[')) stack.Push(c);
                if ((c == ')') || (c == '}') || (c == ']'))
                {
                    if (stack.Count == 0)
                    {
                        wellFormed = false;
                        break;
                    }
                    char corresponding = stack.Pop();
                    if (c == ')' && corresponding != '(')
                    {
                        wellFormed = false;
                        break;
                    }
                    if (c == '}' && corresponding != '{')
                    {
                        wellFormed = false;
                        break;
                    }
                    if (c == ']' && corresponding != '[')
                    {
                        wellFormed = false;
                        break;
                    }
                }

            }
            if (wellFormed && stack.Count == 0)
                Console.WriteLine("The string has matching parenthesis.");
            else
                Console.WriteLine("The string does not have matching parenthesis.");

        }

    }
}

