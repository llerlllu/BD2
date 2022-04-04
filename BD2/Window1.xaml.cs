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
using System.Windows.Shapes;

namespace BD2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        PraktikaEntities Pr = new PraktikaEntities();
        public Window1()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Pr.ID_FIO.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
