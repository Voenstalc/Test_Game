using TMPro;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class Main : MonoBehaviour
{
    public GameObject text;
    public GameObject text_1;
    public GameObject text_2;
    private TextMeshProUGUI tm;
    private TextMeshProUGUI tm_1;
    private TextMeshProUGUI tm_2;
    public GameObject Banan;
    
    private void Start()
    {
        tm = text.GetComponent<TextMeshProUGUI>();
        tm_1 = text_1.GetComponent<TextMeshProUGUI>();
        tm_2 = text_2.GetComponent<TextMeshProUGUI>();
        tm.text = Data.Money.ToString();
        tm_1.text = Data.needMoney.ToString();
        tm_2.text = Data.NeedAutoMoney.ToString();
        InvokeRepeating("AutoMani", 1, 5);
    }
    public void ButtonCliked()
    {
        System.Random random = new System.Random();
        Data.Money += Data.dopMoney;
        tm.text = Data.Money.ToString();
        GameObject newObject = Instantiate(Banan, Data.Banana_Spavns[random.Next(0, Data.Banana_Spavns.Length)].gameObject.transform.position, Quaternion.Euler(0, 0, random.Next(1, 100000)));
    }
    public void Getbonus()
    {
        
        if (Data.needMoney <= Data.Money)
        {
            Data.Money -= Data.needMoney;
            Data.dopMoney += 1;
            Data.needMoney = Data.needMoney * 2;
            tm_1.text = Data.needMoney.ToString();
            tm.text = Data.Money.ToString();
            
        }
    }
    public void Res_Save()
    {
        PlayerPrefs.DeleteAll();
        Data.Money = 0;
        Data.dopMoney = 1;
        Data.needMoney = 10;
        Data.AutoMoney = 0;
        Data.NeedAutoMoney = 100;
        tm.text = Data.Money.ToString();
        tm_1.text = Data.needMoney.ToString();
        tm_2.text = Data.NeedAutoMoney.ToString();
    }
    public void LVL_2()
    {
        if (Data.Money >= 500)
        {
            Data.Money = 0;
            Data.dopMoney = 5;
            Data.needMoney = 20;
            PlayerPrefs.SetInt("Money", Data.Money);
            PlayerPrefs.SetInt("dopMoney", Data.dopMoney);
            PlayerPrefs.SetInt("needMoney", Data.needMoney);
            PlayerPrefs.SetInt("AutoMoney", Data.AutoMoney);
            PlayerPrefs.SetInt("NeedAutoMoney", Data.NeedAutoMoney);
            PlayerPrefs.Save();
            SceneManager.LoadScene("2");
        }
    }
    public void Monkey()
    {
        Data.Money += 10000000;
        tm.text = Data.Money.ToString();
        tm_1.text = Data.needMoney.ToString();
    }
    public void AutoMani()
    {
        Data.Money += Data.AutoMoney;
        tm.text = Data.Money.ToString();
        tm_1.text = Data.needMoney.ToString();
    }
    public void BuyAutoMoney()
    {
        if(Data.Money >= Data.NeedAutoMoney) 
        {
            Data.Money -= Data.NeedAutoMoney;
            Data.AutoMoney += 1;
            Data.NeedAutoMoney = Data.NeedAutoMoney*2;
            tm.text = Data.Money.ToString();
            tm_1.text = Data.needMoney.ToString();
            tm_2.text = Data.NeedAutoMoney.ToString();
        }
    }
}
