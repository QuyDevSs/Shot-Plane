using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MoveController
{
    private void Start()
    {
        Destroy(gameObject, 4.0f);
    }
    private void Update()
    {
        base.Move(transform.up);
    }
}
