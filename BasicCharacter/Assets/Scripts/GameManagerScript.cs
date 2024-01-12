using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public TMP_Text scoreText;
    public int score;
    public TMP_Text congratulations;

    public GameObject[] pickUps;
    public int pickUp;
    public int numberofPickForInvincibility;

    // Start is called before the first frame update
    void Start()
    {
      pickUps=GameObject.FindGameObjectsWithTag("PickUp"); 
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text="score is" + score;

      if(Input.GetKeyDown("escape"))
      {
        pauseMenu.SetActive(true);
      }  

      if(pickUp==numberofPickForInvincibility)
      {
        congratulations.gameObject.SetActive(true);
        congratulations.text = "Congratulations";
        pickUp=0;
      }  

    }

    public void AddScore()
    {
        score=score+1;
    }
}
