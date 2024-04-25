using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2Eje1
{
    internal class Arma
    {
        protected string name;
        protected float damage;
        protected float attackSpeed;

        public virtual float GetDamagePerSecond()
        {
            return damage * attackSpeed;
        }
    }
}
