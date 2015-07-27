using System;
using System.Collections.Generic;
using System.Text;

namespace Oraculo.Model.Signos
{
    class Capricornio : Signo
    {
        public Capricornio()
        {
            carregarFrases();
        }

        public override void carregarFrases()
        {
             listadefrases.Add("A adversidade é um espelho que reflete o verdadeiro eu.");
             listadefrases.Add("Lamentar aquilo que não temos é desperdiçar aquilo que já possuímos.");
             listadefrases.Add("Uma bela flor é incompleta sem suas folhas.");
             listadefrases.Add("Sem o fogo do entusiasmo, não há o calor da vitória.");
             listadefrases.Add("Não há melhor negócio que a vida. A gente há obtém a troco de nada.");
             listadefrases.Add("O riso é a menor distância entre duas pessoas.");

    
        }
    }

}
