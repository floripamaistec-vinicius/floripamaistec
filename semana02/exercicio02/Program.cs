using exercicio02;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime data = new DateTime(1988,12,28,05,19,00);
        FichaInscricao _fichaInscricao = new FichaInscricao(1, "vinicius", data, true);
        _fichaInscricao.ImprimeInscricao();
    }
}
