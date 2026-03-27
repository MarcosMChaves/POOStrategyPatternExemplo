using OOPFoundation;

namespace POOStrategyPatternExemplo
{
    internal class CNH : AText
    {
        // Esta classe não implementa validação de dígito verificador
        public CNH(string text, string validPattern) : base(text, validPattern)
        {
        }
    }
}
