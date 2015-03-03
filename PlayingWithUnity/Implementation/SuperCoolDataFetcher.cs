using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingWithUnity.Interface;

namespace PlayingWithUnity.Implementation
{
  /// <summary>
  /// This is my SuperCoolDataFetcher class
  /// </summary>
  public class SuperCoolDataFetcher : IDataFetcher
  {
    public IEnumerable<string> Fetch()
    {
      return new List<string> { "This", "Is", "A", "Super", "Cool", "Test" };
    }
  }
}
