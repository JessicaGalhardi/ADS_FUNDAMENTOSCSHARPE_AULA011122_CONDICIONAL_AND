using System;

namespace CondicionalAnd
{
    class CondicionalAnd
    {
        static void Main(string[] args)
        {
            try
            {
                //____________________________________________________________________________________________________________________________________
                //Recebendo inputs do usuário!
                
                Console.WriteLine("Por favor, digite o seu gênero: ");
                string genero = Console.ReadLine();

                Console.WriteLine("Por favor, digite a sua idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                //____________________________________________________________________________________________________________________________________
                //Usuário precisa ser Mulher e maior de idade para se inscrever em determinado programa!

                if (idade >= 18 && genero == "feminino")
                {
                    Console.WriteLine("Usuário(a) autorizado(a) a efetuar a inscrição.");

                }
                else
                {
                    Console.WriteLine("Usuário(a) não atende todas as condições para se inscrever.");
                }

                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao executar a aplicação!"+ ex);//Em caso de erro é exibida a mensagem junto com o erro apresentado.

            }
        }
    }
}
    

