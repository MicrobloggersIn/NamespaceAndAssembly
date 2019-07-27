using System;
using System.Collections.Generic;
using System.Text;

namespace NamespaceAndAssembly.ClassLibrary
{
    public class A
    {
        internal string Message = " public class A internal access message";
        public string Message2 = " public class A public message";

        // Class B and C is accessible in class A due to internal modifier.

        public string GetMessageFromClassB()
        {
            var obj = new B();
            return obj.Message;
        }
        public string GetMessageFromClassC()
        {
            var obj = new C();
            return obj.Message;
        }
    }
}
