class Program
{
    static void Main(string[] args)
    {
        usuario user = new usuario();
        Console.WriteLine(user.paass);
    }

    public class usuario
    {
        private string password = "jdg545re";

        public string paass
        {

            get { if (password.Length >= 8)
                    return "********";
                else return " contraseña insegura"; }
            set { password = value; }
        }
    }
}