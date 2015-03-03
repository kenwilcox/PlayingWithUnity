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
      // Configure
      var container = new UnityContainer();
      container.RegisterType(typeof (IDataFetcher), typeof (SuperCoolDataFetcher));
      container.RegisterType(typeof (ITransformer), typeof (Transformer));

      // Run it
      var obj = container.Resolve<Report>();
      obj.Execute();

      Console.ReadKey();
    }
  }
}