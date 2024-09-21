using System;

namespace Program2
{
    //Tipos de datos
    //int, long, float, double, decimal, string, char, bool
    class Program2
    {
        static void Main(string [] args)
        {
            int edad;
            edad = 28;//Admite hasta 9 valores
            Console.WriteLine("Edad (Valor int): " + edad);

            long NumeroCuenta;
            NumeroCuenta = 28379187635;//Admite hasta 19 valores
            Console.WriteLine("Cuenta: " + NumeroCuenta);

            float peso;
            peso = 58.32332f;//Solo tomará 5 decimales, debe llevar "f"
            Console.WriteLine("Peso: " + peso);

            double Altura;
            Altura = 1.8901;//Tomará hasta 9 decimales
            Console.WriteLine("Dinero: " + Altura);

            decimal Dinero;
            Dinero = 19928767312.324341321321M;//Tomará hasta 12 decimales, debe llevar "M"
            Console.WriteLine("Dinero: " + Dinero);

            string Nombre;
            Nombre = "Pablo";//Tipo String debe ir entre comillas
            Console.WriteLine("Nombre: " + Nombre);

            char Letra;
            Letra = 'A';//Unicamente admite 1 simbolo
            Console.WriteLine("Letra: " + Letra);

            bool MayorEdad;
            MayorEdad = true;//True para verdadero False para falso
            Console.WriteLine("Es mayor de edad: " + MayorEdad);
        }
    }
}