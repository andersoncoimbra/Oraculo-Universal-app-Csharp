using System;
using System.Collections.Generic;
using System.Text;

namespace Oraculo.Model.Signos
{
    class Gemeos : Signo
    {
        public Gemeos()
        {
            carregarFrases();
        }

        public override void carregarFrases()
        {
             listadefrases.Add("A adversidade é um espelho que reflete o verdadeiro eu.");
             listadefrases.Add("Lamentar aquilo que não temos é desperdiçar aquilo que já possuímos.");
             listadefrases.Add("Não há melhor negócio que a vida. A gente há obtém a troco de nada.");
             listadefrases.Add("O riso é a menor distância entre duas pessoas.");
             listadefrases.Add("Vencer é 90 por cento suor e 40 por cento técnica.");
             listadefrases.Add("O amor está mais próximo do que você imagina.");
             listadefrases.Add("Nunca se fique triste por se apaixonar");
        }
    }
}
