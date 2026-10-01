namespace SistemaBancario.Models
{
    // Pilar: Abstração
    // Uma classe abstrata não pode ser instanciada, só herdada
    public abstract class ContaBancaria
    {
        // Pilar: Encapsulamento: Campos privados protegidos por propriedades públicas
        private string _numeroConta;
        private decimal _saldo;

        // Existem três tipos de modificadores
        // Public - todos acessam
        // Private - somente a classe acessa
        // Protected - somente as classes filhos(Herdados)
        // Propriedades
        public string NumeroConta 
        {
            get => _numeroConta;
            protected set => _numeroConta = value;
        }

        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value;
        }

        public string NomeTitular { get; set; }
        public List<string> ExtratoTransacoes { get; set; } = new List<string>();

        // Construtor da classe base
        protected ContaBancaria(string numeroConta, string nomeTitular, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
            ExtratoTransacoes.Add($"Conta criada com saldo inicial de: R$ {saldoInicial:F2}");
        }

    }
}
