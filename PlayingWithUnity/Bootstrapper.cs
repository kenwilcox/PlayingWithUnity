using Microsoft.Practices.Unity;
using PlayingWithUnity.Implementation;
using PlayingWithUnity.Interface;

namespace PlayingWithUnity
{
  public static class Bootstrapper
  {
    public static IUnityContainer Container { get; private set; }

    public static void Initialize()
    {
      Container = BuildUnityContainer();
    }

    private static IUnityContainer BuildUnityContainer()
    {
      // Configure
      var container = new UnityContainer();
      container.RegisterType(typeof(IDataFetcher), typeof(SuperCoolDataFetcher));
      container.RegisterType(typeof(ITransformer), typeof(Transformer));

      return container;
    }
  }
}
