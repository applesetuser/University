using System;

namespace daty
{
    class Program
    {
        static void Main(string[] args)
        {
            // data musi z gory byc wprowadzona dobrze

            if(args.Length<2)
            {
                Console.WriteLine("wprowadzono bledne dane daty");
                Console.WriteLine();
                Console.WriteLine("Prosze wpisac date w formacie 'yyyy-MM-dd hh:mm:ss +-(liczba)+ s/m/h/d/M/y'(przy dodawaniu wartosci oddzeilac spacja)");
                Console.WriteLine();
            }

            string xdate = args[0]; //xdate; xhour; wprowadzana data i godzina
            string xhour = args[1];

            var date = DateTime.Parse(xdate + " " + xhour);
            int x_length = args.Length;

            //musi pobierac co drugi wyraz zeby nie trafic w litere
            
            for(int i=2; i<x_length; i+=2) //wszystko w petli, zaczyna od 2 wyrazu
            {
                int y = int.Parse(args[i]);


                //aby skrocic wiele polecen if

            

                switch(args[i+1])
                {
                    case "s":
                        date=date.AddSeconds(y);
                        break;

                    case "m":
                        date=date.AddMinutes(y);
                        break;

                    case "h":
                        date=date.AddHours(y);
                        break;

                    case "d":
                        date=date.AddDays(y);
                        break;

                    case "M":
                        date=date.AddMonths(y);
                        break;

                    case "Y":
                        date=date.AddYears(y);
                        break;
                }
            }
            
            Console.WriteLine("wprowadzona data to:");
            Console.WriteLine(date.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}