using System;
using System.Collections.Generic;
using System.Text;

namespace Oraculo.Model.Signos
{
    class Peixe : Signo
    {
        public Peixe()
        {
            carregarFrases();
        }

        public override void carregarFrases()
        {
             listadefrases.Add("Todas as coisas são difíceis antes de se tornarem fáceis.");
             listadefrases.Add("Você pode encontrar a si mesmo fazendo ou dizendo coisas que você nunca imaginou possíveis.");
             listadefrases.Add("Se você se sente só é porque construiu muros ao invés de pontes.");
             listadefrases.Add("Vencer é 90 por cento suor e 10 por cento técnica.");
             listadefrases.Add("O amor está mais próximo do que você imagina.");

        }
    }
}
