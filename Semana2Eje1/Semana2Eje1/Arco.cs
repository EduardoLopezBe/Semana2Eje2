using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2Eje1
{
    internal class Arco : ArmaDistancia
    {
        public Arco(string name, float damage, float attackSpeed, float price, Flecha flecha)
        {
            this.name = name;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
            this.proyectiles = flecha;
        }
    }
}
