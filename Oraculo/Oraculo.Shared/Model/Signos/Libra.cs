using System;
using System.Collections.Generic;
using System.Text;

namespace Oraculo.Model.Signos
{
    class Libra : Signo
    {
        public Libra()
        {
            carregarFrases();
        }

        public override void carregarFrases()
        {
             listadefrases.Add("A paciência na adversidade é o sinal de um coração sensível.");
             listadefrases.Add("A sorte favorece a mente bem preparada.");
             listadefrases.Add("Sua visão se tornará clara apenas quando você puder olhar dentro de seu coração.");
             listadefrases.Add("Quem olha para fora sonha; quem olha para dentro acorda.");
             listadefrases.Add("As pessoas se esquecerão do que você disse e do que você fez… mas nunca se esquecerão de como você as fez sentir.");
             listadefrases.Add("Espere pelo mais sábio dos conselhos: o tempo.");
        }
    }
}
