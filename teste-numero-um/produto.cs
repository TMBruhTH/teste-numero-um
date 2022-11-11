using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_numero_um
{
    public class produto
    {
        public int COD_PRODUTO { get; set; }
        public string? NOME_PRODUTO { get; set; }
        public float SALDO { get; set; }
        public string? ENTRADA_SAIDA { get; set; }
        public float QUANTIDADE { get; set; }
        public string? POSICAO_ESTOQUE { get; set; }
        public bool FATIVO { get; set; }
    }
}
