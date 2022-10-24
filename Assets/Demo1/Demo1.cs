using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Demo1 : MonoBehaviour
{
    public TextMeshProUGUI Txt_Score;

    public Killer killer;//Then drag-drop in demo1 as variable   //#1

    public static Demo1 Instance;

    public float ScoreProperty
    {
        get
        {
            return PlayerPrefs.GetFloat("Score", 0f);
           
        }
        set
        {
            PlayerPrefs.SetFloat("Score", value);
            Txt_Score.text = value.ToString();
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
            
    }

    // Update is called once per frame
    void Update()        //#1
    {
        if (Input.GetMouseButtonDown(0))    //#1
        {
            ThrowTheBullet();               //#1

            Debug.Log("Fire by clicking");//control    //#1
        }
    }

    private void ThrowTheBullet()       //#1
    {

        Debug.Log("ThrowTheBullet");//control     //#1

        killer.Throw();     //#1


    }
}
