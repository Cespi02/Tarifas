using System;
using System.Collections.Generic;
using System.Text;

namespace Tarifas
{
    class Empresa
    {
        List<Usuario> usuarios;
        private void ReservarEspacio()
        {
            usuarios = new List<Usuario>();
        }
        public Empresa()
        {
            ReservarEspacio();
        }
        public void AgresarUsario(int nro_zona, string nombre, string calle, int nro_usuario, string tipo_usuario, int consumo)
        {
            Usuario usuario;
            usuario = new Usuario(nro_zona, nombre, calle, nro_usuario, tipo_usuario, consumo);
            usuarios.Add(usuario);
        }
        public void UsuariosQueSuperan()
        {
            for(int i = 0; i< 3; i++)
            {
                for(int z=0; z < usuarios.Count; z++)
                {
                    if(usuarios[z].Nro_zona == i && usuarios[z].superaConsumoMin())
                    {
                        Console.WriteLine("El usuario {0} de la Zona {1} supera el limite de consumo minimo",usuarios[z].Nombre, i);
                    }
                }
            }
        }
        public void ConsumoUsuarioP()
        {
             
            for (int i = 0; i<3; i++)
            {
                int prom = 0;
                int cont = 0;
                for (int z=0; z < usuarios.Count; z++)
                {
                    if (usuarios[z].Nro_zona == i+1 && usuarios[z].Tipo_usuario == "P")
                    {
                        prom = prom + usuarios[z].Consumo;
                        cont++;
                    }
                }
                prom = prom / cont;
                Console.WriteLine("En la zona {0} el consumo promedio de las particulares es {1}", i+1, prom);
            }
        }
        public void ConsumoMaxComercial()
        {
            int max = 0, pos = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < usuarios.Count; z++)
                {
                    if (usuarios[z].Nro_zona == i && usuarios[z].Tipo_usuario == "C")
                    {
                        if (max > usuarios[z].Consumo)
                        {
                            max = usuarios[z].Consumo;
                        }
                        else
                        {
                            pos = z;
                        }
                    }
                }
            }
            Console.WriteLine("la direccion del usuario comercial q mas consumio es {0}", usuarios[pos].Calle);
        }

        public void TotalFacyUsMin()
        {
            int total= 0, cont= 0, cont2 =0;

            for(int i = 0; i<usuarios.Count; i++)
            {
                if(usuarios[i].superaConsumoMin() == false && usuarios[i].Tipo_usuario == "P")
                {
                    cont++;
                }
                if (usuarios[i].superaConsumoMin() == false && usuarios[i].Tipo_usuario == "C")
                {
                    cont2++;
                }
                total = total + usuarios[i].Consumo;
            }
            Console.WriteLine(" El total Facturado fue {0}", total);
            Console.WriteLine("La cantidad de usuarios comerciales que abonan el minimo son {0}, y particulares {1}", cont2, cont);
        }
        
    }
}
