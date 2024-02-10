public class Luminosidade : IObservador
{
    public int Valor;

    public void setValor(int valor){
        this.Valor = valor;
    }

    public void Atualizar(IObservavel observavel)
    {
        Console.WriteLine("O sensor de luminosidade captou a luz.");
        if (Valor > 10000)
            Console.WriteLine("A iluminosidade está acima de 1000. Tome cuidado com os olhinhos");
    }
}