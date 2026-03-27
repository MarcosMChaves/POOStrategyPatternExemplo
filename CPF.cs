using OOPFoundation;

namespace POOStrategyPatternExemplo
{
    internal class CPF : AText
    {
        // Esta classe não implementa validação de dígito verificador
        public CPF(string text, string validPattern) : base(text, validPattern)
        {
        }
    }
}
