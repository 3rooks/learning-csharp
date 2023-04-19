namespace learn_cs.src
{
    public class BaseClass
    {
        class Animal
        {
            public string Name { get; set; }

            public Animal(string name)
            {
                Name = name;
            }
        }

        class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
                // TODO
            }
        }


        class Animal2
        {
            public virtual void Speak()
            {
                Console.WriteLine("Hablo como un animal");
            }
        }

        class Dog2 : Animal2
        {
            public override void Speak()
            {
                base.Speak();
                Console.WriteLine("Ladrido de perro");
            }
        }

        class Animal3
        {
            public int Age { get; set; }
        }

        class Dog3 : Animal3
        {
            public void DisplayAge()
            {
                Console.WriteLine(base.Age);
            }
        }


    }
}