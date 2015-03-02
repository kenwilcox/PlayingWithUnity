using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingWithUnity.Implementation;
using Microsoft.Practices.Unity;
using PlayingWithUnity.Interface;

namespace PlayingWithUnity
{
  class Program
  {
    static void Main(string[] args)
    {
      // Configure
      var container = new UnityContainer();
      container.RegisterType(typeof (IDataFetcher), typeof (DataFetcher));
      container.RegisterType(typeof (ITransformer), typeof (Transformer));

      // Run it
      var obj = container.Resolve<Report>();
      obj.Execute();

      Console.ReadKey();
    }
  }
}
