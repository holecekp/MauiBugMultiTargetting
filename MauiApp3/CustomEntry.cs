using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3
{
    public class CustomEntry: View, ICustomEntry
    {
        public string Text { get; }
        public Color TextColor { get; }
    }
}
