using models;
using System;

namespace ConsoleApp4POOPolimorfismo
{
    /// <summary>
    /// the keyword new is for hide the warning
    /// NEW: puedes usar el method desde la clase derivada pero no desde la clase padre, la clase padre usara el method que esta en clase padre
    /// NEW: sirve para omitir el warning: warning CS0108: 'DerivedClass.Method2()' hides inherited member 'BaseClass.Method2()'. Use the new keyword if hiding was intended.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass base1 = new BaseClass();
            DerivedClass derived1 = new DerivedClass();
            BaseClass baseToDerived = new DerivedClass();


            Console.WriteLine($"base1 Method1: {base1.Method1()}");
            Console.WriteLine($"base1 Method2: {base1.Method2()}");
            Console.WriteLine();
            Console.WriteLine($"derived Method1 {derived1.Method1()}");
            Console.WriteLine($"derived Method2 {derived1.Method2()}");
            Console.WriteLine();
            Console.WriteLine($"baseToDerived Method1: {baseToDerived.Method1()}");
            Console.WriteLine($"baseToDerived new Method2: {baseToDerived.Method2()}");
            Console.WriteLine($"baseToDerived overrideMethod3: {baseToDerived.Method3()}");
        }
    }
}
