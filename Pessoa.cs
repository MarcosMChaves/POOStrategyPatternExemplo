using OOPFoundation;

namespace POOStrategyPatternExemplo
{
    public class Pessoa
    {
        private readonly AText Documento;

        public Pessoa(AText documento)
        {
            Documento = documento ?? throw new ArgumentNullException(nameof(documento));
        }

        public string ObterDocumento()
        {
            return $"'{Documento.GetType().Name}' {Documento.GetText()}";
        }
    }
}
