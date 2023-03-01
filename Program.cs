var pagamentoBoleto = new PagamentoBoleto();

pagamentoBoleto.Pagar();
pagamentoBoleto.Vencimento = new DateTime ();
pagamentoBoleto.NumeroBoleto = "1234";

var pagamento = new Pagamento();
pagamento.Pagar();
pagamento.Vencimento = new DateTime ();

Console.WriteLine(pagamento.ToString());

var pagamentoCartaoCredito = new PagamentoCartaoCredito();
pagamentoCartaoCredito.NumeroCartaoCredito = "1234";

Console.WriteLine("Hello, World!");

class Pagamento
{
    public DateTime Vencimento { get; set; }

    public virtual void Pagar(){}

    public override string ToString()
    {
        return Vencimento.ToString("dd/mm/yyyy");
    }
}

class PagamentoBoleto : Pagamento
{
    public string NumeroBoleto { get; set; }

    public override void Pagar()
    {
        // Regra do boleto
    }
}

class PagamentoCartaoCredito : Pagamento
{
    public string NumeroCartaoCredito { get; set; }

    public override void Pagar()
    {
        // Regra pagar Cartão de Crédito
    }
}