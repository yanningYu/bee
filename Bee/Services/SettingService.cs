using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bee.Interfaces;

using Microsoft.Extensions.Configuration;

namespace Bee.Services
{
    public class SettingService: ISettingService
    {
        private readonly IConfiguration config;

        public SettingService(IConfiguration config)
        {
            this.config = config;
        }
        public Dictionary<string, int> InitBeeDic()
        {
            var beeDic = new Dictionary<string, int>();

            this.config.GetSection("Bees")?.GetChildren()?.Select(x => x.Value)?.ToList().ForEach(
                x =>
                {
                    var array = x.Split(":");
                    if (int.TryParse(array[1].Trim(), out var number))
                    {
                        beeDic.TryAdd(array[0].Trim(), number);
                    }
                });

            return beeDic;
        }
    }
}
