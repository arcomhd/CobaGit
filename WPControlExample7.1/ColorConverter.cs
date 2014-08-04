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
            if (brushType == BrushType.Background)
            {
                return defaultValue;
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
                if (dateTime == new DateTime(DateTime.Today.Year, DateTime.Today.Month, 6))
                {
                    return new SolidColorBrush(Colors.Red);
                }
                else
                {
                    return defaultValue;
                }
            }

        }
    }
}
