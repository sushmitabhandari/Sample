using System;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  public class TestClass
  {
    private int a, b;
    public void SetTheValues(int a, int b)
    {
      this.a = a;
      this.b = b;
    }
    public void GetTheValues(out int a, out int b)
    {
      a = this.a;
      b = this.b;
    }

    public void PrintTheValues()
    {

    }
  }
}
