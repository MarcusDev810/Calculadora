public class CalculadoraSimples{

    public CalculadoraSimples(){
    
        LobbyAdicao();
        string[] dados = EntradaDosDados();
        double resultado = Calcula(dados);

        Console.Clear();
        Console.WriteLine($"O resultado da sua operação é:  {resultado}");
        Thread.Sleep(4500);

    }

    private void LobbyAdicao(){
        
        Console.Clear();
        Console.WriteLine("Bem Vindo(a) a calculadora simples");
        Thread.Sleep(2500);

        Console.Clear();
        Console.WriteLine("Aqui você terá que digitar a operação toda de uma vez no terminal!\n");
        Console.WriteLine("Exemplos: '23 * 3' ou '12421 - 63274'");
        Console.WriteLine("Sempre separando os números e os sinais por um espaço\n");
        Console.WriteLine("Para começar clique no botão 'Enter'");
        Console.ReadLine();

    }

    private string[] EntradaDosDados(){

        Console.Clear();
            
        bool repete = true;
        string[] saida = new string[3];

        while(repete){
            Console.Clear();
            
            Console.WriteLine("Qual a conta que deseja saber o resultado?:");
            Console.WriteLine("(Lembrando que sempre deve separar os números e os sinais por um espaço)");

            saida = Console.ReadLine().Split();

            if (!ValidaFormato(saida)){
                
                Console.Clear();
                Console.WriteLine("Formato ou sinal inválido!");
                Thread.Sleep(2000);
                
                Console.WriteLine("Lembrando que sempre deve separar os números e os sinais por um espaço");
                Console.WriteLine("Sinais válidos: +, -, *, /");
                Thread.Sleep(4000);
            }
            else {
                repete = false;
            };
            
        
        };

        return saida;
    }

    private bool ValidaFormato( string[] entrada ){
        
        bool saida = true;

        if(entrada.Length != 3){
            return false;
        }

        if(entrada[1] != "+" && entrada[1] != "-" && entrada[1] != "*" && entrada[1] != "/"){
            
            saida = false;
        }
        else if(!double.TryParse(entrada[0], out _)){
            
            saida = false;
        }
        else if(!double.TryParse(entrada[2], out _)){
            
            saida = false;
        }

        return saida;

    }
    
    private double Calcula( string[] entrada ){

        double num1 = double.Parse(entrada[0]);
        double num2 = double.Parse(entrada[2]);

        double saida = 0;

        switch (entrada[1]){
            
            case "+":
                saida = num1 + num2;
            break;

            case "-":
                saida = num1 - num2;
            break;

            case "*":
                saida = num1 * num2;
            break;

            case "/":
                saida = num1 / num2;
            break;
        }

        return saida;
    }

}