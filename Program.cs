using OOPFoundation;
using POOStrategyPatternExemplo;
using static System.Console;

try
{
    CPF cpf = new CPF(text: "123.456.789-01", validPattern: SanitizationPattern.CPF);
    WriteLine($"CPF {cpf.GetText()}");

    Pessoa jose = new Pessoa(documento: cpf);
    WriteLine($"Documento {jose.ObterDocumento()}");

    CNH cnh = new CNH(text: "123456789", validPattern: SanitizationPattern.DIGITS_ONLY);
    WriteLine($"\nCNH {cnh.GetText()}");

    Pessoa maria = new Pessoa(documento: cnh);
    WriteLine($"Documento {maria.ObterDocumento()}");

}
catch (ArgumentException ae)
{
    WriteLine(ae.Message);
}
