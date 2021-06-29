using System;

namespace Empleado
{
    class Program
    {
        static void Main(string[] args)
        {
            //double salarioMensual, double bonoMensual,String nombre, String numeroTelefonico, String correoElectronico


            Empleado empleado1 = new Empleado(10000, -500, "Jacqueline", "123456789", "jacquelinem@un.com");
            Console.WriteLine("\nDatos del empleado antes de aumentar el salario y antes de calcular el salario anual");
            Console.WriteLine("Empleado1: " + empleado1.toString());
            Console.WriteLine(" Salario Mensual: " + empleado1.SalarioMensual);
            empleado1.aumentarSalario(10000);
            empleado1.mostrarSalarioAnual(10000, 500, true);
            Console.WriteLine("\nDatos del empleado despues de aumentar el 10% del salario y de calcular  el salario anual ");
            Console.WriteLine("Empleado1: " + empleado1.toString());
            Console.WriteLine(" Salario Mensual: " + empleado1.SalarioMensual);

            Empleado empleado2 = new Empleado(8000, 300, "Juan", "103456799", "juan@un.com");
            Console.WriteLine("\nDatos del empleado antes de aumentar el salario y antes de calcular el salario anual");
            Console.WriteLine("Empleado2: " + empleado2.toString());
            Console.WriteLine(" Salario Mensual: " + empleado2.SalarioMensual);
            empleado2.aumentarSalario(8000);
            empleado2.mostrarSalarioAnual(8000, 300, true);
            Console.WriteLine("\nDatos del empleado despues de aumentar el 10% del salario y de calcular  el salario anual ");
            Console.WriteLine("Empleado2: " + empleado2.toString());
            Console.WriteLine(" Salario Mensual: " + empleado2.SalarioMensual);

            Console.WriteLine("\nEn este ejemplo (empleado3) se crea un objeto utilizando el constructor con 1 dato: nombre");

            Empleado empleado3 = new Empleado("Jacquie");
            Console.WriteLine("\nEmpleado3: " + empleado3.Nombre);

            Console.WriteLine("\nEn este ejemplo (empleado4) se crea un objeto utilizando el constructor con 2 datos: nombre y salario");
            Console.WriteLine("\nSe aplica la sobrecarga de metodos del metodo asignarSalarioMensual ");

            Empleado empleado4 = new Empleado("Darla", 11000);
            Console.WriteLine("\nEmpleado4: " + "\nNombre: " + empleado4.Nombre + "\nSalario Mensual: " + empleado4.SalarioMensual);
            empleado4.asignarSalarioMensual("Sara", 9000);
            Console.WriteLine("\nEmpleado4:  " + " Cambio de nombre y de salario: " );
            Console.WriteLine("\nEmpleado4: " + "\nNombre: " + empleado4.Nombre + "\nSalario Mensual: " + empleado4.SalarioMensual);
            Console.WriteLine("\nEmpleado4: " + "Cambio/ asignar salario" );
            empleado4.asignarSalarioMensual(9500);
            Console.WriteLine("\nEmpleado4: " + "\nNombre: " + empleado4.Nombre + "\nSalario Mensual: " + empleado4.SalarioMensual);

            Console.WriteLine("\nEn este ejemplo (empleado5) se crea un objeto utilizando el constructor con 3 datos: nombre, " +
                "salario mensual y bono mensual");
            Console.WriteLine("\nSe aplica la sobrecarga de metodos del metodo asignarSalarioMensual ");

            Empleado empleado5 = new Empleado("Jose", 11500, 325);
            Console.WriteLine("\nEmpleado5: " + "\n Nombre: " + empleado5.Nombre + "\nSalario Mensual: " + empleado5.SalarioMensual
                + "\nBono Mensual: " + empleado5.BonoMensual);
            Console.WriteLine("\nEmpleado5: " + "Cambio de salario");
            empleado5.asignarSalarioMensual(11000);
            Console.WriteLine("\nEmpleado5: " + "\n Nombre: " + empleado5.Nombre + "\nSalario Mensual: " + empleado5.SalarioMensual
               + "\nBono Mensual: " + empleado5.BonoMensual);
            empleado5.asignarSalarioMensual("Carlos", 12000);
            Console.WriteLine("\nEmpleado5: " + " Cambio de nombre y de salario: " );
            Console.WriteLine("\nEmpleado5: " + "\n Nombre: " + empleado5.Nombre + "\nSalario Mensual: " + empleado5.SalarioMensual
               + "\nBono Mensual: " + empleado5.BonoMensual);
            Console.WriteLine("\nEmpleado5: " + " Cambio de nombre, de salario y asigna bono mensual : ");
            empleado5.asignarSalarioMensual("Joaquin", 12500, 500);
            Console.WriteLine("\nEmpleado5: " + "\n Nombre: " + empleado5.Nombre + "\nSalario Mensual: " + empleado5.SalarioMensual
               + "\nBono Mensual: " + empleado5.BonoMensual);
            Console.WriteLine("\nEmpleado5: " + "Cambio de bono ");
            empleado5.asignarBonoMensual(700);
            Console.WriteLine("\nEmpleado5: " + "\n Nombre: " + empleado5.Nombre + "\nSalario Mensual: " + empleado5.SalarioMensual
               + "\nBono Mensual: " + empleado5.BonoMensual);
            Console.WriteLine("\nEmpleado5: " + "Se utiliza el constructor para asignar nombre, salario mensual y bono");
            empleado5.asignarBonoMensual("Joaquin", 15000, 100);
            Console.WriteLine("\nEmpleado5: " + "\n Nombre: " + empleado5.Nombre + "\nSalario Mensual: " + empleado5.SalarioMensual
               + "\nBono Mensual: " + empleado5.BonoMensual);
        }
    }
}
