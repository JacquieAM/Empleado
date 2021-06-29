using System;
using System.Collections.Generic;
using System.Text;

namespace Empleado
{
    class Empleado
    {
        /*Declara los datos miembros indicados y aplica el encapsulamiento utilizando los
        modificadores de acceso necesarios*/

        private double salarioMensual;
        private double bonoMensual;
        private double salarioAnual;
        private int numeroEmpleado;
        private String nombre;
        private String numeroTelefonico;
        private String correoElectronico;
        private static int contadorEmpleado;

        //constructor de un dato

        public Empleado(String nombre)
        {
            this.nombre = nombre;
        }

        //constructor de dos datos
        public Empleado(String nombre, double salarioMensual)
        {
            this.nombre = nombre;
            this.salarioMensual = salarioMensual;

        }

        //constructor de tres datos
        public Empleado(String nombre, double salarioMensual, double bonoMensual)
        {
            this.nombre = nombre;
            this.salarioMensual = salarioMensual;
            this.bonoMensual = bonoMensual;
        }

        //constructor que toma parametros y en base a esto asigna el salario y bono si es negativo convierte a 0
        public Empleado(double salarioMensual, double bonoMensual, String nombre, String numeroTelefonico, String correoElectronico)
        {
            this.nombre = nombre;
            this.numeroTelefonico = numeroTelefonico;
            this.correoElectronico = correoElectronico;
            //Incrementa el contador al crear un objeto nuevo
            Empleado.contadorEmpleado++;
            //Asigna el valor del contador al numeroEmpleado
            this.numeroEmpleado = Empleado.contadorEmpleado;
            //Si el salario mensual no es positivo, debe establecerse en 0.0
            if (salarioMensual < 0)
            {
                salarioMensual = 0;
            }
            else
            {
                this.salarioMensual = salarioMensual;
            }
            //Si el bono mensual no es positivo, debe establecerse en 0.0
            if (bonoMensual < 0)
            {
                bonoMensual = 0;
            }
            else
            {
                this.bonoMensual = bonoMensual;
            }
        }

        //propiedad para modificar salarioMensual
        public double SalarioMensual
        {
            get { return this.salarioMensual; }

            set { this.salarioMensual = salarioMensual; }
        }

        //propiedad para modificar bonoMensual
        public double BonoMensual
        {
            get { return this.bonoMensual; }

            set { this.bonoMensual = bonoMensual; }
        }

        //propiedad para obtener el salarioAnual
        public double SalarioAnual
        {
            get { return this.salarioAnual; }


        }

        //propiedad para obtener el numeroEmpleado
        public int NumeroEmpleado
        {
            get { return this.numeroEmpleado; }
        }

        //propiedad para obtener el nombre
        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = nombre; }
        }

        //propiedad para  obtener numeroTelefonico
        public String NumeroTelefonico
        {
            get { return this.numeroTelefonico; }
            set { this.numeroTelefonico = numeroTelefonico; }
        }

        //propiedad para obtener correoElectronico
        public String CorreoElectronico
        {
            get { return this.correoElectronico; }
            set { this.correoElectronico = correoElectronico; }
        }

        //Sobrecarga  de  metodos para asignarSalarioMensual
        //Metodo para asignar el salario mensual
        public void asignarSalarioMensual(string nombre, double salarioMensual)
        {
            this.nombre =nombre;
            this.salarioMensual = salarioMensual;


            //return this.salarioMensual;
        }
        //Metodo 2 para asignar el salario mensual
        public void asignarSalarioMensual( double salarioMensual)
        {
            this.nombre = nombre;
            this.salarioMensual = salarioMensual;
   
            //return this.salarioMensual;
        }

        //Metodo para asignar el salario mensual con el bono
        public void asignarSalarioMensual(string nombre, double salarioMensual, double bonoMensual)
        {
            this.nombre = nombre;
            this.salarioMensual = salarioMensual + bonoMensual;
  
            //return this.salarioMensual;
        }

        //Sobrecarga de metodos para asignarBonoMensual
        //Metodo para asignar el bono mensual
        public void asignarBonoMensual(double bonoMensual)
        {
            this.bonoMensual = bonoMensual;

            //return bonoMensual;
        }

        //Metodo para asignar el bono mensual 2
        public void asignarBonoMensual(string nombre, double salarioMensual, double bonoMensual)
        {
            this.nombre = nombre;
            this.salarioMensual = salarioMensual;
            this.bonoMensual = bonoMensual;



            //return bonoMensual;
        }

        //Método de aumentar el 10% de su salario 
        public double aumentarSalario(double salarioMensual)
        {
            this.salarioMensual = (salarioMensual * .10) + salarioMensual;
            return this.salarioMensual;

        }

        //El método para Mostrar el salario anual del empleado
        public double mostrarSalarioAnual(double salarioMensual, double bonoMensual, Boolean aumento)
        {
            if (aumento == true)
            {
                salarioMensual = aumentarSalario(salarioMensual);
                this.salarioAnual = (salarioMensual * 12) + (bonoMensual * 12);
                return this.salarioAnual;

            }
            else
            {
                this.salarioAnual = (salarioMensual * 12) + (bonoMensual * 12);
                return this.salarioAnual;
            }
            return this.salarioAnual;
        }


        //override
        public String toString()
        {
            return " \n Numero de Empleado: " + numeroEmpleado + "\n Nombre: "
            + nombre + " \n Telefono: " + numeroTelefonico + "\n Correo electronico: " + correoElectronico
            + "\n Bono: " + bonoMensual + "\n Salario Anual: " + salarioAnual;

        }

        //destructor
        ~Empleado()
        {

            this.salarioMensual = 0;
            this.bonoMensual = 0;
            this.salarioAnual = 0;
            this.numeroEmpleado = 0;
            this.nombre = null;
            this.numeroTelefonico = null;
            this.correoElectronico = null;

           // Console.WriteLine("El destructor ha sido llamado");

        }
    }
}
