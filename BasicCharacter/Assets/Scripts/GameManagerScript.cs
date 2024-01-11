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
    public TMP_Text Congratulations;

    public GameObject[] pickUps;
    public int PickUp;
    public int numberofTireForInvincibility;

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

      if(PickUp==numberofTireForInvincibility)
      {
        Congratulations.gameObject.SetActive(true);
        Congratulations.text = "Congratulations";
        PickUp=0;
      }  

    }

    public void AddScore()
    {
        score=score+1;
    }
}
