// using System;

// class TesteDoisProblemaCinco {
//     static void Main(){
//         const string linha = "|----------------------------------------------------------------------|";
        
//         Console.WriteLine(linha);
//         Console.Write("| A Digite o valor que você quer alcançar no futuro: R$ ");
//         decimal valorFuturo = Convert.ToDecimal(Console.ReadLine());
//         Console.WriteLine(linha);
        
//         Console.Write($"| Digite em quantos anos você quer alcançar o valor de R$ {Math.Round(valorFuturo, 2)}: ");
//         decimal qtdAnos = Convert.ToDecimal(Console.ReadLine());
//         Console.WriteLine(linha);

//         Console.Write("| Digite a taxa de juros (ao ano) que deseja aplicar: % ");
//         decimal taxaDeJuros = Convert.ToDecimal(Console.ReadLine());

//         Console.WriteLine(linha);

//         decimal valorPresente = valorFuturo / Convert.ToDecimal( Math.Pow( Convert.ToDouble(1 + taxaDeJuros/100), Convert.ToDouble(qtdAnos)));


//         Console.WriteLine(linha);
//         Console.WriteLine($"| Valor presente: R$ {Math.Round(valorPresente, 2)}");
//         Console.WriteLine(linha);

//     }
// }