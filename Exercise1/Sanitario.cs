using System;
namespace Exercise1
{
    public class Sanitario : IPersonalLaboral
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public double Edad { get; set; }
        public double SueldoBase { get; set; }

        public Sanitario(string dni, string nombre, double edad, double sueldobase)
        {
            Dni = dni;
            Nombre = nombre;
            Edad = edad;
            SueldoBase = sueldobase;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("DNI: " + Dni);
            Console.WriteLine("Edad: "+ Edad);
            Console.WriteLine("Sueldo base: "+ SueldoBase);

        }

        public bool Jubilable()
        {
            if (Edad >= 65)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual double CalculaSueldo()
        {
            return SueldoBase;
        }

        
    }
}
