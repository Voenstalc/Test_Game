using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject text;
    public GameObject text_1;
    private TextMeshProUGUI tm;
    private TextMeshProUGUI tm_1;
    private void Start()
    {
        tm = text.GetComponent<TextMeshProUGUI>();
        tm_1 = text_1.GetComponent<TextMeshProUGUI>();
    }
    public void ButtonCliked()
    {
        Data.Money += Data.dopMoney;
        print(tm.text);
        tm.text = Data.Money.ToString();
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
}
