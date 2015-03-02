using System.Collections.Generic;
using System.Linq;
using PlayingWithUnity.Interface;

namespace PlayingWithUnity.Implementation
{
  public class Transformer: ITransformer
  {
    #region ITransformer Members

    public string Transform(IEnumerable<string> data)
    {
      string ret = data.Aggregate("", (current, item) => current + (item.ToUpper() + " "));
      return ret.TrimEnd(new char[] {' '});
    }

    #endregion
  }
}
