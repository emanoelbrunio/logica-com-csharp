using System;

class Conta {
    decimal valorPresente;
    decimal taxaDeJuros;
    decimal rendimento;
    decimal saque;
    decimal saldoLiquido;
    decimal rendimentoRestante;

    public Conta(decimal valorPresente, decimal taxaDeJuros, decimal rendimento, decimal saque, decimal saldoLiquido,decimal rendimentoRestante){
        this.valorPresente = valorPresente;
        this.taxaDeJuros = taxaDeJuros;
        this.rendimento = rendimento;
        this.saque = saque;
        this.saldoLiquido = saldoLiquido;
        this.rendimentoRestante = rendimentoRestante;
    }

    public override string ToString(){
        return $"R$ {Math.Round(this.valorPresente, 2).ToString("0000.00")}  |  {this.taxaDeJuros}%  |  R$ {Math.Round(this.rendimento, 2).ToString("0000.00")}  |  -R${Math.Round(this.saque, 2).ToString("0000.00")}  |  R${Math.Round(this.saldoLiquido, 2).ToString("0000.00")}  |  R${Math.Round(this.rendimentoRestante, 2).ToString("0000.00")}";
    }
}
class TestePooProblemaOito{
    static void Main(){
        
        const string linha = "|--------------------------------------------------------------------------------------------------------|";

        const string cabecalho = $"|   MES  |  VAL. PRESE. | TAXA |     RENDI.   |     SAQUE    |   SAL. LIQ. |  REN. RESTA.  " ;

        Console.WriteLine(linha);
        Console.Write("| Digite o valor presente: R$ ");
        decimal valorPresente = Convert.ToDecimal(Console.ReadLine());

        Console.Write("| Digite a taxa de juros ao mês: % ");
        decimal taxaDeJuros = Convert.ToDecimal(Console.ReadLine());
        
        Console.Write("| Digite a quantidade de meses: ");
        int qtdDeMeses = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(linha);   

        Conta[] conta = new Conta[qtdDeMeses];

        for(int i = 1; i <= qtdDeMeses; i++){
            decimal rendimento = (valorPresente * taxaDeJuros) / 100;
            decimal saque = 0;
            
            decimal saldoLiquido = rendimento + valorPresente;
            decimal rendimentoRestante = saldoLiquido ;

            valorPresente += rendimento;
            if(i % 5 == 0){
                Console.WriteLine(linha);
                Console.WriteLine("| Chegou o mês de saque! ");
                Console.WriteLine($"| Valor tem disponível para saque: R$ {Math.Round(saldoLiquido, 2)}");
                Console.WriteLine(linha);
                Console.WriteLine("| Você deseja sacar algum valor: ");
                Console.WriteLine("| 1 - Sim ");
                Console.WriteLine("| 2 - Não ");
                Console.Write("| Responda: ");
                int resposta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(linha);
                if(resposta == 1){
                    
                    do {
                        Console.WriteLine(linha);
                        Console.WriteLine($"| Valor antes do saque: R$ {Math.Round(saldoLiquido, 2)}");
                        Console.Write("| Quanto você deseja sacar: R$");
                        saque = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine(linha);

                        if(saque > valorPresente){
                            Console.WriteLine(linha);
                            Console.WriteLine("| Valor não pode ser sacado, insira outro!");
                            Console.WriteLine(linha);
                        }
                    } while(saque > valorPresente);
                    
                    valorPresente -= saque;
                    
                    rendimentoRestante = valorPresente - saque;

                    Console.WriteLine(linha);
                    Console.WriteLine($"| Valor sacado: R$ {Math.Round(saque, 2)}");
                    Console.WriteLine($"| Valor depois do saque: R$ {Math.Round(valorPresente, 2)}");
                    Console.WriteLine(linha);
                }      
            }
            else {
                saque = 0;
            }
            
            Conta conta1 = new Conta(valorPresente-rendimento+saque, taxaDeJuros, rendimento, saque, saldoLiquido, rendimentoRestante+saque);
            conta[i-1] = conta1; 
        }

        Console.WriteLine(linha);   
        Console.WriteLine(cabecalho);  
        Console.WriteLine(linha);   
        for(int i = 0; i < conta.Length; i++){
            
            Console.WriteLine( $"|   {(i+1).ToString("00")}   |  {conta[i].ToString()}") ;
           
        }
        Console.WriteLine(linha);
    }
}