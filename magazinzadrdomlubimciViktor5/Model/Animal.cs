using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazinzadrdomlubimciViktor5.Model
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Price { get; set; }
        public int Age { get; set; }
        public int TypeId { get; set; }
        public AnimalsTypes AnimalType { get; set; } //connection with table
        public Animal(string name, string discription, int price, int age, int typeId)
        {
            Name = name;
            Discription = discription;
            Price = price;
            Age = age;
            TypeId = typeId;
        }
    }
    }

