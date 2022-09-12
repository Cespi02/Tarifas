using System;

namespace Tarifas
{
    /*
     Una empresa de electricidad tiene que realizar el calculo de gastos de los clientes/usuarios, en 3 diferentes zonas en las que opera.
    Hay 2 tipos de usuarios, particulares y comerciales.
    Los usuarios particulares tienen como consumo minimo 400, mientras que los comerciales lo tienen en 1000.
    Mostrar por pantalla los usuarios que superan el consumo mínimo, el consumo promedio de los usuarios particulares en cada zona, la direccion del usuario comercial que mas consumió,
    el total facturado por la empresa y cantidad de usuarios particulares y comerciales que consumen el minimo.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();

            empresa.AgresarUsario(1,"Martin", "9 de Julio", 1, "P", 2000);
            empresa.AgresarUsario(2, "Juan", "Calchaqui", 2, "C", 5000);
            empresa.AgresarUsario(3, "Jose", "craviotto", 3, "P", 100);
            empresa.AgresarUsario(1, "Maria", "9 de Julio", 4, "C", 100);
            empresa.AgresarUsario(2, "julieta", "9 de Julio", 5, "P", 1500);


            empresa.UsuariosQueSuperan();
            empresa.ConsumoUsuarioP();
            empresa.ConsumoMaxComercial();
            empresa.TotalFacyUsMin();
        }
    }
}
