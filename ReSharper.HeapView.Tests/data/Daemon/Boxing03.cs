using System;
// ReSharper disable UnusedParameter.Local

[Foo(42, "aa")]
[Foo(42, new [] { 1 })]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
class Foo : Attribute {
  public Foo(object x, params object[] xs) { }
}