namespace Calculadora_Simples;

class Program{
    static void Main(string[] args){
        
        Lobby();
        Opcoes();

    }

    static void Lobby(){

        Console.Clear();
        Console.WriteLine("Bem Vindo(a) ao sistema de calculadoras");
        Thread.Sleep(2500);

        Console.Clear();
        Console.WriteLine("Aqui você verá diferentes tipos de calculadoras");
        Thread.Sleep(3500);

        Console.Clear();
        Console.WriteLine("Então, vamos começar?!");
        Thread.Sleep(2500);

    }

    static void Opcoes(){
        
        int entrada = -1;

        while(entrada != 0){

            Console.Clear();
            Console.WriteLine("----Calculadoras----");
            Console.WriteLine("----Você deseja usar qual calculadora?----");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Calculadora de adição simples (dois números)");
            Console.WriteLine("Digite sua escolha:");

            entrada = int.Parse(Console.ReadLine());

            if (!ValidaOpcao(entrada)){
                Console.Clear();
                Console.WriteLine("Opção invalida!");
                Console.WriteLine("Tente novamente!");
                Thread.Sleep(2000);
            }
            Calculadoras(entrada);

        };
            
    }

    static bool ValidaOpcao(int entrada){
        
        bool saida = true;

        if(entrada < 0 || entrada > 1){
            saida = false;
        }

        return saida;
    }

    static void Calculadoras(int indice){
        
        switch (indice){
            case 1:
                new CalculadoraAdicao();
            break;
        }
    }
}

