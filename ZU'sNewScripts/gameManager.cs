using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour
{
    public float timer;
    public Slider timeIndicator;
    public GameObject rooms;
    public GameObject winState;
    public GameObject failState;
    public GameObject gradient;
    void Start()
    {
        timer = 0;
        timeIndicator.value = 0;
    }
    void Update()
    {
        timer += Time.deltaTime;
        timeIndicator.value = timer;
        loseState();

        if(GameObject.Find("Pug")!= null && 
        GameObject.Find("Chicken")!= null && 
        GameObject.Find("brollic")!= null && 
        GameObject.Find("octopus")!= null && 
        GameObject.Find("sneke")!= null)
        {
            winGame();
        }

    }
    void loseState()
    {
        if(timer >= 92)
        {
            failState.SetActive(true);
            rooms.SetActive(false);
            gradient.SetActive(false);
            //SceneManager.LoadScene(1);
        }
    }
    void winGame()
    {
        gradient.SetActive(false);
        winState.SetActive(true);
        rooms.SetActive(false);
    }
}
