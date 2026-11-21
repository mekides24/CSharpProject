using System;

namespace MethodOverridingVirtualAndOverride
{
    class baseClass
    {
        // show() is 'virtual' here
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }

    // class 'derived' inherits class 'baseClass'
    class derived : baseClass
    {
        // 'show()' is 'override' here
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }

    class Dog
    {
        // Main Method
        static void Main(string[] args)
        {
            // 'obj' is the object of class 'baseClass'
            baseClass obj;
            obj = new baseClass();

            // invokes 'show()' of class 'baseClass'
            obj.show();

            // the same object 'obj' is now the object of class 'derived'
            obj = new derived();

            // invokes 'show()' of class 'derived'
            // ('show()' is overridden via the 'override' modifier)
            obj.show();
        }
    }
}