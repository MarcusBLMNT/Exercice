using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Exercice
{
    /// <summary>
    /// Logique d'interaction pour SliderControl.xaml
    /// </summary>
    public partial class SliderControl : UserControl
    {

        SliderModel model = new SliderModel();
        SliderTextBlock previousSelection; 
        public SliderControl()
        {

            InitializeComponent();
           foreach (SliderTextBlock item in  model.micrometers)
            {             
                MainListBox.Items.Add(item);
              
            }
            MainListBox.SelectedIndex = MainListBox.Items.Count / 2;
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainListBox.SelectedIndex > 0)
            {
                MainListBox.SelectedIndex--;
            }
        }

       

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainListBox.SelectedIndex < MainListBox.Items.Count -1)
            {
                MainListBox.SelectedIndex++;
            }
        }

        private void MainListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            SliderTextBlock tb = (SliderTextBlock)MainListBox.SelectedItem;
            
            tb.Text = tb.selectedText;
            tb.Foreground = Brushes.White;
            if (previousSelection != null)
            {
                previousSelection.Text = previousSelection.defaultText;
                previousSelection.Foreground = Brushes.Black;
            }
            previousSelection = tb;

        }
    }
}
