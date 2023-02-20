// using System;
// class TesteDoisProblemaOito{
//     static void Main(){
//         const string linha = "|--------------------------------------------------------------------------------------------------------|";
//         const string MES = "  MES  ";

//         const string cabecalho = $"|{MES}|";

//         Console.WriteLine(linha);
//         Console.Write("| Digite o valor presente: R$ ");
//         decimal valorPresente = Convert.ToDecimal(Console.ReadLine());

//         Console.Write("| Digite a taxa de juros ao mês: % ");
//         decimal taxaDeJuros = Convert.ToDecimal(Console.ReadLine());
        
//         Console.Write("| Digite a quantidade de meses: ");
//         int qtdDeMeses = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(linha);   

//         Console.WriteLine(linha);   
//         Console.WriteLine(cabecalho);   
        

//         for(int i = 1; i <= qtdDeMeses; i++){
//             decimal rendimento = (valorPresente * taxaDeJuros) / 100;
//             decimal saque = 0;
            
//             decimal saldoLiquido = rendimento + valorPresente;
//             decimal rendimentoRestante = saldoLiquido ;

//             Console.WriteLine(linha);

//             Console.WriteLine($"|   {i}   |  R$ {Math.Round(valorPresente, 2)}  |  {taxaDeJuros}%  |  R$ {Math.Round(rendimento, 2)}  |  -R${Math.Round(saque, 2)}  |  R${Math.Round(saldoLiquido, 2)}  |  R${Math.Round(rendimentoRestante, 2)}");
//             valorPresente += rendimento;
//             if(i % 5 == 0){
//                 Console.WriteLine(linha);
//                 Console.WriteLine("| Você deseja sacar algum valor: ");
//                 Console.WriteLine("| 1 - Sim ");
//                 Console.WriteLine("| 2 - Não ");
//                 Console.Write("| Responda: ");
//                 int resposta = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine(linha);
//                 if(resposta == 1){
                    
//                     do {
//                         Console.WriteLine(linha);
//                         Console.WriteLine($"| Valor antes do saque: R$ {Math.Round(saldoLiquido, 2)}");
//                         Console.Write("| Quanto você deseja sacar: R$");
//                         saque = Convert.ToDecimal(Console.ReadLine());
//                         Console.WriteLine(linha);

//                         if(saque > valorPresente){
//                             Console.WriteLine(linha);
//                             Console.WriteLine("| Valor não pode ser sacado, insira outro!");
//                             Console.WriteLine(linha);
//                         }
//                     } while(saque > valorPresente);
                    
//                     Console.WriteLine($"|   {i}   |  R$ {Math.Round(valorPresente-rendimento, 2)}  |  {taxaDeJuros}%  |  R$ {Math.Round(rendimento, 2)}  |  -R${Math.Round(saque, 2)}  |  R${Math.Round(saldoLiquido, 2)}  |  R${Math.Round(rendimentoRestante-saque, 2)}");

//                     valorPresente -= saque;
                    
//                     rendimentoRestante = valorPresente - saque;

//                     Console.WriteLine(linha);
//                     Console.WriteLine($"| Valor sacado: R$ {Math.Round(saque, 2)}");
//                     Console.WriteLine($"| Valor depois do saque: R$ {Math.Round(valorPresente, 2)}");
//                     Console.WriteLine(linha);
//                 }      
//             }
//             else {
//                 saque = 0;
//             }
            
//             Console.WriteLine(linha);  
//         }

//         Console.WriteLine(linha);
//     }
// }