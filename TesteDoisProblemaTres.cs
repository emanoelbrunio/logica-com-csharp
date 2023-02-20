// using System;
// class TesteDoisProblemaTres {
//     //problema 3
//     static void Main()
//     {
//        Console.Write("Digite o valor do presente: ");
//        decimal valorPresente = Convert.ToDecimal(Console.ReadLine());

//        Console.Write("Digite o valor da taxa de juros: ");
//        decimal taxaDeJuros = Convert.ToDecimal(Console.ReadLine());

//        Console.Write("Digite a quantidade de anos: ");
//        decimal periodoAnos = Convert.ToDecimal(Console.ReadLine());
        
//        decimal rendLiquido;
        
//        for (int i = 1; i <= periodoAnos; i++) {

//            rendLiquido = (valorPresente * taxaDeJuros) / 100;
//            valorPresente += rendLiquido;

//            Console.WriteLine($"Ano {i}");
//            Console.WriteLine($"Renda: {Math.Round(valorPresente, 2)}\n");

//        }
//        Console.WriteLine($"Renda final: R${Math.Round(valorPresente, 2)}\n");

//     }
// }
