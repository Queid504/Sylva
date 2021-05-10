using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roomRunner4 : MonoBehaviour
{
    int spellNo;
    int soundNo;
    int animNo;
    public float sliderAmount;
    public ParticleSystem spellEmit;
    public GameObject[] spells;
    public GameObject[] animCycle;
    public AudioSource[] sounds;
    public GameObject finishedPlant;
    public GameObject ungrownPlant;
    public GameObject nextPlant;

    void Start()
    {
        spellNo = 0;
    }

    void Update()
    {
        spellOrder();
    }
    void nextSpell()
    {
        //spell code
        spells[spellNo].SetActive(false);
        spellNo ++;
        spells[spellNo].SetActive(true);
        //particle
        spellEmit.Play();
        //soundplayer
        soundNo ++;
        if(soundNo > 4)
        {
            soundNo = 0;
        }
        sounds[soundNo].Play();
        //cycleAnime
        if(spellNo == spells.Length/3)
        {
            nextAnim();
        }
        if(spellNo == spells.Length/3 * 2)
        {
            nextAnim();
        }
        //endAnime
        if(spellNo == spells.Length - 1)
        {
            spellEmit.Stop();
            animCycle[animNo].SetActive(false);
            sounds[0].Play();
            sounds[1].Play();
            sounds[2].Play();
            sounds[3].Play();
            sounds[4].Play();
            nextLevelActive();
        }
    }
    void nextAnim()
    {
        animCycle[animNo].SetActive(false);
        animNo ++;
        animCycle[animNo].SetActive(true);
    }
    void nextLevelActive()
    {
        //Sets this ungrown plant to false
        ungrownPlant.SetActive(false);
        //Sets this plant to finished state
        finishedPlant.SetActive(true);
        finishedPlant.GetComponent<BoxCollider>().enabled = true;
        //Sets next plant true & box collider true & RGB = 1,1,1
        nextPlant.GetComponent<BoxCollider>().enabled = true;
        nextPlant.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
    }
    void spellOrder()
    {
        //List of All Spells
        if (GameObject.FindGameObjectWithTag("Refresh") != null && Input.GetKeyDown(KeyCode.D))
        {
            nextSpell();
        }
        if (GameObject.FindGameObjectWithTag("Soothe") != null && Input.GetKeyDown(KeyCode.G))
        {
            nextSpell();
        }
        if (GameObject.FindGameObjectWithTag("Sun") != null && Input.GetKeyDown(KeyCode.S))
        {
            nextSpell();
        }
        if (GameObject.FindGameObjectWithTag("Water") != null && Input.GetKeyDown(KeyCode.A))
        {
            nextSpell();
        }
        if (GameObject.FindGameObjectWithTag("Nuture") != null && Input.GetKeyDown(KeyCode.F))
        {
            nextSpell();
        }
        if (GameObject.FindGameObjectWithTag("Wave") != null && Input.GetKeyDown(KeyCode.X))
        {
            nextSpell();
        }
        
    }
}
