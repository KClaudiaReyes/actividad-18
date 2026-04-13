global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
using System.Threading.Tasks;



 class Program
{

    static void Main(string[] args)
    {
        cuentaBancaria cuenta = new cuentaBancaria(5000);
        Console.WriteLine(cuenta.Saldo);
    }


         public class cuentaBancaria
    {
        private decimal saldo;
        public cuentaBancaria(decimal saldoInicial)
        {
            saldo = saldoInicial;
        }
        public string Saldo
        {
            get
            {
                return saldo > 0 ? "saldo dsisponible" : "saldo no disponible";
            }
        }
    }
}

   


