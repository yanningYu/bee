using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee.Interfaces
{
    public interface IBeeService
    {
        public List<IBee> CreateBees();

        public IBee Damage(int id);
    }
}
