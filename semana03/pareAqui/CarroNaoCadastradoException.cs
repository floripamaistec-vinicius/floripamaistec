public class CarroNaoCadastradoException : Exception
{
    public CarroNaoCadastradoException() : base() { }
    public CarroNaoCadastradoException(string message) : base(message) { }
    public CarroNaoCadastradoException(string message, Exception innerException) : base(message, innerException) { }
}
