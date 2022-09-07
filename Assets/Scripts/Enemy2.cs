using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
    public override void Movement()
    {
        // Constantly rotate enemy to player & move forward
        transform.LookAt(player.transform.position);
        transform.Translate(Vector3.forward * Time.deltaTime * 2);
    }
}
