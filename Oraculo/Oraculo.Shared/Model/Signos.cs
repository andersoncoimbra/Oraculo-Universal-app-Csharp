using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace Oraculo.Model
{
    public abstract class  Signo
    {
        string nomenomeusuario; // receber o nome do usuario
        public ObservableCollection<string> listadefrases; //Declaração do colleção para receber as frases
        Random indice; //declaração da variavel do tipo randomica
        public string afrasegerada; //declaração da variavel para receber a frase gerada

         public Signo()
         {
             listadefrases = new ObservableCollection<string>(); //instancia do objeto Coleção
             carregarFrases(); //metodo para carrega as frases na coleção
             indice = new Random(); //Instanciamento do objeto do tipo Randomico
             //nomenomeusuario = nome;

             afrasegerada = listadefrases[indice.Next(0, listadefrases.Count)];//Algoritimo que pega a frase aleatoriamente da lista defrase
        //usando tres metodos um para pega a a frase no Arralist um para gera um numero aleatotio o outro para determinar u limite de frases dentro da lista



             Debug.WriteLine("Frase gerada "+ afrasegerada);
         }

         public abstract void carregarFrases(); //metodo abstrato para se usado pela subclasse para carragar as suas frases no arralist

    }
}
