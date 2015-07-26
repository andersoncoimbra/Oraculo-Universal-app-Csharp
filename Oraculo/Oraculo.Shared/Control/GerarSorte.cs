using Oraculo.Model;
using Oraculo.Model.Signos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Oraculo.Control
{
    class GerarSorte
    {
        public string sorteGerada;

        public GerarSorte(int sig)
        {
            Signo horo;
            
           // sorteGerada = "Teste realizado com sucesso";
            
            Debug.WriteLine("Indice Selecionado: " + sig);

            switch (sig){
                case  0:  horo = new Aries();
                    Debug.WriteLine("Caso 0");
                    break;
                default : horo = new Aries();
                    Debug.WriteLine("Caso Default");
                    break;
                }
            sorteGerada = horo.afrasegerada;
            Debug.WriteLine("Classe GerarSorte Completada");
        }
    }
}
