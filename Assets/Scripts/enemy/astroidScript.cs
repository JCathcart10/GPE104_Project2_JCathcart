using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidScript : MonoBehaviour
{
    private Transform tf; // Create a variable for our transform component
    public float tSpeed; // Create a variable for the degrees we rotate in one frame draw
    public float mSpeed = 5f; // Create a variable for the lateral speed

    void Start()
    {
        tf = GetComponent<Transform>(); // Load our transform component into our variable
        gameManager.instance.enemyList.Add(this.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D otherObject)
    {
        if (otherObject.gameObject == gameManager.instance.player)
        {
            Destroy(otherObject.gameObject);
            Destroy(this.gameObject);          
        }
        
    }

   private void OnDestroy()
    {
        gameManager.instance.enemyList.Remove(this.gameObject);
    }
    void Update()
    {
        tf.position += tf.up * mSpeed * Time.deltaTime;
    }
}
