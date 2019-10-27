using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using levelConstants;

public class scrWeaponProperties : MonoBehaviour
{
    // Start is called before the first frame update
    public int weaponIndex;
    
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        levelConstants.scrLevelConstants.PLAYER_PROPS.pickupWeapon(weaponIndex);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
