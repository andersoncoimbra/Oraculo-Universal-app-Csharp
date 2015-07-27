using System;
using System.Collections.Generic;
using System.Text;

namespace Oraculo.Model.Signos
{
    class Sagitario : Signo
    {
        public Sagitario()
        {
            carregarFrases();
        }

        public override void carregarFrases()
        {
             listadefrases.Add("Você é do tamanho do seu sonho.");
             listadefrases.Add("O mundo tem a cor que você pinta.");
             listadefrases.Add("Pare de procurar eternamente; a felicidade está bem ao seu lado.");
             listadefrases.Add("Conhecimento é a única virtude e ignorância é o único vício.");
             listadefrases.Add("O nosso primeiro e último amor é… o amor-próprio.");
             listadefrases.Add("Deixe de lado as preocupações e seja feliz.");
             listadefrases.Add("A vontade das pessoas é a melhor das leis.");
             listadefrases.Add("Nós somos o que pensamos.");

            throw new NotImplementedException();
        }
    }
}
