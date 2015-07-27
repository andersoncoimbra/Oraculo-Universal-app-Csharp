using System;
using System.Collections.Generic;
using System.Text;

namespace Oraculo.Model.Signos
{
    class Virgem : Signo
    {
        public Virgem()
        {

        }

        public override void carregarFrases()
        {
             listadefrases.Add("Você é do tamanho do seu sonho.");
             listadefrases.Add("A maior barreira para o sucesso é o medo do fracasso.");
             listadefrases.Add("O pessimista vê a dificuldade em cada oportunidade; O otimista vê a oportunidade em cada dificuldade.");
             listadefrases.Add("Muitas das grandes realizações do mundo foram feitas por homens cansados e desanimados que continuaram trabalhando.");
             listadefrases.Add("O insucesso é apenas uma oportunidade para recomeçar de novo com mais inteligência.");
             listadefrases.Add("O futuro pertence àqueles que acreditam na beleza de seus sonhos.");
             listadefrases.Add("Coragem é a resistência ao medo, domínio do medo, e não a ausência do medo.");

            throw new NotImplementedException();
        }
    }
}
