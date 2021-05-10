using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ImageManager : MonoBehaviour
{
    public GameObject[] storyImages;
    public int buttonCounter; 
    public GameObject mainRoom;

    void Start()
    {
        buttonCounter = 0;
        print(storyImages.Length);
    }
    void Update() 
    {
        if(Input.GetMouseButtonDown(0)){
        storyImages[buttonCounter].SetActive(false);
        buttonCounter++;
        storyImages[buttonCounter].SetActive(true);}   
        nextRoom();
    }
    void nextRoom()
    {
        if(buttonCounter == storyImages.Length - 1)
        {
            mainRoom.SetActive(true);
            buttonCounter = 0;
            Destroy(this.gameObject);
        }
    }
}
