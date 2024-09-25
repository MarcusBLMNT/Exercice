using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice
{
    public class SliderModel
    {
        public SliderTextBlock[] micrometers { get; } = {
            new SliderTextBlock("0 μm", "________"),
            new SliderTextBlock("1 μm", "____"),
            new SliderTextBlock("2 μm", "____"),
            new SliderTextBlock("3 μm", "____"),
            new SliderTextBlock("4 μm", "____"),
            new SliderTextBlock("5 μm", "____"),
            new SliderTextBlock("6 μm", "____"),
            new SliderTextBlock("7 μm", "____"),
            new SliderTextBlock("8 μm", "____"),
            new SliderTextBlock("9 μm", "____"),
            new SliderTextBlock("10 μm", "____"),
            new SliderTextBlock("11 μm", "____"),
            new SliderTextBlock("12 μm", "____"),
            new SliderTextBlock("13 μm", "____"),
            new SliderTextBlock("14 μm", "____"),
            new SliderTextBlock("15 μm", "________"),
        };
    }
}
