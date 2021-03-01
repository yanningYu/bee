using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bee.Interfaces;

namespace Bee.Services
{
    public class BeeService: IBeeService
    {
        private readonly ISettingService settingService;

        private static List<IBee> Bees = new List<IBee>();

        public BeeService(ISettingService settingService)
        {
            this.settingService = settingService;
        }

        public List<IBee> CreateBees()
        {
            var list = new List<IBee>();
            var dic = this.settingService.InitBeeDic();
            var keys = dic.Keys;
            var index = 0;

            foreach (var key in keys)
            {
                if (dic.TryGetValue(key, out var number))
                {
                    for (var i = 0; i < number; i++)
                    {
                        index++;
                        this.CreateBee(index, key, list);
                    }
                }
            }

            Bees.AddRange(list);
            return list;
        }

        public IBee Damage(int id)
        {
            var beeEntity = Bees.FirstOrDefault(bee => bee.Id == id);
            beeEntity.Damage();
            return beeEntity;
        }

        private void CreateBee(int index, string key, List<IBee> List)
        {
            var entity = (IBee)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(key);
            if (entity == null) return;
            entity.Id = index;
            List.Add(entity);
        }
    }
}
