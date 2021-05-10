using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roomActivate : MonoBehaviour
{
    public GameObject room;
    public GameObject mainRoom;
    GameObject firstPlant;
    void Start()
    {
        firstPlant = GameObject.Find("plant 1");
    }
    private void OnMouseDown()
    {
        if(this.gameObject.name == "Exit")
        {
            SceneManager.LoadScene(0);
            Destroy(this);
        }
        room.SetActive(true);
        mainRoom.SetActive(false);
        if(this.gameObject.tag == "Wave")
        {
            firstPlant.GetComponent<BoxCollider>().enabled = true;
            firstPlant.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
            Destroy(this.gameObject);
        }
    }
}
