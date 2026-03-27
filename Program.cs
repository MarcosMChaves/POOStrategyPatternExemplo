using OOPFoundation;
using POOStrategyPatternExemplo;
using static System.Console;

// Capturar eventuais erros, em especial, validação
try
{
    // Utilizando a classe CPF que herda de AText
    CPF cpf = new CPF(text: "123.456.789-01", validPattern: SanitizationPattern.CPF);
    WriteLine($"CPF {cpf.GetText()}");

    // Objetos da classe Pessoa aceitam qualquer objeto de classes derivadas de AText
    Pessoa jose = new Pessoa(documento: cpf);
    WriteLine($"Documento {jose.ObterDocumento()}");

    // Utilizando a classe CNH que herda de AText
    CNH cnh = new CNH(text: "123456789", validPattern: SanitizationPattern.DIGITS_ONLY);
    WriteLine($"\nCNH {cnh.GetText()}");

    // Objetos da classe Pessoa aceitam qualquer objeto de classes derivadas de AText
    Pessoa maria = new Pessoa(documento: cnh);
    WriteLine($"Documento {maria.ObterDocumento()}");

}
catch (ArgumentException ae)
{
    WriteLine(ae.Message);
}
