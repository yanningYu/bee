using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee.Interfaces
{
    public interface ISettingService
    {
        Dictionary<string, int> InitBeeDic();
    }
}
