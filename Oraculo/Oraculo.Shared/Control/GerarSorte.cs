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

        public GerarSorte()
        {
            Signo horo = new Aries();
            sorteGerada = horo.afrasegerada;
           // sorteGerada = "Teste realizado com sucesso";
            Debug.WriteLine("Classe GerarSorte Completada");
        }
    }
}
