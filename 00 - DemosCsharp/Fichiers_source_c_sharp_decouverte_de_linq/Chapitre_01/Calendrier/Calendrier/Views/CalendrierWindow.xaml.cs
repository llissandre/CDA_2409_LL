using Calendrier.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calendrier.Views
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class CalendrierWindow : Window
    {
        private Calendrier.ViewModels.CalendrierViewModel _vm;

        public CalendrierWindow()
        {
            InitializeComponent();
            _vm = new ViewModels.CalendrierViewModel();
            DataContext = _vm;
        }

        private void btnAnnule_Click(object sender, RoutedEventArgs e)
        {
            var s = (Session)dgData.SelectedItem;
            _vm.AnnuleSession(s.SessionId);
        }

        private void dp_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_vm == null) return;
            if (dp.SelectedDate != null)
            {
                _vm.GetSemaine(dp.SelectedDate.Value);
                Titre.Text = String.Format("Calendrier : {0} sessions en semaine {1}",
                    _vm.sessions.Count, _vm.Semaine);
            }
        }

        private void btnPage2_Click(object sender, RoutedEventArgs e)
        {
            var InfosWindow = new Views.Infos();
            InfosWindow.ShowDialog();
        }

    }
}
