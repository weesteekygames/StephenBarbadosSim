using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPlayerProperties
{
    // Start is called before the first frame update
    struct weapon {
        public int index;
        public string weaponName;
        public string weaponDescription;
        public bool hasWeapon;
        public float damage;
    };
    weapon currentWeapon;
    List<weapon> playerWeapons = new List<weapon>();

    public void populate()
    {
        weapon alienPistol;
        alienPistol.weaponName = "Alien Pistol";
        alienPistol.index = 1;
        alienPistol.damage = 3.0f;
        alienPistol.hasWeapon = false;
        alienPistol.weaponDescription = "This will get the job done.";

        playerWeapons.Add(alienPistol);
        currentWeapon = playerWeapons[0];
    }

    public void pickupWeapon(int weaponIndex)
    {
        for (int i = 0; i < playerWeapons.Count; i++)
        {
            if(playerWeapons[i].index == weaponIndex)
            {
                if (!playerWeapons[i].hasWeapon)
                {
                    weapon newWeapon = new weapon();
                    newWeapon.index = playerWeapons[i].index;
                    newWeapon.hasWeapon = true;
                    newWeapon.weaponDescription = playerWeapons[i].weaponDescription;
                    newWeapon.weaponName = playerWeapons[i].weaponName;

                    playerWeapons[i] = newWeapon;

                    Debug.Log("You picked up " + newWeapon.weaponName);
                }
            }
        }
    }
}
