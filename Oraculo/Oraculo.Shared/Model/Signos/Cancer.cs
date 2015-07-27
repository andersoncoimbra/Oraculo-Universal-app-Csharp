using System;
using System.Collections.Generic;
using System.Text;

namespace Oraculo.Model.Signos
{
    class Cancer : Signo
    {
        public Cancer()
        {
            carregarFrases();
        }

        public override void carregarFrases()
        {
             listadefrases.Add("Siga os bons e aprenda com eles.");
             listadefrases.Add("Não importa o tamanho da montanha, ela não pode tapar o sol.");
             listadefrases.Add("O bom-senso vai mais longe do que muito conhecimento.");
             listadefrases.Add("Quem quer colher rosas deve suportar os espinhos.");
             listadefrases.Add("São os nossos amigos que nos ensinam as mais valiosas lições.");
             listadefrases.Add("Uma iniciativa mal-sucedida não significa o final de tudo. Sempre existe uma nova oportunidade.");
             listadefrases.Add("Aquele que se importa com o sentimento dos outros, não é um tolo.");
        }
    }
}
