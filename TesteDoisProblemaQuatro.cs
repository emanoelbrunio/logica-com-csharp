// using System;
// class TesteDoisProblemaQuatro {
//     static void Main() {
//         const string linha = "|--------------------------------------------|";
//         Console.WriteLine(linha);
//         Console.Write("| Digite o valor presente: R$ ");
//         decimal valorPresente = Convert.ToDecimal(Console.ReadLine());

//         Console.Write("| Digite a quantidade de meses: ");
//         int qtdMeses = Convert.ToInt32(Console.ReadLine());

//         Console.Write("| Digite a taxa de juros ao mês: % ");
//         decimal taxaDeJuros = Convert.ToDecimal(Console.ReadLine());

//         decimal saldo = valorPresente;

//         for(int i = 0, j = 1; i < qtdMeses; i++, j++){
//             decimal rendaLiquida = (saldo * taxaDeJuros) / 100;
//             saldo += rendaLiquida;
//             Console.WriteLine(linha);
//             Console.WriteLine($"| Mês {i+1}");
//             Console.WriteLine(linha);
//             Console.WriteLine($"| Renda liquida: R${Math.Round(rendaLiquida, 2)}");
//             Console.WriteLine($"| Seu saldo atual: R$ {Math.Round(saldo, 2)}");
//             Console.WriteLine(linha);
//             if(j % 5 == 0){
//                 Console.WriteLine(linha);
//                 Console.WriteLine("| Você deseja resgatar: ");
//                 Console.WriteLine("| 1 - Sim ");
//                 Console.WriteLine("| 2 - Não ");
//                 Console.Write("| Digite: ");
//                 int verificarResgate = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine(linha);

//                 if (verificarResgate == 1) {
//                     decimal saque;
//                     do {
//                         Console.WriteLine($"| Seu saldo antes do saque: R$ {Math.Round(saldo, 2)}");
//                         Console.WriteLine(linha);
//                         Console.Write("| Digite quanto você quer sacar: R$");
//                         saque = Convert.ToDecimal(Console.ReadLine());
//                         Console.WriteLine(linha);
//                         if(saque > saldo){
//                             Console.WriteLine(linha);
//                             Console.WriteLine("| Valor indisponível, tente novamente!");
//                         }
//                     } while(saque > saldo);

//                     saldo -= saque;
//                     Console.WriteLine();
//                     Console.WriteLine(linha);
//                     Console.WriteLine($"| Você sacou: R$ {Math.Round(saque, 2)}");
//                     Console.WriteLine($"| Seu saldo após o saque: R$ {Math.Round(saldo, 2)}");
//                     Console.WriteLine(linha);
//                     Console.WriteLine();
//                 }
//             }
//             else {
//                 Console.WriteLine($"| Seu saldo atual: R$ {Math.Round(saldo, 2)}");
//                 Console.WriteLine(linha);
//             }
//         } 
//         Console.WriteLine(linha);
//         Console.WriteLine($"| Seu saldo final: R$ {Math.Round(saldo, 2)}");
//         Console.WriteLine(linha);

//     }
// }