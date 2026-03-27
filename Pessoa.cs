using OOPFoundation;

namespace POOStrategyPatternExemplo
{
    public class Pessoa
    {
        private readonly AText Documento; // Aceita qualquer documento derivado de AText

        public Pessoa(AText documento)
        {
            Documento = documento ?? throw new ArgumentNullException(nameof(documento));
        }

        public string ObterDocumento()
        {
            // GetType().Name retorna o nome da classe utilizada
            return $"'{Documento.GetType().Name}' {Documento.GetText()}";
        }
    }
}
