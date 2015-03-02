using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithUnity.Interface
{
  public interface ITransformer
  {
    string Transform(IEnumerable<string> data);
  }
}
