using System;

namespace models
{
    public class BaseClass
    {
        public string BaseValue { get; set; }

        public BaseClass()
        {
            BaseValue = "BaseValue";
        }

        public string Method1()
        {
            return $"BaseClass - Method1 {BaseValue}";
        }

        public string Method2()
        {
            return $"BaseClass - Method2 {BaseValue}";
        }

        public virtual string Method3()
        {
            return $"BaseClass - Method3 {BaseValue}";
        }
    }
}
