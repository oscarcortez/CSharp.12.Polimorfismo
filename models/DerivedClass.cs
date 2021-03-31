using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class DerivedClass : BaseClass
    {
        public string DerivedValue { get; set; }

        public DerivedClass() : base()
        {
            DerivedValue = "DerivedValue";
        }
        public new string Method2()
        {
            return $"DerivedClass - Method2 {DerivedValue}";
        }

        public override string Method3()
        {
            return $"DerivedClass - Method3 {DerivedValue}";
        }
    }
}
