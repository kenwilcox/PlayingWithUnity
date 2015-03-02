using System.Collections.Generic;
using PlayingWithUnity.Interface;

namespace PlayingWithUnity.Implementation
{
  public class DataFetcher : IDataFetcher
  {
    public IEnumerable<string> Fetch()
    {
      return new List<string> {"This", "Is", "A", "Test"};
    }
  }
}