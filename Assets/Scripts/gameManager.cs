using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public GameObject playerPrefab;
    public GameObject player;
    public GameObject astroidPrefab;
    public int score = 0;
    public int lives = 3;
    public bool isPaused = false;
    public List<GameObject> enemyList = new List<GameObject>();
    public int[] enemyArray;

    void Awake()
    {
        if (instance == null)// if the gamemanager is not initiated
        {
            instance = this;// initiates this as the gamemanager
            //DontDestroyOnLoad(this.gameObject);
        }
        else// if there is already a game manager already initiated
        {
            Destroy(this.gameObject);// destroys this gamemanager
            Debug.Log("Warning: A second game manager was detected and destroyed.");// sends an error to the console
        }
    }

    private void Start()
    {
        //gameManager.instance.enemyList.Add(this.gameObject);
        Debug.Log(enemyList.Count + " enemeies active");
    }
   /* public void OnDestroy()
    {
        //gameManager.instance.enemyList.Remove(this.gameObject);
        Debug.Log(enemyList.Count + " enemeies active");
    }*/

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }



    public void Respawn()
    {
        Instantiate(playerPrefab);
    }
}
