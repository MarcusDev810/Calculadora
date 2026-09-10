class CalculadoraRobusta{
    
    public CalculadoraRobusta(){
        
        Lobby();
        string[] dados = EntradaDosDados();

        Console.Clear();
        Console.WriteLine($"O resultado da sua operação é:  ");
        Thread.Sleep(4500);
    }

    private void Lobby(){
        
        Console.Clear();
        Console.WriteLine("Bem Vindo(a) a calculadora Robusta!");
        Thread.Sleep(2500);

        Console.Clear();
        Console.WriteLine("Aqui você terá que digitar a operação toda de uma vez no terminal!\n");
        Console.WriteLine("Exemplos: 234 + 48 * -201 / 3 - 848");
        Console.WriteLine("Sempre separando os números e os sinais por um espaço\n");
        Console.WriteLine("Para começar clique no botão 'Enter'");
        Console.ReadLine();

    }

     private string[] EntradaDosDados(){

        Console.Clear();
            
        bool repete = true;
        string[] dados = [];

        while(repete){
            Console.Clear();
            
            Console.WriteLine("Qual a conta que deseja saber o resultado?:");
            Console.WriteLine("(Lembrando que sempre deve separar os números e os sinais por um espaço)");

            dados = Console.ReadLine().Split();

            if (!ValidaFormato(dados)){
                
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

        return dados;
    }

    private bool ValidaFormato( string[] entrada){

        bool valido = true;

        if(entrada.Length < 3){
            valido = false; Console.WriteLine("menor que 3"); Console.ReadLine();
        }
        else if(entrada.Length % 2 == 0){
            valido = false; Console.WriteLine("não é impar");Console.ReadLine();
        }

        for(int i = 0; i < entrada.Length; i++){
            
            if( i % 2 == 0){

                if(!double.TryParse(entrada[i], out _)){

                    valido = false; Console.WriteLine("não é numero");Console.ReadLine();
                }
            }
            else{
                if(entrada[i] != "+" && entrada[i] != "-" && entrada[i] != "*" && entrada[i] != "/"){

                    valido = false; Console.WriteLine("Erro no sinal");Console.ReadLine();
                }

            }
        }


        return valido;
    }


}