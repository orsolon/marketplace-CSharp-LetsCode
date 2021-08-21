using System;
using System.Globalization;

namespace Project2
{
    public class Create
    {
        public static void CreateUser()

        {

            var name = ReadName();
            var username = ReadUser();
            var password = ReadPassword();
            var birthDate = ReadBirthDate();
            var deliveryAddress = ReadAddress();
            var billingAddress = ReadBillingAddress(deliveryAddress);

            User user = new User()
            {
                id = DataBase.Users.Count + 1,
                name = name,
                username = username,
                password = password,
                birthDate = birthDate,
                deliveryAddress = deliveryAddress,
                billingAddress = billingAddress

            };

            DataBase.Users.Add(user);

        }

        private static string ReadName()
        {
            Console.WriteLine("Digite o nome do usuário:");
            return Console.ReadLine();
        }

        private static string ReadUser()
        {
            Console.WriteLine("Digite o Username:");
            return Console.ReadLine();
        }

        private static string ReadPassword()
        {
            Console.WriteLine("Digite a senha:");
            return Console.ReadLine();
        }

        private static DateTime ReadBirthDate()
        {
            Console.WriteLine("Digite sua data de nascimento: (dd/mm/aaaa)");
            var entrada =  Console.ReadLine();
            return Convert.ToDateTime(entrada, new CultureInfo("pt-BR"));
        } 

        private static Address ReadAddress()
        {
           Console.WriteLine("Digite o endereço:");
            var address =  Console.ReadLine();

            Console.WriteLine("Digite o segundo endereço:");
            var secondAddress =  Console.ReadLine();

            Console.WriteLine("Digite o numero:");
            int.TryParse(Console.ReadLine(), out var number);

            Console.WriteLine("Digite o CEP:");
            var zip =  Console.ReadLine();

            Console.WriteLine("Digite a cidade:");
            var city =  Console.ReadLine();

            Console.WriteLine("Digite o estado:");
            var state =  Console.ReadLine();

            Console.WriteLine("Digite o país:");
            var country =  Console.ReadLine();

            return new Address()
            {
                address = address,
                secondAddress = secondAddress, 
                number = number,
                zipCode = zip,
                city = city,
                state = state, 
                country = country

            };
        } 

        private static Address ReadBillingAddress(Address deliveryAddress)
        {
             Console.WriteLine("O Endereço de cobrança é o mesmo que o endereço de entrega?");
                Console.WriteLine(deliveryAddress);

              Console.WriteLine("Digite S para sim, Digite N para não");
              var option = Console.ReadLine();

              return option == "S"?  deliveryAddress : ReadAddress();

        }
    }
}