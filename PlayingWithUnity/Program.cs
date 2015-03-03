using System;
using Microsoft.Practices.Unity;
using PlayingWithUnity.Implementation;
using PlayingWithUnity.Interface;

namespace PlayingWithUnity
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Bootstrapper.Initialize();

      // Run it
      var obj = Bootstrapper.Container.Resolve<Report>();
      obj.Execute();

      Console.ReadKey();
    }
  }
}