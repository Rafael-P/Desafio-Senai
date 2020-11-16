using System;

namespace Desafio._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if(idade>=18){
                Console.WriteLine("Você pertence a categoria Sênior");
            }else if(idade>=14 && idade<=17){
                Console.WriteLine("Você pertence a categoria Juvenil B");    
            }else if(idade>=11 && idade<=13){
                Console.WriteLine("Você pertence a categoria Juvenil A");
            }else if(idade>=8 && idade<=10){
                Console.WriteLine("Você pertence a categoria Infantil B");
            }else if(idade>=5 && idade<=7){
                Console.WriteLine("Você pertence a categoria Infantil A");
            }else{
                Console.WriteLine("Você não tem idade suficiente");
            }

        }//FIM DO MAIN
    }
}
