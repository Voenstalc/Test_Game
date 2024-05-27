using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static int Money = 0;
    public static int dopMoney = 1;
    public static int needMoney = 10;
    public static int AutoMoney = 0;
    public static int NeedAutoMoney = 100;
    public GameObject[] _Banana_Spavns = { };
    public static GameObject[] Banana_Spavns = { };

    private void Start()
    {
        Load();
        Banana_Spavns = _Banana_Spavns;
        InvokeRepeating("Save", 1, 60);
    }
    public void Save()
    {
        PlayerPrefs.SetInt("Money", Money);
        PlayerPrefs.SetInt("dopMoney", dopMoney);
        PlayerPrefs.SetInt("needMoney", needMoney);
        PlayerPrefs.SetInt("AutoMoney", AutoMoney);
        PlayerPrefs.SetInt("NeedAutoMoney", NeedAutoMoney);
        PlayerPrefs.Save();
        Debug.Log("Game data saved!");
    }
    void Load()
    {
        Money = PlayerPrefs.GetInt("Money");
        dopMoney = PlayerPrefs.GetInt("dopMoney");
        needMoney = PlayerPrefs.GetInt("needMoney");
        AutoMoney = PlayerPrefs.GetInt("AutoMoney");
        NeedAutoMoney = PlayerPrefs.GetInt("NeedAutoMoney");
    }
    
}
