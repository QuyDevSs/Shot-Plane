using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MoveController
{
    public BulletController bulletPrefab;
    protected void Shoot()
    {
        BulletController bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //bullet.Move(transform.up);
    }
}
