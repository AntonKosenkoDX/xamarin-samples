using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Com.Devexpress.Acw_mcw_lib;

namespace MCW_ACW_TestApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //Here we're creating an instance of MCW for native class
            var testClass = new TestClass();
            testClass.SomeAction += TestClassOnSomeAction;
            testClass.AnotherAction += AnotherAction;
            TestClass.Companion.SomeStaticProperty = String.Empty;
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
        }

        private string AnotherAction(string param1, string param2, string param3)
        {
            throw new NotImplementedException();
        }

        private void TestClassOnSomeAction(object sender, ActionEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}