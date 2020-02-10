using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLives : MonoBehaviour
{
    private void OnDestroy()
    {
       gameManager.instance.lives -= 1;

        if (gameManager.instance.lives > 0)
        {
            gameManager.instance.Respawn();
        }
        else
        {
            Debug.Log("Game Over");
        }
    }

}
