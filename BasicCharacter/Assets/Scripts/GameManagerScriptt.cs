using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScriptt : MonoBehaviour
{
    public GameObject pauseMenu;
    public TMP_Text scoreText;
    public int score;
    public TMP_Text yay;

    public GameObject[] specialPickups;
    public int specialPickup;
    public int numberofSpecialForInvincibility;
    // Start is called before the first frame update
    void Start()
    {
       specialPickups=GameObject.FindGameObjectsWithTag("SpecialPickup"); 
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text="score is" + score;

      if(Input.GetKeyDown("escape"))
      {
        pauseMenu.SetActive(true);
      }  

      if(specialPickup==numberofSpecialForInvincibility)
      {
        yay.gameObject.SetActive(true);
        yay.text = "yay";
        specialPickup=0;
      }  
    }

     public void AddScore()
    {
        score=score+1;
    }

     public void AddSpecialPickup()
    {
      if(specialPickup<numberofSpecialForInvincibility)
      {
        specialPickup=specialPickup+1;
      }
        
    }
}
