using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public folat speed;
    private Rigidbody enemyRb;
    private gameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = getComponent<Rigudbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position 
        - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }

}
