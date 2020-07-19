using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudentCount : MonoBehaviour
{
    public GameObject StudentCountDisplay;
    public static double Students = 0;
    public static double studentMultiplier = 1.0/30;
    void Start()
    {
        Application.targetFrameRate = 30;
        StudentCountDisplay.GetComponent<Text>().text = "Students: " + (int)(Students);
    }
    public void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Students += studentMultiplier;
            LevelCount.Exp += LevelCount.ExpMultiplier;
            StudentCountDisplay.GetComponent<Text>().text = "Students: " + (int)(Students);
        }
        
    }

}
