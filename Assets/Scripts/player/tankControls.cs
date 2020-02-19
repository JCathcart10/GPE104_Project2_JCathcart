using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankControls : MonoBehaviour
{
    private Transform tf; // Create a variable for our transform component
    public float tSpeed; // Create a variable for the degrees we rotate in one frame draw
    public float mSpeed; // Create a variable for the lateral speed
    public GameObject bulletPrefab;
    public Transform firePoint;
    void Start()
    {
        tf = GetComponent<Transform>(); // Load our transform component into our variable
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            tf.Rotate(0.0f, 0.0f, Input.GetAxis("Horizontal") * tSpeed);
        }

        if (Input.GetButton("Vertical"))
        {
            mSpeed = Mathf.Clamp(mSpeed, 0.0f, 1.0f);
            tf.Translate(Input.GetAxis("Vertical") * mSpeed, 0.0f, 0.0f);
           
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

       
    }

    public void die()
    {

/*        gameManager.instance.lives -= 1;//subtracts 1 life

        if (gameManager.instance.lives > 0)// checks if player has lives left
        {
            gameManager.instance.Respawn();//respawns player
        }
        else// if no lives are lete
        {
            Debug.Log("Game Over");//Game Over message
        }
        // Subtract lives here
        Destroy(this.gameObject);*/
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

   
}
