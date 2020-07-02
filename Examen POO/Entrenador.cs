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

        public delegate void NotificarPartidoLesionEventHandler(object source, HelpThePlayerEventArgs e);
        public event NotificarPartidoLesionEventHandler NotificarEmergencia;

        public Entrenador(string name, int edad, string nacion, int sueldo, int puntos_tactica)
            : base(name, edad, nacion, sueldo)
        {
            this.Puntos_tactica = puntos_tactica;
        }

        public int Puntos_tactica { get => puntos_tactica; set => puntos_tactica = value; }

        public void Cambiar_Jugador(Jugadores cambiar)
        {
            //Se cambia al jugador
        }

        public void Notificar_Lesion(object source, HelpThePlayerEventArgs e)
        {
            //Ver si se puede hacer eventos
            if(NotificarEmergencia != null)
            {
                NotificarEmergencia(this, new HelpThePlayerEventArgs() { player = e.player });
                Cambiar_Jugador(e.player); //REVISAR

            }
        }
    }
}
