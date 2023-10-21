using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BllJugador
    {
        MppJugador mppJugador;
        public void AltaJugador(BeJugador jugador)
        {
            mppJugador.AltaJugador(jugador);
        }
        public void BajaJugador(BeJugador jugador)
        {
            mppJugador.BajaJugador(jugador);
        }
        public void ModificarJugador(BeJugador jugador)
        {
            mppJugador.ModificarJugador(jugador);   
        }
        public List<BeJugador> ListarJugador()
        {
            mppJugador = new MppJugador();
            return mppJugador.ListarJugador();
        }




    }
}
