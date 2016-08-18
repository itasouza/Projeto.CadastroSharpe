using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var funcao = new banco();
                string nome, endereco;

                Console.WriteLine("Por favor, digite o nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Por favor, digite o endereço:");
                endereco = Console.ReadLine();

                funcao.cadastrar(nome, endereco);
                Console.WriteLine("Dados inseridos com sucesso!");

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }


    }
}
