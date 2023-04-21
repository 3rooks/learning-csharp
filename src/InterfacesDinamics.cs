namespace learn_cs.src
{
    public class InterfacesDinamics
    {
        public interface IRepository<T> where T : IEntity
        {
            T GetById(int id);
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
        }

        public interface IEntity
        {
            int Id { get; set; }
            string Name { get; set; }
        }

        public class Customer : IEntity
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
            public string Email { get; set; } = "";
        }

        public class CustomerRepository : IRepository<Customer>
        {
            private readonly List<Customer> customers = new List<Customer>();

            public Customer GetById(int id)
            {
                var customer = customers.FirstOrDefault(c => c.Id == id);
                if (customer != null)
                {
                    return customer;
                }
                else
                {
                    throw new ArgumentException($"No customer found with id: {id}", nameof(id));
                }
            }

            public void Add(Customer customer)
            {
                customers.Add(customer);
            }

            public void Update(Customer customer)
            {
                var index = customers.FindIndex(c => c.Id == customer.Id);
                if (index >= 0)
                {
                    customers[index] = customer;
                }
            }

            public void Delete(Customer customer)
            {
                customers.Remove(customer);
            }
        }

    }
}