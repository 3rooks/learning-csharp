namespace learn_cs.src
{
    public class Constructor
    {
        private string name;
        private int age;

        public Constructor(string nombre, int edad)
        {
            this.name = nombre;
            this.age = edad;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}