using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)// checks if another object leaves the collider area
    {
        if (other.gameObject == gameManager.instance.player)
        {
            other.gameObject.GetComponent<playerLives>().die();
        }
        /*else if (other.gameObject.tag == "Enemy")
        {
            
        }*/
        else
        {
            Destroy(other.gameObject);// destroys the gameobject that left
        }
    }
}
