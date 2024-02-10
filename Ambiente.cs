public class Ambiente :IObservavel
{
    List<IObservador> observadores = new List<IObservador>();

    public void Notificar()
    {
        foreach(var ob in observadores)
        {
            ob.Atualizar(this);
        }
    }

    public void Registrar(IObservador observador)
    {
        this.observadores.Add(observador);
    }

    public void Remover(IObservador observador)
    {
        this.observadores.Remove(observador);
    }

    public void Notificacao()
    {
        this.Notificar();
    }
}