namespace Deneme
{
    class Customer : CustomerManager
    {
        public int Id { get; set; }
        public string fullName { get; set; }

        public Customer(int Id, string fullName)
        {
            this.Id = Id;
            this.fullName = fullName;
        }
    }
}
