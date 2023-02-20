// using System;
// class TesteDoisProblemaSeis {
//     static void Main(){
//         const string linha = "|-------------------------------------------------------------------------|";
        
//         Console.WriteLine(linha);
//         Console.Write("| Digite o valor presente: R$ ");
//         decimal valorPresente = Convert.ToDecimal(Console.ReadLine());

//         Console.Write("| Digite a taxa de juros ao mês: ");
//         decimal taxaDeJuros = Convert.ToDecimal(Console.ReadLine());
        
//         Console.Write("| Digite a quantidade de meses: ");
//         int qtdDeMeses = Convert.ToInt32(Console.ReadLine());
        
//         Console.Write("| Digite a quantidade de dias extras (caso não tenha, digite 0): ");
//         int qtdDeDias = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(linha);

//         for(int i = 0; i < qtdDeMeses; i++){  
//             //considerando que o mes tem 30 dias 
//             qtdDeDias += 30;
//         }
        
//         decimal mesesFinal = Math.Round(Convert.ToDecimal(qtdDeDias) / 30, 2);

//         decimal saldoLiquido = valorPresente * Convert.ToDecimal(Math.Pow( Convert.ToDouble(1+taxaDeJuros/100), Convert.ToDouble(mesesFinal)));

//         Console.WriteLine(linha);
//         Console.WriteLine($"| Saldo final: R% {Math.Round(saldoLiquido, 2)}");
//         Console.WriteLine(linha);
//     }
// }