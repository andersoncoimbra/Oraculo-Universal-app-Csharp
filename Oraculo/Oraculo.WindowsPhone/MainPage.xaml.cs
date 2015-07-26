using Oraculo.Control;
using System;
using System.Collections;
using System.Collections.ObjectModel;
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

            this.NavigationCacheMode = NavigationCacheMode.Required;
            
            string[] sigEx = {"Direto do Alem", "Aries", "Touro","Gemeos", "Cancer", "Goku ","Leao", "Virgem", "Libra", "Escorpiao","Sagitario", "Capricornio", "Aquario", "Peixe"};

            sig.DataContext = sigEx;

           
        }

        /// <resumo>
        /// Chamado quando esta página é exibida num Frame.
        /// </resumo>
        /// <param name="e">Dados de evento que descrevem como essa página foi atingida.
        /// Este parâmetro normalmente é usada para configurar a página.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare a página para exibição aqui.

            // TODO: Se seu aplicativo contiver várias páginas certifique-se de que esteja
            // manipulando o botão Voltar do hardware ao fazer o registro para o
            // Evento Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Se estiver usando o NavigationHelper fornecido por alguns modelos,
            // este evento é manipulado para você.
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
                Debug.WriteLine("Signo não selecionado"+ ex);

            }
        }

        

        
        
    }
}
