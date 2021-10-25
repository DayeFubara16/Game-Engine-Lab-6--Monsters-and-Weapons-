using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class SpawnController : MonoBehaviour
    {

        //new code 
        private Gun gunProto;
        private Sword swordProto;
        private Hammer hammerProto; 

        private int weaponSwitcher = 1; 

        private Spawner[] weaponSpawners;


        void Start()
        {

            //new code 
            gunProto = new Gun(10, 0);
            swordProto = new Sword(7, 2);
            hammerProto = new Hammer(5, 7);

            weaponSpawners = new Spawner[] {
                new Spawner(gunProto),
                new Spawner(swordProto),
                new Spawner(hammerProto)
            };

        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && weaponSwitcher == 1)
            {
                //If we know which spawner we are using we can easily cast to the correct monster type
                Spawner gunSpawner = new Spawner(gunProto);

                Gun newGun = gunSpawner.SpawnWeapon() as Gun;

                newGun.Talk();
            }

            else if (Input.GetKeyDown(KeyCode.Space) && weaponSwitcher == 2)
            {
                //If we know which spawner we are using we can easily cast to the correct monster type
                Spawner swordSpawner = new Spawner(swordProto);

                Sword newSword = swordSpawner.SpawnWeapon() as Sword;

                newSword.Talk();
            }

            else if (Input.GetKeyDown(KeyCode.Space) && weaponSwitcher == 3)
            {
                //If we know which spawner we are using we can easily cast to the correct monster type
                Spawner hammerSpawner = new Spawner(hammerProto);

                Hammer newHammer = hammerSpawner.SpawnWeapon() as Hammer;

                newHammer.Talk();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                weaponSwitcher = 1;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                weaponSwitcher = 2;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                weaponSwitcher = 3;
            }
        }
    }
}
