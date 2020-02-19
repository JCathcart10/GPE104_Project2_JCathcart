using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLives : MonoBehaviour
{
    public void die()//when the player dies
    {
        gameManager.instance.lives -= 1;//subtracts 1 life

        if (gameManager.instance.lives > 0)// checks if player has lives left
        {
            gameManager.instance.Respawn();//respawns player
        }
        else// if no lives are left
        {
            
            Debug.Log("Game Over");//Game Over message
        }

        Destroy(this.gameObject);
    }
}
