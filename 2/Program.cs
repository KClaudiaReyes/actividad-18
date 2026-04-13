class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();

        Console.WriteLine(estudiante.edad);
    }


    public class Estudiante
    {
        private int Edad;

        public int edad
        {
           
           get {  return Edad; }
            set
            {
                if (value > 0 && value < 100)
                    Edad = value;

            }

        }
    }
}
