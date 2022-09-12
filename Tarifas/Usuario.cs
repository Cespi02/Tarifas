using System;
using System.Collections.Generic;
using System.Text;

namespace Tarifas
{
    class Usuario
    {
        int nro_zona;
        string nombre;
        string calle;
        int nro_usuario;
        string tipo_usuario;
        int consumo;

        public Usuario(int nro_zona, string nombre, string calle, int nro_usuario, string tipo_usuario, int consumo)
        {
            this.Nro_zona = nro_zona;
            this.Nombre = nombre;
            this.Calle = calle;
            this.Nro_usuario = nro_usuario;
            this.Tipo_usuario = tipo_usuario;
            this.Consumo = consumo;
        }

        public int Nro_zona { get => nro_zona; set => nro_zona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Nro_usuario { get => nro_usuario; set => nro_usuario = value; }
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
        public int Consumo { get => consumo; set => consumo = value; }

        public bool superaConsumoMin()
        {
            if(Tipo_usuario == "P")
            {
                return Consumo > 400;
            }
            else
            {
                return Consumo > 1000;
            }
        }
    }
}
