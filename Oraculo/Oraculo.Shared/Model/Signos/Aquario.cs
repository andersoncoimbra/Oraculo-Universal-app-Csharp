using System;
using System.Collections.Generic;
using System.Text;

namespace Oraculo.Model.Signos
{
    class Aquario : Signo
    {
        public Aquario()
        {
            carregarFrases();
        }

        public override void carregarFrases()
        {
            listadefrases.Add("Não há que ser forte. Há que ser flexível.");
            listadefrases.Add("Gente todo dia arruma os cabelos, por que não o coração?");
            listadefrases.Add("Há três coisas que jamais voltam; a flecha lançada, a palavra dita e a oportunidade perdida.");
            listadefrases.Add("Melhor pensar alto do que não pensar nada.");
            listadefrases.Add("A juventude não é uma época da vida, é um estado de espírito.");
            listadefrases.Add(" Podemos escolher o que semear, mas somos obrigados a colher o que plantamos.");
            listadefrases.Add("Dê toda a atenção para a formação dos teus filhos, sobretudo por exemplos de tua própria vida.");

    
        }
    }
}