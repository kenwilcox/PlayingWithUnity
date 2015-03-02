using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingWithUnity.Interface;

namespace PlayingWithUnity.Implementation
{
  public class DataFetcher: IDataFetcher
  {
    public IEnumerable<string> Fetch()
    {
      return new List<string> {"This", "Is", "A", "Test"};
    }
  }
}
