using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Class // Абстрактный класс
    {
        public string NameUser { get; set; }
        public string RoleUser { get; set; }
        

        public Class(string name, string role)
        {
            NameUser = name;
            RoleUser = role;
        }
    }

    class User: Class // наследование абстрактного класса
    {
        public User(string name, string role):base(name, role) //для доступа к членам базового класса
        {
        }
    }     


    class Client : User // наследование класса наследника
    {
        public float Price { get; set; }
        public Client(string name, string role, float price) :base(name, role) //для доступа к членам базового класса
        {
            Price = price;

        }

    }
    class Manager : Client // наследование класса предыдущего наследника
    {
        public float Balance { get; set; }
        public Manager(string name, string role, float price, float balance) :base(name, role, price) //для доступа к членам базового класса
        {
            Balance = balance;
        }

    }
    class Admin : Manager // наследование класса предыдущего наследника
    {
        public float Cost { get; set; }
        public Admin(string name, string role, float price, float balance, float cost) :base(name, role, price, balance) //для доступа к членам базового класса
        {
            Cost = cost;
        }
    }
}