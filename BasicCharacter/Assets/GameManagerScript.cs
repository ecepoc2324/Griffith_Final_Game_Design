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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text="score is" + score;

      if(Input.GetKeyDown("escape"))
      {
        pauseMenu.SetActive(true);
      }  
    }

    public void AddScore()
    {
        score=score+1;
    }
}
