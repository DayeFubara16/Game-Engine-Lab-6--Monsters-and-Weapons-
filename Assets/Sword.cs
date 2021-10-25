using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class Sword : _Weapon
    {
        private int damage;
        private int freezeTime;

        private static int swordCounter = 0;

        public Sword(int damage, int freezeTime)
        {
            this.damage = damage;
            this.freezeTime = freezeTime;

            swordCounter += 1;
        }

        public override _Weapon Clone()
        {
            return new Sword(damage, freezeTime);
        }

        public override void Talk()
        {
            Debug.Log($"Hello this is Sword number {swordCounter}. My damage is {damage} and my freeze time is {freezeTime}");
        }
    }
}