var pagamentoBoleto = new PagamentoBoleto();

pagamentoBoleto.Pagar();
pagamentoBoleto.Vencimento = new DateTime ();
//pagamentoBoleto.NumeroBoleto = "1234";

var pagamento = new Pagamento();
pagamento.Pagar();
pagamento.Vencimento = new DateTime ();

Console.WriteLine(pagamento.ToString());

var pagamentoCartaoCredito = new PagamentoCartaoCredito();
pagamentoCartaoCredito.NumeroCartaoCredito = "1234";


var pessoaA = new Person(1, "Tiago V");
var pessoaB = new Person(1, "Tiago V");

Console.WriteLine(pessoaA.Equals(pessoaB));

var pagar = new Pagamento.PagarMe(RealizarPagamento);
pagar(25);

static void RealizarPagamento(double valor)
{
    Console.WriteLine($"Pago o valor de: {valor}");
}

class Pagamento : IDisposable
{
    public DateTime Vencimento { get; set; }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public virtual void Pagar(){}

    public delegate void PagarMe(double valor);

    public override string ToString()
    {
        return Vencimento.ToString("dd/mm/yyyy");
    }
}

class PagamentoBoleto : Pagamento
{
    private string NumeroBoleto { get; set; }

    public override void Pagar()
    {
        // Regra do boleto
    }
}

class PagamentoCartaoCredito : IPagamento
{    
    public string NumeroCartaoCredito { get; set; }

    public void Pagar(double valor)
    {
        throw new NotImplementedException();
    }
}

public class Person : IEquatable<Person>
{
    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; set; }
     public string Name { get; set; }

    public bool Equals(Person? other)
    {
        return Id == other.Id;
    }
}

public class Personal : Person
{
    public Personal(int id, string nome): base(id, nome)
    {
        Id = id;
        Name = nome;
    }
    public string CPF { get; set; }
}

public class Corporate : Person
{
    public Corporate(int id, string nome) : base(id, nome)
    {
        Id =id;
        Name = nome;
    }
    public string CNPJ { get; set; }
}