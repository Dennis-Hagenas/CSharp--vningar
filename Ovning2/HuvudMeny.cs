using System.Text;

namespace Ovning2
{
    public class HuvudMeny
    {
        const string BioBesok = "1";
        const string BioSallskap = "2";
        const string Upprepa = "3";
        const string TredjeOrdet = "4";
        const string Avsluta = "0";


        public void Run()
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("\nHuvudmeny");
                Console.WriteLine("---------\n");
                Console.WriteLine($"{BioBesok} Bio besök");
                Console.WriteLine($"{BioSallskap} Bio besök för sällskap");
                Console.WriteLine($"{Upprepa} Upprepa");
                Console.WriteLine($"{TredjeOrdet} Tredje ordet");
                Console.WriteLine($"{Avsluta} Avsluta program");
                Console.Write("\n>");

                string input = Console.ReadLine()!;
                switch (input)
                {
                    case BioBesok:
                        BioBesokMethod();
                        break;
                    case BioSallskap:
                        BioSallskapMethod();
                        break;
                    case Upprepa:
                        UpprepaMethod();
                        break;
                    case TredjeOrdet:
                        TredjeOrdetMethod();
                        break;

                    case Avsluta:
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Felaktigt val");
                        break;
                }
                Console.WriteLine();
            }
        }

        private void BioSallskapMethod()
        {
            Console.Write("Hur många personer är det i sällskapet: ");
            string personer_s = Console.ReadLine()!;
            int personer_i = 0;
            if (int.TryParse(personer_s, out personer_i))
            {

                int summa = 0;
                for (int i = 0; i < personer_i; i++)
                {
                    Console.Write($"Ange ålder för person {i + 1}: ");
                    string alder_input = Console.ReadLine()!;
                    int pris = 0;
                    string prisKategori = "";
                    PrisMethod(alder_input, out pris, out prisKategori);
                    summa += pris;
                }

                Console.WriteLine($"Ett biosällskap på {personer_i} personer, totalkostnad: {summa:C}");
            }
            else Console.WriteLine("Felaktigt värde");
        }

        private void TredjeOrdetMethod()
        {
            Console.Write("Skriv en mening: ");
            try
            {
                string mening = Console.ReadLine();
                var ord = mening.Split(" ");

                StringBuilder str_build = new StringBuilder();
                for (int i = 0; i < ord.Length; i++)
                {
                    if (ord[i].Length > 0) str_build.Append(ord[i] + " ");
                }

                ord = str_build.ToString().Split(" ");

                //for (int i = 0; i < ord.Length; i++)
                //{
                //    Console.Write($" Ord {i + 1}: \"{ord[i]}\"");
                //}
                Console.WriteLine($"Det tredje ordet är {ord[2]}");
            }
            catch
            {
                Console.WriteLine("Inget giltigt värde angavs.");
            }
        }

        private void UpprepaMethod()
        {
            Console.Write("Ange en text:");
            string input = Console.ReadLine()!;
            for (int i = 0; i < 10; i++)
                Console.Write($"{i + 1}. {input} ");
        }

        private void PrisMethod(string alder, out int pris, out string priskategori)
        {
            int alder_i = int.Parse(alder);

            pris = 120;
            priskategori = "Standardpris";

            if (alder_i < 20)
            {
                if (alder_i < 5) { pris = 0; priskategori = "Barn går gratis"; }
                else { pris = 80; priskategori = "Ungdomspris"; }
            }
            else if (alder_i > 64)
            {
                if (alder_i > 100) { pris = 0; priskategori = "Pensionärer över 100 går gratis"; }
                else { pris = 90; priskategori = "Pensionärspris"; }
            }
        }


        private void BioBesokMethod()
        {
            string prisKategori = "";
            int pris = 0;

            Console.Write("Ange ålder: ");
            string input = Console.ReadLine()!;

            PrisMethod(input, out pris, out prisKategori);

            Console.WriteLine($"{pris:C} {prisKategori}");
        }

    }
}
