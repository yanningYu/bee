using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee.Interfaces
{
    public interface IBee
    {
        int Id {get;set;}
        string Category { get;}
        int Health { get; }

        bool IsDead { get; }

        void Damage();
    }
}
