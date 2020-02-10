﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public GameObject playerPrefab;
    public GameObject Player;
    public GameObject astroidPrefab;
    public int score = 0;
    public int lives = 3;
    public bool isPaused = false;
    public List<GameObject> enemyList = new List<GameObject>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
            Debug.Log("Warning: A second game manager was detected and destroyed.");
        }
    }

    private void Start()
    {
        gameManager.instance.enemyList.Add(this.gameObject);
    }
    private void OnDestroy()
    {
        gameManager.instance.enemyList.Remove(this.gameObject);
    }

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
