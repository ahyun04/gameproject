using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileControlle : MonoBehaviour
{
    public GameObject Projectile;

    public void FireProjectile()
    {
        GameObject temp = (GameObject)Instantiate(Projectile);

        temp.transform.position = this.gameObject.transform.position;

        temp.GetComponent<ProejectileMove>().launchDirection = transform.forward;

        Destroy(temp, 10.0f);
            

    }
}
