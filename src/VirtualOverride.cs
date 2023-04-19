namespace learn_cs.src
{
    public class VirtualOverride
    {
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("animal sound");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("dog sound");
            }
        }
    }
}