using Android.App;
using Android.Runtime;
using Com.Sam4s.Printer;

namespace MauiIntellisenseBug;
[Application]
public class MainApplication : MauiApplication
{
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
        var thisIsThirteen = Sam4sBuilder.LangKo;

        // Set a breakpoint here, see that the value of thisIsThirteen has been set to 13
        var breakpointHere = true;
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
