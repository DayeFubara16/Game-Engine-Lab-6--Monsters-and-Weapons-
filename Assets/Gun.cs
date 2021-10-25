using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class Gun : _Weapon
    {
        private int damage;
        private int freezeTime;

        private static int gunCounter = 0;

        public Gun(int damage, int freezeTime)
        {
            this.damage = damage;
            this.freezeTime = freezeTime;

            gunCounter += 1;
        }

        public override _Weapon Clone()
        {
            return new Gun(damage, freezeTime);
        }

        public override void Talk()
        {
            Debug.Log($"Hello this is Gun number {gunCounter}. My damage is {damage} and my freeze time is {freezeTime}");
        }
    }
}
