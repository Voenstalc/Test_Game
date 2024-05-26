using TMPro;
using UnityEngine;
using System;


public class Main : MonoBehaviour
{
    public GameObject text;
    public GameObject text_1;
    private TextMeshProUGUI tm;
    private TextMeshProUGUI tm_1;
    public GameObject Banan;
    
    private void Start()
    {
        tm = text.GetComponent<TextMeshProUGUI>();
        tm_1 = text_1.GetComponent<TextMeshProUGUI>();
        tm.text = Data.Money.ToString();
        tm_1.text = Data.needMoney.ToString();
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
        tm.text = Data.Money.ToString();
        tm_1.text = Data.needMoney.ToString();
    }
}
