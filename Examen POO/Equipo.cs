using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_POO
{
    public class Equipo
    {
        private string name;
        private bool nacional;
        private List<Jugadores> players;
        private Entrenador entrenador;
        private Medico medico;


        private bool equipo_valido;

        public Equipo(string name, bool nacional, List<Jugadores> players, Entrenador entrenador, Medico medico)
        {
            this.Name = name;
            this.Nacional = nacional;
            if (players.Count() == 15) //Verifiquemos que el equipo sean de 15 jugadores
            {
                this.Players = players;
            }
            this.Entrenador = entrenador;
            this.Medico = medico;
            equipo_valido = Verificar_Jugadores(); //Verifica en el caso de que el equipo es nacional si sus jugadores son del mismo pais
        }

        public string Name { get => name; set => name = value; }
        public bool Nacional { get => nacional; set => nacional = value; }
        public List<Jugadores> Players { get => players; set => players = value; }
        public Entrenador Entrenador { get => entrenador; set => entrenador = value; }
        public Medico Medico { get => medico; set => medico = value; }

        public bool Verificar_Jugadores()
        {
            if (Nacional)
            {
                for (int i = 0; i < players.Count(); i++)
                {
                    if (players[i].Nacion != players[(i + 1) % players.Count()].Nacion)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
