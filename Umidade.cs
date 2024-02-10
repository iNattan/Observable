public class Umidade : IObservador
{
    public int Valor;

    public void setValor(int valor){
        Valor = valor;
    }

   public void Atualizar(IObservavel observavel)
    {
        Console.WriteLine("O sensor de umidade captou os pinguin.");
        if (Valor > 80)
            Console.WriteLine("A umidade está acima de 80%. Vai chover.");
    }
}