#nullable enable
#if ANDROID
using PlatformView = AndroidX.AppCompat.Widget.AppCompatEditText;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.Controls.TextBox;
#endif

using Microsoft.Maui.Handlers;

namespace MauiApp3
{
    public partial class CustomEntryHandler
    {
        public static PropertyMapper<ICustomEntry, CustomEntryHandler> CustomEntryMapper = new PropertyMapper<ICustomEntry, CustomEntryHandler>(ViewMapper)
        {
        };

        public CustomEntryHandler()
            : base(CustomEntryMapper) { }
    }
}