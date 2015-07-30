using System;
using System.Collections.Generic;
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

// O modelo de item de Página em Branco é documentado em http://go.microsoft.com/fwlink/?LinkID=390556

namespace Oraculo
{
    /// <resumo>
    /// Uma página vazia que pode ser usada sozinho ou navigated para dentro de um Frame.
    /// </resumo>
    public sealed partial class sobre : Page
    {
        public sobre()
        {
            this.InitializeComponent();
        }

        /// <resumo>
        /// Chamado quando esta página é exibida num Frame.
        /// </resumo>
        /// <param name="e">Dados de evento que descrevem como essa página foi atingida.
        /// Este parâmetro normalmente é usada para configurar a página.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
          

        
    }
}
