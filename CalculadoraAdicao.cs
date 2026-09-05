public class CalculadoraAdicao{

    int num1;
    int num2;

    public CalculadoraAdicao(){
    
        LobbyAdicao();

        Console.Clear();

        Console.WriteLine("Digite o primeiro número que deseja na soma:");
        this.num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número que deseja na soma:");
        this.num2 = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine($"A soma dos números {num1} e {num2} é: {num1 + num2}");
        Thread.Sleep(4500);
 
    }

    public void LobbyAdicao(){
        
        Console.Clear();
        Console.WriteLine("Bem Vindo(a) a calculadora de adiçao simples");
        Thread.Sleep(2500);

        Console.Clear();
        Console.WriteLine("Então vamos começar?!");
        Thread.Sleep(2500);

    }
    
}