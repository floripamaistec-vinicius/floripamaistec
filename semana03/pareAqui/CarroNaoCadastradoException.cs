using pareAqui;

public class CarroNaoCadastradoException : Exception
{
    public CarroNaoCadastradoException() : base() { }
    public CarroNaoCadastradoException(string message) : base(message) { }
    public CarroNaoCadastradoException(string message, Exception innerException) : base(message, innerException) { }
    public static void TryCatchCarro(string Opcao)
    {
        try
        {
            Carro carro = CadastroCarro.ConsultarPlacaNoCadastroDeCarros();
            if (carro == null)
            {
                throw new CarroNaoCadastradoException("Carro inexistente.");
            }
            else
            {
                IFElseTryCatchCarro(Opcao, carro);
            }
        }
        catch (CarroNaoCadastradoException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
    static private void IFElseTryCatchCarro(String Opcao, Carro carro)
    {
        switch (Opcao)
        {
            case "2": CadastroCarro.ConsultarHistorico(carro); break;
            case "3": CadastroTicket.CadastrarEntrada(carro); break;
            case "4": CadastroTicket.CadastrarSaida(carro); break;
        }
    }
}