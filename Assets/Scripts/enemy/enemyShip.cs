using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShip : MonoBehaviour
{
    private Transform tf; // Create a variable for our transform component

    void Start()
    {
        tf = GetComponent<Transform>(); // Load our transform component into our variable
        gameManager.instance.enemyList.Add(this.gameObject);
    }
    private void OnDestroy()

    {
        gameManager.instance.enemyList.Remove(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D otherObject)
    {
        if (otherObject.gameObject == gameManager.instance.Player)
        {
            Destroy(otherObject.gameObject);
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        // fly forward, heat seeking


    }
}
