using System;
using System.Collections.Generic;

namespace Deneme
{
    class PersonManager
    {
        List<Person> personList = new List<Person>();
        List<Product> basketList = new List<Product>();

        public void AddPerson(params Person[] persons)
        {
            foreach (Person person in persons)
            {
                personList.Add(person);
            }
        }

        public void AddBasket(Product products)
        {
            basketList.Add(products);
        }

        public void MyBasketList()
        {
            Console.WriteLine("---------MY BASKETS--------");
            foreach (Product item in basketList)
            {
                Console.WriteLine("Ürün adı : " + item.ProductName);
            }
        }
    }
}
