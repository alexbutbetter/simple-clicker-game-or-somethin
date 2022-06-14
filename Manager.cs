using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
  public GameObject canvas;
  public GameObject canvas1;

  public Sprite defaultcharacter;
  public Sprite character1;
  public Sprite character2;
  public Image ObjectwithImage;
  public SpriteRenderer spriteRenderer;

  [SerializeField]
  GameObject objectToDestroy;
  [SerializeField]
  GameObject objectToDestroy2;
  [SerializeField]
  GameObject objectToDestroy3;
  [SerializeField]
  GameObject objectToDestroy4;
  [SerializeField]
  GameObject objectToDestroy5;

  public Text ui;
  public Text highScore;
  
  void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

  public void Increment()
  {
    PlayerManager.o2 += PlayerManager.multiplier;
    PlayerPrefs.SetInt("o2", PlayerManager.o2);
  }

  public void Buy(int num)
  {
    if(num == 1 && PlayerManager.o2 >= 25)
    {
        PlayerManager.multiplier += 1;
        PlayerManager.o2 = PlayerManager.o2 - 25;
        Destroy (objectToDestroy);
    }

    if(num == 2 && PlayerManager.o2 >= 125)
    {
        PlayerManager.multiplier += 10;
        PlayerManager.o2 = PlayerManager.o2  - 125;
        Destroy (objectToDestroy2);
    }

    if(num == 3 && PlayerManager.o2 >= 1025)
    {
        PlayerManager.multiplier += 100;
        PlayerManager.o2 = PlayerManager.o2  - 1025;
        Destroy (objectToDestroy3);
    }
    
    if(num == 4 && PlayerManager.o2 >= 0)
    {
        ObjectwithImage.sprite = defaultcharacter;
    }

    if(num == 5 && PlayerManager.o2 >= 10000)
    {
        ObjectwithImage.sprite = character1;
        PlayerManager.multiplier += 1000;
        PlayerManager.o2 = PlayerManager.o2 - 10000;
        
    }

    if(num == 6 && PlayerManager.o2 >= 50000)
    {
        ObjectwithImage.sprite = character2; 
        PlayerManager.multiplier += 10000;
        PlayerManager.o2 = PlayerManager.o2 - 50000;
    }

    if(num == 7 && PlayerManager.o2 >= 50000)
    {
        PlayerManager.multiplier += 100000;
        PlayerManager.o2 = PlayerManager.o2 - 50000;
        Destroy (objectToDestroy4);
    }

    if(num == 8 && PlayerManager.o2 >= 100000)
    {

        PlayerManager.multiplier += 500000;
        PlayerManager.o2 = PlayerManager.o2 - 100000;
         Destroy (objectToDestroy5);
    }
  }
  
   void Update()
   {
    ui.text = "Monke Points: " + PlayerManager.o2;
    highScore.text = "" + PlayerManager.o2;

   }

   public void Shop()
   {
     canvas.SetActive(true);
     canvas1.SetActive(false);
   }

   public void Shop1()
   {
     canvas.SetActive(false);
     canvas1.SetActive(true);
   }

   

   public void Menu()
   {
     SceneManager.LoadScene(0);
   }
}
