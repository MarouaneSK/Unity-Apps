﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
    bool gameHasEnded = false;
    public float restartDelay = 1;
    public GameObject completeLevelUI;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame() { 

        if(gameHasEnded == false)
        {

            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart",restartDelay);
        }

}

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
