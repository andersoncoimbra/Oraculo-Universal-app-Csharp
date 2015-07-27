using Oraculo.Control;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco é documentado em http://go.microsoft.com/fwlink/?LinkId=234238

namespace Oraculo
{
    /// <resumo>
    /// Uma página vazia que pode ser usada sozinho ou navigated para dentro de um Frame.
    /// </resumo>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
			
			string[] sigEx = { "Direto do Alem", "Aries", "Touro", "Gemeos", "Cancer", "Goku ", "Leao", "Virgem", "Libra", "Escorpiao", "Sagitario", "Capricornio", "Aquario", "Peixe" };

             sig.DataContext = sigEx;
			
        }
		
		private void gera(object sender, RoutedEventArgs e)
         {
             GerarSorte sorte = new GerarSorte(sig.SelectedIndex);
             try
             {
                 text.Text =
                     //sig.SelectedItem.ToString();
                     sorte.sorteGerada;

             }
             catch (Exception ex)
             {

                 text.Text = "Selecione o signo";
                 Debug.WriteLine("Signo não selecionado" + ex);

             }
         }
    }
}
