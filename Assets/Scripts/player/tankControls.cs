using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankControls : MonoBehaviour
{
    private Transform tf; // Create a variable for our transform component
    public float tSpeed; // Create a variable for the degrees we rotate in one frame draw
    public float mSpeed; // Create a variable for the lateral speed
    // Use this for initialization
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
            tf.Translate(Input.GetAxis("Vertical") * mSpeed, 0.0f, 0.0f);
            mSpeed = Mathf.Clamp(mSpeed, 0.0f, 1.0f);
        }
       
    }
}
