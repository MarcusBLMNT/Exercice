using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace Exercice
{
    public class SliderTextBlock : TextBlock
    {
        public bool isSelected = false;
        public string defaultText = "_";
        public string selectedText = "selected";
        public SliderTextBlock(string _selectedText, string _defaultText)
        {
            selectedText = _selectedText;
            defaultText = _defaultText;
            Text = defaultText;
            HorizontalAlignment = HorizontalAlignment.Stretch;
            VerticalAlignment = VerticalAlignment.Stretch;
            TextAlignment = TextAlignment.Center;
            
        }


    }
}
