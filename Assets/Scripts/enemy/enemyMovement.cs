using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    private Transform tf; // Create a variable for our transform component
    public float tSpeed; // Create a variable for the degrees we rotate in one frame draw
    public float mSpeed; // Create a variable for the lateral speed

    void Start()
    {
        tf = GetComponent<Transform>(); // Load our transform component into our variable
    }
    void Update()
    {
        tf.Rotate(0.0f, 0.0f, tSpeed);
        tf.Translate(mSpeed, 0.0f, 0.0f);
    }
}
