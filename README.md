# CSharp.12.Polimorfismo

con herencia un objeto puede mutar su comportamiento a su clase hija
```csharp
BaseClass baseToDerived = new DerivedClass();
```

the keyword new is for hide the warning

NEW: puedes usar el method desde la clase derivada pero no desde la clase padre, la clase padre usara el method que esta en clase padre

NEW: sirve para omitir el warning: warning CS0108: 'DerivedClass.Method2()' hides inherited member 'BaseClass.Method2()'. Use the new keyword if hiding was intended.

```csharp
public new string Method2(){}
```

esta comprensible una vez se haya corrido la app console
