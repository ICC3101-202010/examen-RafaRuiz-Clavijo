using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_POO
{
    public class Jugadores : Persona
    {
        protected int puntos_ataque;
        protected int puntos_defensa;
        protected int numero_camiseta;

        protected bool lesionado;

        public delegate void HelpThePlayerEventHandler(object source, HelpThePlayerEventArgs args);
        public event HelpThePlayerEventHandler NotificarLesion;

        public Jugadores(string name, int edad, string nacion, int sueldo, int puntos_ataque, int puntos_defensa, int numero_camiseta, bool lesionado) 
            : base (name, edad, nacion, sueldo)
        {
            this.Puntos_ataque = puntos_ataque;
            this.Puntos_defensa = puntos_defensa;
            this.Numero_camiseta = numero_camiseta;
            this.Lesionado = lesionado;
        }

        public int Puntos_ataque { get => puntos_ataque; set => puntos_ataque = value; }
        public int Puntos_defensa { get => puntos_defensa; set => puntos_defensa = value; }
        public int Numero_camiseta { get => numero_camiseta; set => numero_camiseta = value; }
        public bool Lesionado { get => lesionado; set => lesionado = value; }

        public void Jugar_Cancha()
        {
            //Metodo en el que el jugador juega en la cancha
        }

        public void Avisar_Lesion()
        {
            if (Lesionado && NotificarLesion != null)
            {
                NotificarLesion(this, new HelpThePlayerEventArgs() { player = this });
            }
        }
    }
}
