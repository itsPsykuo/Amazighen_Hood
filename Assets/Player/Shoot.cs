using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPreFab;
    public Animator animator;

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("PreFire", true);
        }

            if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("PreFire", false);
            shoot();
        } 
    }

    void shoot()
    {
        Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);
    }
}
