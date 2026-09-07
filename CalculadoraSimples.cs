public class CalculadoraSimples{

    public CalculadoraSimples(){
    
        LobbyAdicao();

        Calcula(EntradaDosDados());

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

        string[] saida = new string[3];

        do{
            Console.Clear();
            
            Console.WriteLine("Qual a conta que deseja saber o resultado?:");
            Console.WriteLine("(Lembrando que sempre deve separar os números e os sinais por um espaço)");

            saida = Console.ReadLine().Split();

            if (!ValidaFormato(saida)){
                
                Console.WriteLine("Formato ou sinal inválido!");
                Thread.Sleep(2000);
                
                Console.WriteLine("Lembrando que sempre deve separar os números e os sinais por um espaço");
                Console.WriteLine("Sinais válidos: +, -, *, /");
                Thread.Sleep(4000);
            }
        
        }while(!ValidaFormato(saida));

        return saida;
    }

    private bool ValidaFormato( string[] entrada ){
        
        bool saida = true;

        if(entrada[1] != "+" || entrada[1] != "-" || entrada[1] != "*" || entrada[1] != "/"){
            
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
    
    private void Calcula( string[] entrada ){

        Console.WriteLine("Chegou no calculo :)");
    }

}