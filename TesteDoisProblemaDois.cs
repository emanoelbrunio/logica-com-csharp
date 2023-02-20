// using System;
// class TesteDoisProblemaDois {
//     static void Main(){

//         decimal valorPresente = 3800;
//         decimal taxaJurosPerc = 1.25m;
//         int periodoMes = 6;

//         decimal rendLiquido;

//         decimal valorAtual = valorPresente;
//         decimal rendLiquidoTot = 0;
//         for(int i = 1; i <= periodoMes; i++){
           
//             rendLiquido = (valorPresente * taxaJurosPerc) / 100;
//             valorPresente += rendLiquido;
            
//             rendLiquidoTot += rendLiquido;
//             valorAtual += rendLiquidoTot;
//             Console.WriteLine($"Mês {i}");
//             Console.WriteLine($"Rendimento: {Math.Round(valorPresente, 2)}");
//             Console.WriteLine($"Rendimento liquido do mês: {Math.Round(rendLiquidoTot, 2)}");
//             Console.WriteLine($"Renda acumulada: {Math.Round(valorAtual, 2)}\n");

//         }

//         Console.WriteLine($"Renda acumulada no final: {Math.Round(valorAtual, 2)}");
//     }
// }
