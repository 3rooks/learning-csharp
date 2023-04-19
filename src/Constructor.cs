namespace learn_cs.src
{
    public class Constructor
    {
        private string nombre;
        private int edad;

        public Constructor(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}