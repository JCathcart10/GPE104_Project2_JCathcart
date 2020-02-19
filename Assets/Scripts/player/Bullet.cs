using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletSpeed = 10f;
    public Transform tf;
    public GameObject playArea;
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //always move forward
        tf.position += tf.right * bulletSpeed * Time.deltaTime;

       
    }

   
}
