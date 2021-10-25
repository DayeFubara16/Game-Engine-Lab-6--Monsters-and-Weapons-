using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class Hammer : _Weapon
    {
        private int damage;
        private int freezeTime;

        private static int hammerCounter = 0;

        public Hammer(int damage, int freezeTime)
        {
            this.damage = damage;
            this.freezeTime = freezeTime;

            hammerCounter += 1;
        }

        public override _Weapon Clone()
        {
            return new Hammer(damage, freezeTime);
        }

        public override void Talk()
        {
            Debug.Log($"Hello this is Hammer number {hammerCounter}. My damage is {damage} and my freeze time is {freezeTime}");
        }
    }
}