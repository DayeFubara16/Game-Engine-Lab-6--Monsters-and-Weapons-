using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class Spawner
    {
        private _Weapon prototype;
        
        public Spawner(_Weapon prototype)
        {
            this.prototype = prototype;
        }
        
        public _Weapon SpawnWeapon()
        {
            return prototype.Clone();
        }
    }
}
