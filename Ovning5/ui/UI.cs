namespace Ovning5.ui
{
    public class UI : IUI
    {
        public static string AskForString(string prompt)
        {
            string answer;
            bool success = false;

            //loopa tills användaren har skrivit in något
            do
            {
                Print($"{prompt}: ");
                answer = GetInput()!;

                //Än så länge ingen annan validering än att strängen inte får vara tom.
                if (string.IsNullOrWhiteSpace(answer))
                {
                    Print($"You must enter a valid {prompt}\n");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        private static string GetInput()
        {
            return Console.ReadLine();
        }

        private static void Print(string v)
        {
            Console.Write(v);
        }

        public int askForIntInput(string prompt)
        {
            do
            {
                string input = AskForString(prompt);

                //Anropa AskForString så vi vet att vi faktiskt får en string tillbaks
                //Fortsätter tills vi har fått en string som vi kan Parsa till en uint
                //Oftast använder man sig av en int här kör jag uint mer för demo.
                if (int.TryParse(input, out int answer))
                {
                    return answer;
                }
                else
                    Print($"You must enter a valid {prompt}\n");


            } while (true);

        }

        public string askForStringInput(string prompt)
        {
            return AskForString(prompt);
        }

    }
}
