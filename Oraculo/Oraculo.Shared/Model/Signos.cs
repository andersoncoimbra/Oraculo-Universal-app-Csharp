using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Oraculo.Model
{
    public abstract class  Signo
    {
        string nomenomeusuario; // receber o nome do usuario
        public ObservableCollection<string> listadefrases; //Declaração do colleção para receber as frases
        Random indice; //declaração da variavel do tipo randomica
        string afrasegerada; //declaração da variavel para receber a frase gerada

         public Signo(String nome)
         {
             listadefrases = new ObservableCollection<string>(); //instancia do objeto Coleção
             carregarFrases(); //metodo para carrega as frases na coleção
             indice = new Random(); //Instanciamento do objeto do tipo Randomico
             nomenomeusuario = nome;
         }

         public abstract void carregarFrases(); //metodo abstrato para se usado pela subclasse para carragar as suas frases no arralist

    }
}
