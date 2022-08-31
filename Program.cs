using System;

namespace SystemOfADownload
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int testes, a, b;
            string [] valores;

             testes=  int.Parse(Console.ReadLine());

            for (int i = 0; i < testes; i++)
            {
                valores =  Console.ReadLine().Split(' ');
                a = int.Parse(valores[0]);
                b = int.Parse(valores[1]);


                switch (a + b)
                {
                    case 0: Console.WriteLine("PROXYCITY\n"); break;
                    case 1: Console.WriteLine("P.Y.N.G.\n"); break;
                    case 2: Console.WriteLine("DNSUEY!\n"); break;
                    case 3: Console.WriteLine("SERVERS\n"); break;
                    case 4: Console.WriteLine("HOST!\n"); break;
                    case 5: Console.WriteLine("CRIPTONIZE\n"); break;
                    case 6: Console.WriteLine("OFFLINE DAY\n"); break;
                    case 7: Console.WriteLine("SALT\n"); break;
                    case 8: Console.WriteLine("ANSWER!\n"); break;
                    case 9: Console.WriteLine("RAR?\n"); break;
                    case 10: Console.WriteLine("WIFI ANTENNAS\n"); break;
                    default: Console.WriteLine("Musica não cadastrada"); break;
                }

            }
                
        }
    }
}
