using System;

public class FichaInscricao
{
	private int _id;
	public string _nome { get; set; }
	public DateTime _dataNascimento { get; set; }
	private Boolean _menorIdade { get; set; }
	public FichaInscricao(int id, string Nome, DateTime DataNascimento, Boolean MenorIdade)
    {
		this._id = id;
		this._nome = Nome;
		this._dataNascimento = DataNascimento;
		this._menorIdade = MenorIdade;
	}
	public void ImprimeInscricao()
	{
		Console.WriteLine("ID: {0}", _id);
        Console.WriteLine("Nome: {0}", _nome);
        Console.WriteLine("ID: {0}", _dataNascimento);
    }
}
