using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public virtual void Movement()
    {
        // Constantly rotate enemy to player & move forward
        transform.LookAt(player.transform.position);
        transform.Translate(Vector3.forward * Time.deltaTime * 4);
    }
}
