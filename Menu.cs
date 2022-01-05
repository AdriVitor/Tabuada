using System;

namespace Tabuada
{
    class Menu
    {
        public static void Executando(){
            Console.Clear();

            Console.WriteLine("Olá, Seja Bem-Vindo(a) a Tabuada");
            Console.WriteLine("");
            Console.WriteLine("Digite um número: ");
            
            try{
                var num = double.Parse(Console.ReadLine());

                Console.Clear();

                for(int i = 1; i <= 10; i++){  
                    var resultado = num * i;
                    Console.WriteLine($"{num} X {i} = {resultado.ToString("F")}");
                }
            }
            catch{
                Console.WriteLine("");
                Console.WriteLine("Informe apenas números");
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Digite 1 para voltar ao Menu: ");
            Console.WriteLine("Digite 0 para sair do programa:");

            var escolha = int.Parse(Console.ReadLine());

            if((escolha != 1) && (escolha != 0)){
                Console.Clear();
                Console.WriteLine("Por favor, digite os numeros corretos");
                Console.WriteLine("Pressione qualquer tecla para encerrar o programa");
                Console.ReadKey();
            }

            Escolhas(escolha);
        }

        public static void Escolhas(int escolha){
            
             switch(escolha){
                 case 1: Menu.Executando(); break;
                 case 0: Environment.Exit(0); break;
                default: Environment.Exit(0); break;
             }
             
                
        }
    
    }

    
}