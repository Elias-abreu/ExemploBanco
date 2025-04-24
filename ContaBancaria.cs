
public class ContaBancaria
{
	public int id;
	public string agencia;
	public string Nconta;
	public string nomePro;
	public double saldo;

	public void Depositar(double valor)
	{
		if (valor >= 0) {
			saldo += valor;
		}
		else
		{
			Console.WriteLine("Valor inválido!");
		}
	}
	public void Sacar(double valor)
	{
		if (valor > 0 && valor <= saldo)
		{
			saldo -= valor;
		}
		else
		{
			Console.WriteLine("Valor inválido!");
		}
	}
}

 