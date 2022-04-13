using System;
using Com.Devexpress.Acw_mcw_lib;

namespace MCW_ACW_TestApp
{
    public class NativeInterfaceImplementation : Java.Lang.Object, ITestInterface
    {
        public void SomeMethod()
        {
            Console.WriteLine();
        }
    }

    
    public class ExampleClass
	{
		public void RunExample()
        {
            var mcw = CreateMCWForNativeClass();
            var acw = CreateACW();
            AssignACWToNativeClass(mcw, acw);

            CallManagedMethodThrowNative(mcw);
        }

        private void CallManagedMethodThrowNative(TestClass MCW)
        {
            //Managed code --> MCW --> JNI --> Native Code --> ACW --> JNI --> Managed Code
            MCW.TestMethod();
        }

        private void AssignACWToNativeClass(TestClass nativeClassMCW, ITestInterface ACW)
        {
            nativeClassMCW.SomeProperty = ACW;
        }

        private ITestInterface CreateACW()
        {
            return new NativeInterfaceImplementation();
        }

        private TestClass CreateMCWForNativeClass()
        {
            return new TestClass();
        }
    }
}

