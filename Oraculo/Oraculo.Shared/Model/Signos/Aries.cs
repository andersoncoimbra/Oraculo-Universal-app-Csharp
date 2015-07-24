using System;
using System.Collections.Generic;
using System.Text;

namespace Oraculo.Model.Signos
{
    class Aries : Signo
    {
        public Aries()
        {
            carregarFrases();
        }

        public override void carregarFrases()
        {
            listadefrases.Add("Arrisque, tentativas não sao em vam");
            listadefrases.Add("A vida trará coisas boas se tiveres paciência");
            listadefrases.Add("Demonstre amor e alegria em todas as oportunidades e verás que a paz nasce dentro de você.");
            listadefrases.Add("Não compense na ira o que lhe falta na razão.");
            listadefrases.Add("Defeitos e virtudes são apenas dois lados da mesma moeda.");
            listadefrases.Add("A maior de todas as torres começa no solo.");
            listadefrases.Add("Não há que ser forte. Há que ser flexível.");
        }
    }
}
