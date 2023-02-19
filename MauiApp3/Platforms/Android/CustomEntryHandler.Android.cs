using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3
{
    public partial class CustomEntryHandler : ViewHandler<ICustomEntry, AppCompatEditText>
    {
        protected override AppCompatEditText CreatePlatformView()
        {
            return new AppCompatEditText(Context);
        }
    }
}