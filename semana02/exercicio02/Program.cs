using exercicio02;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime Data = new DateTime(1988,12,28,05,19,00);
        FichaInscricao FichaInscricao = new FichaInscricao(1, "vinicius", Data, true);
        FichaInscricao.ImprimeInscricao();
    }
}
