using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPControls;

namespace WpControlsExample
{
    public class ColorConverter : IDateToBrushConverter
    {

        public Brush Convert(DateTime dateTime, bool isSelected, Brush defaultValue, BrushType brushType)
        {
            string abu = "#dddddd";
            var Abu = new SolidColorBrush(Color.FromArgb(
                System.Convert.ToByte("ff", 16),
                System.Convert.ToByte(abu.Substring(1, 2), 16),
                System.Convert.ToByte(abu.Substring(3, 2), 16),
                System.Convert.ToByte(abu.Substring(5, 2), 16)
            ));
            string abu2 = "#888888";
            var Abu2 = new SolidColorBrush(Color.FromArgb(
                System.Convert.ToByte("ff", 16),
                System.Convert.ToByte(abu2.Substring(1, 2), 16),
                System.Convert.ToByte(abu2.Substring(3, 2), 16),
                System.Convert.ToByte(abu2.Substring(5, 2), 16)
            ));
          
            if (brushType == BrushType.Background)
            {
                //DateTime dpSelectedDate=new DateTime();
                //if (settings.Contains("DepSelectedDate"))
                //{
                //    settings.TryGetValue<DateTime>("DepSelectedDate", out dpSelectedDate);
                //}
                if (dateTime < new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day))
                {
                    return Abu;
                }
                else
                {
                    return defaultValue;
                }
            }
            else if (brushType == BrushType.BorderBrush)
            {

                if (dateTime == new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day))
                {
                    return new SolidColorBrush(Colors.Brown);
                }
                else
                {
                    return defaultValue;
                }

            }
            else
            {

                if (dateTime < new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day))
                {
                    return Abu2;
                }
                else
                {
                    return defaultValue;
                }
            }

        }
    }
}
