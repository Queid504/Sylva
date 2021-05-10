using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class winLose : MonoBehaviour
{
    public GameObject[] scenes;
    int sceneNo;
    void Start()
    {
        sceneNo = 0;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            scenes[sceneNo].SetActive(false);
            sceneNo++;
            scenes[sceneNo].SetActive(true);
        }
        if(sceneNo == scenes.Length-1)
            {
                Destroy(this);
            }
    }
    
}
