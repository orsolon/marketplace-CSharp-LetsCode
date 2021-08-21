using System;

namespace Project2
{
    public class User : ISeller, IClient
    {
        public int id {get; set;}
        public bool isSeller {get; set;} = false;
        public bool isCliente {get; set;} = false;
        public string name {get; set;}
        public Address deliveryAddress {get; set;}
        public Address billingAddress {get; set;}
        public string username {get; set;}

        public string password {get; set;}
        public DateTime birthDate {get; set;}
        

        public override string ToString()
        {
            return $"{name}";
        }
    }
}