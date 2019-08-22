using System;
namespace Exercise1
{
    public class Enfermero : Sanitario
    {
        public int Puesto { get; set; }

        public Enfermero(int puesto, string dni, string nombre, double edad, double sueldobase):base(dni,nombre,edad,sueldobase)
        {
            Puesto = puesto;
        }

     

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("************************");
            Console.WriteLine("Puesto: " + Puesto);
           

        }

        public bool Jubilable()
        {
            throw new NotImplementedException();
        }

        public double CalculaSueldo()
        {
            throw new NotImplementedException();
        }
    }
}
