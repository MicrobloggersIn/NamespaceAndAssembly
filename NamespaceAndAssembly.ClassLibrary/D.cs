using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("NamespaceAndAssembly.ConsoleApp")]

namespace NamespaceAndAssembly.ClassLibrary
{
   
    internal class D
    {
        [assembly:InternalsVisibleTo("NamespaceAndAssembly.ConsoleApp")]
        internal string Message = " internal class D internal access message";
        public string Message2 = " internal class D public message";
    }
}
