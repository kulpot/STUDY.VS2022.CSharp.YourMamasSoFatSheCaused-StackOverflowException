using System;

//ref link:https://www.youtube.com/watch?v=htwejdTvBBI&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=43
// LIFO -- last in first out
// Stack -- LIFO 
// GC(garbageCollection) -- work only on heap but stack is immune

// f10 -> debug -> window -> CallStack -- StackFrame(activation instance) is all the details that popup when you keep f11 the debug

//


struct CountingClass
{
    static short counter = 0;
    short id;
    char c;
    public CountingClass()
    {
        id = counter;
        c = (char)(((short)'a') + counter);
        counter++;
    }
}

class MainClass
{
    static void Main()
    {
        Recurse(3);
        //Recurse(3000000);   // error stack overflow(over the limit) - mega recursion 


        //GC.Collect();
        //var c1 = new CountingClass();
        //var c2 = new CountingClass();
        //var c3 = new CountingClass();
        //var c4 = new CountingClass();
        //var c5 = new CountingClass();
        //GC.Collect();
        //c4 = null; // error for value type stack
    }
    static void Recurse(int i)      //recursions - good for tree data structures
    {
        CountingClass c = new CountingClass();
        if (i == 0)
            return;
        Recurse(i - 1);
    }
}