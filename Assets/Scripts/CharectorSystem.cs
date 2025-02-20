using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharectorSystem : MonoBehaviour
{
    public bool isLockedCharector;
    public GameObject lockpanel;
    public TextMeshProUGUI pointtext;
    public Button left, right;
    public int currentcountcharector;
    public Image charectorimg;
    public Charector[] charectors;

    void Start()
    {
        left.onClick.AddListener(LeftClick);

        right.onClick.AddListener(RightClick);
        charectorimg.sprite = charectors[currentcountcharector].img;
    }

    private void LeftClick()
    {
        if(currentcountcharector == 0)
        {
            currentcountcharector = charectors.Length - 1;
            currentcountcharector %= charectors.Length;
        }
        else
        {
            currentcountcharector--;
            currentcountcharector %= charectors.Length;
        }
        charectorimg.sprite = charectors[currentcountcharector].img;
    }

    private void RightClick()
    {
        currentcountcharector++;
        currentcountcharector %= charectors.Length;
        charectorimg.sprite = charectors[currentcountcharector].img;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("HightScore") >= charectors[currentcountcharector].scoretounlock)
        {
            isLockedCharector = false;
            lockpanel.SetActive(false);
        }
        else
        {
            pointtext.text = (PlayerPrefs.GetInt("HightScore").ToString() + " / " + charectors[currentcountcharector].scoretounlock);
            isLockedCharector = true;
            lockpanel.SetActive(true);
        }
    }


    
}
[Serializable]public class Charector
{
    public Sprite img;
    public int scoretounlock;
}

