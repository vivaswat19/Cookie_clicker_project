using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCount : MonoBehaviour
{
    public static int moneyCount = 0;
    public GameObject MoneyDisplay;
    void Start()
    {
        StartCoroutine(moneyIncrement());
    }
    void Update()
    {
        MoneyDisplay.GetComponent<Text>().text = "Money: " + moneyCount + "$";

    }
    private IEnumerator moneyIncrement()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            moneyCount += (int)(StudentCount.Students);
        }
    }

}
