using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2Eje1
{
    internal class Espada:ArmaMelee
    {
        public Espada(string name, float damage, float attackSpeed, float price)
        {
            this.name = name;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
        }
    }
}
