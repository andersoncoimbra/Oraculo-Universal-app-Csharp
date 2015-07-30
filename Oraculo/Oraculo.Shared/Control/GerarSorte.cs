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
                case 1:  horo = new Aries();
                    Debug.WriteLine("Caso 1 - Signo Aries");
                    break;
                case 2: horo = new Touro();
                    Debug.WriteLine("Caso 1 - Signo Touro");
                    break;
                case 3: horo = new Gemeos();
                    Debug.WriteLine("Caso 1 - Signo Gemeo");
                    break;
                case 4: horo = new Cancer();
                    Debug.WriteLine("Caso 1 - Signo Cancer");
                    break;
                case 5:
                    horo = new Leao();
                    Debug.WriteLine("Caso 1 - Signo Leão");
                    break;
                case 6: horo = new Virgem();
                    Debug.WriteLine("Caso 1 - Signo Virgem");
                    break;
                case 7: horo = new Libra();
                    Debug.WriteLine("Caso 1 - Signo Libra");
                    break;
                case 8: horo = new Escorpiao();
                    Debug.WriteLine("Caso 1 - Signo Escopião");
                    break;
                case 9: horo = new Sagitario();
                    Debug.WriteLine("Caso 1 - Signo Sagitario");
                    break;
                case 10: horo = new Capricornio();
                    Debug.WriteLine("Caso 1 - Signo Capricornio");
                    break;
                case 11: horo = new Aquario();
                    Debug.WriteLine("Caso 1 - Signo Aquario");
                    break;
                case 12: horo = new Peixe();
                    Debug.WriteLine("Caso 1 - Signo Peixe");
                    break;
                default :
                    horo = new DiretoDoAlem();
                    Debug.WriteLine("Caso Default - Direto do Além ");
                    break;
                }
            sorteGerada = horo.afrasegerada;
            Debug.WriteLine("Classe GerarSorte Completada");
        }
    }
}
