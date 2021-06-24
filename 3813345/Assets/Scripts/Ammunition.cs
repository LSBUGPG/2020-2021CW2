using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammunition : MonoBehaviour
{
    public Text magazinesTxt;
    public Text bulletsTxt;
    public int bulletsPerMagazine;
    public bool noAmmo;

    private int magazineAmmount = 5;
    private int bulletAmmount = 0;

    private void Start()
    {
        magazinesTxt.text = magazineAmmount.ToString();
        bulletsTxt.text = bulletAmmount.ToString();
    }

    public void CollectAmmunition()
    {
        magazineAmmount += 1;
        magazinesTxt.text = magazineAmmount.ToString();
    }

    public void Reload()
    {
        if (magazineAmmount > 0)
        {
            bulletAmmount = bulletsPerMagazine;
            bulletsTxt.text = bulletAmmount.ToString();
            magazineAmmount -= 1;
            magazinesTxt.text = magazineAmmount.ToString();
            return;
        }
        Debug.Log("There are no magazines left");
        
    }

    public virtual void Shoot()
    {
        if (bulletAmmount <= 0)
        {
            Debug.Log("No Ammo");
            noAmmo = true;
            return;
        }
        bulletAmmount -= 1;
        bulletsTxt.text = bulletAmmount.ToString();
        noAmmo = false;
    }


}
