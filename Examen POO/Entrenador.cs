using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_POO
{
    public class Entrenador : Persona
    {
        private int puntos_tactica;

        public Entrenador(string name, int edad, string nacion, int sueldo, int puntos_tactica)
            : base(name, edad, nacion, sueldo)
        {
            this.Puntos_tactica = puntos_tactica;
        }

        public int Puntos_tactica { get => puntos_tactica; set => puntos_tactica = value; }

        public void Cambiar_Jugador(List<Jugadores> mis_jugadores, List<Jugadores> en_cancha)
        {

        }
    }
}
