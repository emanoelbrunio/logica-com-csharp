// using System;
// class TesteDoisProblemaSete {
//     static void Main(){
//         const string linha = "|-------------------------------------------------------------------------|";
        
//         Console.WriteLine(linha);
//         Console.Write("| Digite o valor presente: R$ ");
//         decimal valorPresente = Convert.ToDecimal(Console.ReadLine());

//         Console.Write("| Digite a taxa de juros ao mês: % ");
//         decimal taxaDeJuros = Convert.ToDecimal(Console.ReadLine());
        
//         Console.Write("| Digite a quantidade de meses: ");
//         int qtdDeMeses = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(linha);
//         for(int i = 1; i <= qtdDeMeses; i++){
            
//            decimal rendimento = (valorPresente * taxaDeJuros) / 100;
//            Console.WriteLine(linha);
//            Console.WriteLine($"| Mês: {i}");
//            Console.WriteLine($"| Valor presente: R$ {Math.Round(valorPresente, 2)}");
//            Console.WriteLine($"| Rendimento: R% {Math.Round(rendimento, 2)}");
//            valorPresente += rendimento;

//            Console.WriteLine($"| Valor presente + rendimento: R% {Math.Round(valorPresente, 2)}");
//            Console.WriteLine(linha);

//             if(i % 5 == 0){
//                 Console.WriteLine(linha);
//                 Console.WriteLine("| Você deseja sacar algum valor: ");
//                 Console.WriteLine("| 1 - Sim ");
//                 Console.WriteLine("| 2 - Não ");
//                 Console.Write("| Responda: ");
//                 int resposta = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine(linha);
//                 if(resposta == 1){
//                     decimal saque;
//                     do {
//                         Console.WriteLine(linha);
//                         Console.WriteLine($"| Valor antes do saque: R$ {Math.Round(valorPresente, 2)}");
//                         Console.Write("| Quanto você deseja sacar: R$");
//                         saque = Convert.ToDecimal(Console.ReadLine());
//                         Console.WriteLine(linha);

//                         if(saque > valorPresente){
//                             Console.WriteLine(linha);
//                             Console.WriteLine("| Valor não pode ser sacado, insira outro!");
//                             Console.WriteLine(linha);
//                         }
//                     } while(saque > valorPresente);

//                     valorPresente -= saque;
//                     Console.WriteLine(linha);
//                     Console.WriteLine($"| Valor sacado: R$ {Math.Round(saque, 2)}");
//                     Console.WriteLine($"| Valor depois do saque: R$ {Math.Round(valorPresente, 2)}");
//                     Console.WriteLine(linha);
//                 }
//             }
//         }

//         Console.WriteLine(linha);
//         Console.WriteLine($"| Saldo final: R% {Math.Round(valorPresente, 2)}");
//         Console.WriteLine(linha);
//     }
// }