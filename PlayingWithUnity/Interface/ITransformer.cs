using System.Collections.Generic;

namespace PlayingWithUnity.Interface
{
  public interface ITransformer
  {
    string Transform(IEnumerable<string> data);
  }
}