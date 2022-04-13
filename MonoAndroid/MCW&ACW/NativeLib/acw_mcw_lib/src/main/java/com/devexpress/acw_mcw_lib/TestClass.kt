package com.devexpress.acw_mcw_lib

class TestClass {
    //this property contains ACW instance for class implemented in managed world
    var someProperty: TestInterface? = null

    //this property will be converted to EventHandler in MCW for this class
    var onSomeActionListener: OnActionListener? = null

    //this property will be converted to delegate-typed property in MCW for this class
    var onAnotherActionListener: OnAnotherActionListener? = null

    fun testMethod(){
        //Here we're calling method of ACW, which than calls method of managed class instance via JNI
        someProperty?.someMethod()
    }

    fun performAction() {
        onSomeActionListener?.onAction("test1", "test2", "test3")
    }

    fun performAnotherAction() : String? {
        var result = onAnotherActionListener?.onAction("test1", "test2", "test3")
        return result;
    }
}

//To be converted to EventHandler in MCW property in native class must has a type that:
//1. Is an Interface
//2. Has the 'Listener' suffix
//3. Has only one method with no return
//4. Is Nullable
interface OnActionListener {
    //All parameters of given method will be moved to corresponding EventArgs
    fun onAction(param1: String, param2: String, param3: String)
}

//If method of interface will return any value, than delegate-typed property
//will be generated in MCW instead of EventHandler
interface OnAnotherActionListener {
    fun onAction(param1: String, param2: String, param3: String) : String
}