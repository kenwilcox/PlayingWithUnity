using System;
using PlayingWithUnity.Interface;

namespace PlayingWithUnity.Implementation
{
  public class Report : IReport
  {
    private readonly IDataFetcher _fetcher;
    private readonly ITransformer _transform;

    public Report(IDataFetcher fetcher, ITransformer transform)
    {
      _fetcher = fetcher;
      _transform = transform;
    }

    #region IReport Members

    public void Execute()
    {
      var fetch = _fetcher.Fetch();
      var output = _transform.Transform(fetch);
      Console.Out.WriteLine(output);
    }

    #endregion
  }
}