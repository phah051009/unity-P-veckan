using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    [SerializeField] int bulletsLeft = 30;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bulletsLeft >= 0)
            {
                Shoot();
            }
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletsLeft--;
    }

}
