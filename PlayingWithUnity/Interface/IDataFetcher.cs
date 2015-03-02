using System.Collections.Generic;

namespace PlayingWithUnity.Interface
{
  public interface IDataFetcher
  {
    IEnumerable<string> Fetch();
  }
}