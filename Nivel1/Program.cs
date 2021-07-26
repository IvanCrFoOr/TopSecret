using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Program
    {
        static void Main(string[] args)
        {
            Locations locations = new Locations();
            Messages messages = new Messages();

            BO.Distances ejeX = new BO.Distances() { DistanciaX= -100, DistanciaY= -500 };
            BO.Distances ejeY = new BO.Distances() { DistanciaX = 100, DistanciaY = 500 };
            double resultado = locations.GetLocation(ejeX, ejeY);
            Console.WriteLine("Distancia -> " + resultado);
            Console.ReadLine();

            string[] Kenobi = new string[] {"", "este", "es", "un", "mensaje","klklkl" };
            string[] msg = messages.GetMessages(Kenobi);
            for(int m =0; m<msg.Length; m++)
            {
                Console.WriteLine("Kenobi-> " + msg[m]);
            }
            string[] sKyWalker = new string[] { "", "este", "es", "un", "mensaje", "klklkl", "secreto" };
            string[] msgWalker = messages.GetMessages(Kenobi);
            for (int m = 0; m < msgWalker.Length; m++)
            {
                Console.WriteLine("sKyWalker-> " + msg[m]);
            }
            string[] sato = new string[] { "", "", "es", "un", "", "mensaje" };
            string[] msgSato = messages.GetMessages(sato);
            for (int m = 0; m < msgSato.Length; m++)
            {
                Console.WriteLine("Sato-> " + msg[m]);
            }
            Console.ReadLine();
        }
    }
}
