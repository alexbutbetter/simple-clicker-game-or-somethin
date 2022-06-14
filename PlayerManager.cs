using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerManager : MonoBehaviour{
  public static int o2;
  public static int multiplier;

  public Text ighScore;

  void Start()
  {
      multiplier = 1;
      o2 = PlayerPrefs.GetInt("o2", 0);
  }

  public void PlayGame(){
    SceneManager.LoadScene(1);
  }

  public void ExitGame(){
    Application.Quit();
  }

  public void Update()
  {
    if (Input.GetKeyDown(KeyCode.R))
    {
      PlayerPrefs.DeleteAll();
    }

    ighScore.text = "" + PlayerManager.o2;

  }
}
