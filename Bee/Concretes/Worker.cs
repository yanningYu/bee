using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bee.Interfaces;

namespace Bee.Concretes
{
    public class Worker: IBee
    {
        public int Id { get; set; }

        public string Category { get; } = "Worker";

        public int Health { get; private set;} = 100;

        public bool IsDead => this.Health < 20;

        public void Damage()
        {
            if (this.IsDead)
            {
                return;
            }

            var rand = new Random();
            var damage = rand.Next(0, 81);
            this.Health -= damage;

            if (this.Health < 0)
            {
                this.Health = 0;
            }
        }
    }
}
