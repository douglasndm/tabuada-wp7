using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Tabuada.Views
{
    public partial class Home : PhoneApplicationPage
    {
        public Home()
        {
            InitializeComponent();

            var numericScope = new InputScope();
            var numericScopeName = new InputScopeName();
            numericScopeName.NameValue = InputScopeNameValue.Number;
            numericScope.Names.Add(numericScopeName);
            TextBox_NumCalc.InputScope = numericScope;
            TextBox_NumHowManyTimes.InputScope = numericScope; 
        }

        private void Btn_calc_Click(object sender, RoutedEventArgs e)
        {
            int numCalc, numHowManyTimes;

            try
            {
                numCalc = System.Convert.ToInt32(TextBox_NumCalc.Text);
                numHowManyTimes = System.Convert.ToInt32(TextBox_NumHowManyTimes.Text);

                NavigationService.Navigate(
                    new Uri(String.Format("/Views/Results.xaml?numCalc={0}&numHowManyTimes={1}", numCalc, numHowManyTimes), 
                            UriKind.RelativeOrAbsolute));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}