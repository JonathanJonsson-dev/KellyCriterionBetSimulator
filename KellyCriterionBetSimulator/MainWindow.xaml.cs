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

namespace KellyCriterionBetSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CheckProbability(double probabilityWin)
        {
            if (probabilityWin < 0 | probabilityWin > 1)
            {
                MessageBox.Show("Talet måste vara en siffra mellan 0 och 100");
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            double probabilityWin = double.Parse(txtBoxWinProb.Text) / 100;
            CheckProbability(probabilityWin);

            Calculator calculator = new Calculator(probabilityWin);
            
        }
    }
}
