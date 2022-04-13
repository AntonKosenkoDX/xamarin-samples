using Android.Views;
using Com.Devexpress.Acw_mcw_lib;

namespace MCW_ACW_TestApp
{
    public class NativeInterfaceImplementation : Java.Lang.Object, ITestInterface
    {
        public View.IOnClickListener ClickListener { get; set; }
        public IOnActionListener OnSomeActionListener { get; set; }

        public void SomeMethod()
        {
        }
    }
}