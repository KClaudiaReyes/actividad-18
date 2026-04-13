class Program
{
    static void Main(string[] args)
    {
        Empleado empleado = new Empleado();
        Console.WriteLine(empleado.Salario);
    }

    public class Empleado
    {
        private decimal salario = 2000;

        public decimal Salario
        {
            get { return salario; }
            set
            {
                if (value > 0)
                    salario = value;
            }


        }
    }
}
