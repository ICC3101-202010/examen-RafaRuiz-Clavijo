using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_POO
{
    public class Medico : Persona
    {
        private int puntos_experiencia;

        public Medico(string name, int edad, string nacion, int sueldo, int puntos_experiencia)
           : base(name, edad, nacion, sueldo)
        {
            this.Puntos_experiencia = puntos_experiencia;
        }

        public int Puntos_experiencia { get => puntos_experiencia; set => puntos_experiencia = value; }

        public bool Evaluar(Jugadores jugador)
        {
            //Ver si se puede plantear de otra forma
            if (jugador.Lesionado)
            {
                Curar(jugador);
            }
            return jugador.Lesionado;
        }

        public void Curar(Jugadores jugador)
        {
            jugador.Lesionado = false;
        }
    }
}
