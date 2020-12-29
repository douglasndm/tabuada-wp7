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
    public partial class Results : PhoneApplicationPage
    {
        int numCalc, numHowManyTimes;
        public Results()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            IDictionary<string, string> parameters = NavigationContext.QueryString;

            if (parameters.ContainsKey("numCalc") && parameters.ContainsKey("numHowManyTimes"))
            {
                try
                {
                    numCalc = System.Convert.ToInt32(parameters["numCalc"]);
                    numHowManyTimes = System.Convert.ToInt32(parameters["numHowManyTimes"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                throw new Exception("Results page didn't get right datas");
            }

            base.OnNavigatedTo(e);
        }
    }
}