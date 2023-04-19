namespace learn_cs.src
{
    public class IfElseSwitch
    {
        public void IfElseCase()
        {
            int age = 18;
            if (age >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }

        }

        public void SwitchCase()
        {
            string color = "rojo";
            switch (color)
            {
                case "rojo":
                    Console.WriteLine("El color es rojo");
                    break;
                case "azul":
                    Console.WriteLine("El color es azul");
                    break;
                case "verde":
                    Console.WriteLine("El color es verde");
                    break;
                default:
                    Console.WriteLine("El color es desconocido");
                    break;
            }

        }
    }
}