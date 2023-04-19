namespace learn_cs.src
{
    public partial class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }

    public partial class Person
    {
        public bool IsNameValid()
        {
            return !string.IsNullOrEmpty(name);
        }

        public bool IsAgeValid()
        {
            return age >= 0 && age <= 120;
        }
    }
}