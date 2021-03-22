using System;

namespace Pract._6_Ejercicio_1
{
    #region Detalles del Programa
    
    /* 1.   Crear una clase Persona que tenga como atributos el "cedula, nombre, apellido y la edad (definir las propiedades para poder acceder 
    a dichos atributos)". Definir como responsabilidad un método para mostrar ó imprimir. Crear una segunda clase Profesor que herede de la clase 
    Persona. Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo. Definir un objeto de la clase Persona y llamar a sus 
    métodos y propiedades. También crear un objeto de la clase Profesor y llamar a sus métodos y propiedades.*/
    #endregion
    
    public class Persona
    {
        private ulong cedula_a;
        private string nombre_a;
        private string apellido_a;
        private int edad_a;

        public ulong cedula
        {
            get { return cedula_a; }
            set { cedula_a = value; }
        }
        public string nombre
        {
            get { return nombre_a; }
            set { nombre_a = value; }
        }
        public string apellido
        {
            get { return apellido_a; }
            set { apellido_a = value; }
        }
        public int edad
        {
            get { return edad_a; }
            set { edad_a = value; }
        }
        public Persona(ulong pCedula, string pNombre, string pApellido, int pEdad)
        {
            cedula = pCedula;
            nombre = pNombre;
            apellido = pApellido;
            edad = pEdad;
        }
        class Profesor : Persona
        {
            public int sueldo_a;

            public int Sueldo
            {
                get { return sueldo_a; }
                set { sueldo_a = value; }
            }
            public Profesor(ulong pCedula, string pNombre, string pApellido, int pEdad, int pSueldo) : base(pCedula, pNombre, pApellido, pEdad)
            {
                Sueldo = pSueldo;
            }
        }
        static void Main(string[] args)
        {
            Persona aPersona = new Persona(40234154360, "Marcos", "Liberata", 17);
            Profesor aProfesor = new Profesor(40234160360, "Miguel Angel", "Cruz", 18, 76000);

            Console.WriteLine("\nClase Persona\n");
            Console.WriteLine("Cédula: {0}", aPersona.cedula);
            Console.WriteLine("Nombre: {0}", aPersona.nombre);
            Console.WriteLine("Apellido: {0}", aPersona.apellido);
            Console.WriteLine("Edad: {0}", aPersona.edad);
            Console.WriteLine("--------------------");
            Console.WriteLine("Clase Profesor\n");
            Console.WriteLine("Cédula: {0}", aProfesor.cedula);
            Console.WriteLine("Nombre: {0}", aProfesor.nombre);
            Console.WriteLine("Apellido: {0}", aProfesor.apellido);
            Console.WriteLine("Edad: {0}", aProfesor.edad);
            Console.WriteLine("Sueldo: {0}", aProfesor.Sueldo);

        }
    }
}


