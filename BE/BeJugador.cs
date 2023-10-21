using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BeJugador
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}
		private string usuario;

		public string Usuario
		{
			get { return usuario; }
			set { usuario = value; }
		}

		private int puntos;

		public int Puntos
		{
			get { return puntos; }
			set { puntos = value; }
		}



	}
}
