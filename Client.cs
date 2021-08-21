using System;

namespace Project2
{
    public class Client : User
    {
        public Client (int id, string name, Address deliveryAddress, Address billingAddress, 
        string user, string password, DateTime birthDate)
        {
            base.id = id;
            base.name = name;
            base.deliveryAddress = deliveryAddress;
            base.billingAddress = billingAddress;
            base.user = user;
            base.password = password;
            base.birthDate = birthDate;
        }
    }
}