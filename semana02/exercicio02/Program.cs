using exercicio02;

public class Program
{
    private static void Main(string[] args)
    {
        DateTime data = new DateTime(1988,12,28);
        FichaInscricao _fichaInscricao = new FichaInscricao(00001, "vinicius", data, true);
        _fichaInscricao.ImprimeInscricao();
    }
}
