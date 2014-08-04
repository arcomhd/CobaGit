using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPControlExample7._1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Cal.SelectedDate = DateTime.Today.AddDays(1);
            DateTime[] ldt = new DateTime[1];
            ldt[0] = DateTime.Today.AddDays(1);
            this.Cal.SelectedDates = ldt;
            this.Cal.MinimumDate = new DateTime(DateTime.Today.Year , 1, 1);
            this.Cal.MaximumDate = new DateTime(DateTime.Today.Year+1, 12, 20);
        }
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Cal_MonthChanged(object sender, WPControls.MonthChangedEventArgs e)
        {
            Debug.WriteLine("Cal_MonthChanged fired.  New year is " + e.Year.ToString() + " new month is " + e.Month.ToString());
        }

        private void Cal_MonthChanging(object sender, WPControls.MonthChangedEventArgs e)
        {
            Debug.WriteLine("Cal_MonthChanging fired.  New year is " + e.Year.ToString() + " new month is " + e.Month.ToString());
        }

        private void Cal_SelectionChanged(object sender, WPControls.SelectionChangedEventArgs e)
        {
            Debug.WriteLine("Cal_SelectionChanged fired.  New date is " + e.SelectedDate.ToString());
            var count = (e.SelectedDate - DateTime.Today).TotalDays;
            Debug.WriteLine("Calcoun " +count);
            DateTime[] ldt = new DateTime[(int)count];
            for (int i = 0; i < (int)count;i++ )
            {
                ldt[i] = DateTime.Today.AddDays(i);
            }
            
            this.Cal.SelectedDates = ldt;
        }

        private void Cal_DateClicked(object sender, WPControls.SelectionChangedEventArgs e)
        {
            Debug.WriteLine("Cal_DateClicked fired.  New date is " + e.SelectedDate.ToString());
        }

    }
}