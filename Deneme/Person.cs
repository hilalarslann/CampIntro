namespace Deneme
{
    class Person : PersonManager
    {
        public int Id { get; set; }
        public string fullName { get; set; }
    }

    class Customer : Person
    {
        public int CustomerId { get; set; }
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeId { get; set; }
    }
}
