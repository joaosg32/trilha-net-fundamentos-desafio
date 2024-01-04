using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Validacoes
    {
        public bool ValidarPrecoEHora(string precoString)
        {
            // Verifica se é possível converter para decimal e se é maior ou igual a 0.
            if (decimal.TryParse(precoString, out decimal precoDecimal))
            {
                if (precoDecimal < 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }       
    }
}