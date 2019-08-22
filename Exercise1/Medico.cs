using System;
namespace Exercise1
{
    public class Medico : Sanitario
    {
        public string Especialidad { get; set; }
        public string NumeroPacientes { get; set; }

        public Medico(string especialidad, string numeroPacientes, string dni, string nombre, double edad, double  sueldobase):base(dni,nombre,edad,sueldobase)
        {
            Especialidad = especialidad;
            NumeroPacientes = numeroPacientes;
        }

      

        public override void Mostrar() 
        {
            base.Mostrar();
            Console.WriteLine("**********************************");
            Console.WriteLine("Especialidad: " + Especialidad);
            Console.WriteLine("Numero de Pacientes: " + NumeroPacientes);
        }

        public bool Jubilable()
        {
            throw new NotImplementedException();
        }

        public override double CalculaSueldo(double sueldo)
        {
            const int UCI = 0;
            if (puesto == UCI)
            {

                return base.CalculaSueldo() + 200;
            }
            else
            {
                return base.CalculaSueldo();
            }
        }

        public override double CalculaSueldo()
        {
            throw new NotImplementedException();
        }
    }
}
