using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3
{
    public partial class CustomEntryHandler : ViewHandler<ICustomEntry, Microsoft.UI.Xaml.Controls.TextBox>
    {
        protected override Microsoft.UI.Xaml.Controls.TextBox CreatePlatformView()
        {
            return new Microsoft.UI.Xaml.Controls.TextBox();
        }
    }
}