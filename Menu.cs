using System;

namespace Project2
{
    public class Menu
    {
        public string GeneralMenu() 
        {
            Console.WriteLine("Bem vindo ao marketplace");
            Console.WriteLine("Digite o número da opção desejada: ");
            Console.WriteLine("1 - Cadastrar Novo Usuário");
            Console.WriteLine("1 - Cadastrar Novo Vendedor");
            Console.WriteLine("1 - Cadastrar Novo Cliente");
            Console.WriteLine("1 - Buscar Usuário");
            Console.WriteLine("1 - Buscar Vendedor");
            Console.WriteLine("1 - Buscar Cliente");
            Console.WriteLine("1 - Atualizar dados Usuário");
            Console.WriteLine("1 - Atualizar dados Vendedor");
            Console.WriteLine("1 - Atualizar dados Cliente");
            Console.WriteLine("1 - Deletar dados Usuário");
            Console.WriteLine("1 - Deletar dados Vendedor");
            Console.WriteLine("1 - Deletar dados Cliente");
            Console.WriteLine("1 - Sair");
            Console.WriteLine("Opção");
            return Console.ReadLine();    
            
        }

        public void Option(int _option)
        {
            switch (_option)
            {
               case 1:
                    Console.WriteLine("Caso 01");
                    break;
                case 2:
                    Console.WriteLine("Caso 02");
                    break;
                case 3:
                    Console.WriteLine("Caso 03");
                    break;
                case 4:
                    Console.WriteLine("Caso 04");
                    break;
                case 5:
                    Console.WriteLine("Caso 05");
                    break;
                case 6:
                    Console.WriteLine("Caso 06");
                    break;
                case 7:
                    Console.WriteLine("Caso 07");
                    break;
                case 8:
                    Console.WriteLine("Caso 08");
                    break;
                case 9:
                    Console.WriteLine("Caso 09");
                    break;
                case 10:
                    Console.WriteLine("Caso 10");
                    break;
                case 11:
                    Console.WriteLine("Caso 11");
                    break;
                case 12:
                    Console.WriteLine("Caso 12");
                    break;
                case 13:
                    Console.WriteLine("Caso 13");
                    break;
                default:
                    Console.WriteLine("Opção Inválida, tente novamente");
                    GeneralMenuOption();
                    break;
            }
        }

        public void GeneralMenuOption() {
            string _option = GeneralMenu();
            int _optionInt;
            bool _optionToInt = Int32.TryParse(_option, out _optionInt);
            if (_optionToInt)
                Option(_optionInt);
            else
                Option(0);
        }


    }
}