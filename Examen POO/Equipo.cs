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
            foreach(Jugadores data in players)
            {
                data.NotificarLesion += entrenador.OnNotificar_Lesion; //Suscribo a cada evento del jugador al metodo de su entrenador
            }
            equipo_valido = Verificar_Jugadores(); //Verifica en el caso de que el equipo es nacional si sus jugadores son del mismo pais
        }

        public string Name { get => name; set => name = value; }
        public bool Nacional { get => nacional; set => nacional = value; }
        public List<Jugadores> Players { get => players; set => players = value; }
        public Entrenador Entrenador { get => entrenador; set => entrenador = value; }
        public Medico Medico { get => medico; set => medico = value; }

        //Teniendo las propiedades se pueden agregar jugadores con Players.Add();
        //Se puede instanciar Entrenador como newTeam.Entrenador = new Entrenador -> Igualmente se puede por constructor
        //Lo mismo con medico

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

        public List<string> Info_Equipo()
        {
            List<string> mi_equipo = new List<string>();
            mi_equipo.Add(Name);
            mi_equipo.Add(Convert.ToString(Nacional));
            mi_equipo.Add(Entrenador.Nombre);
            mi_equipo.Add(Medico.Nombre);
            foreach(Jugadores data in players)
            {
                mi_equipo.Add(data.Nombre);
            }
            return mi_equipo;
        }


    }
}
