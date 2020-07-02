using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Examen_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Entrenador ent = new Entrenador("Juan", 23, "Chile", 2000000, 45);
            Medico med = new Medico("Medic", 32, "Japon", 2300000, 50);
            Jugadores player1 = new Jugadores("Pedrito", 23, "Chile", 250000, 50, 50, 50, false);
            Jugadores player2 = new Jugadores("Carlitos", 30, "Peru", 200000, 70, 80, 90, false);
            Arquero player3 = new Arquero("Diego", 45, "Chile", 234567, 60, 60, 60, false);
            List<Jugadores> my_players = new List<Jugadores>();
            for(int i = 0; i < 7; i++)
            {
                my_players.Add(player1);
                my_players.Add(player2);
            }
            my_players.Add(player3);
            my_players.Add(player2);
            Equipo equipo1 = new Equipo("Equipo", true, my_players, ent, med);
            Console.WriteLine(Convert.ToString(equipo1.Verificar_Jugadores()));
            foreach (string data in equipo1.Info_Equipo())
            {
                Console.WriteLine(data);
            }
        }
    }
}
