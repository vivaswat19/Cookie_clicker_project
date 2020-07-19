using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCount : MonoBehaviour
{
    [SerializeField]
    static int level = 1;

    [SerializeField]
    public static double Exp = 0;
    [SerializeField]
    public GameObject textBox;

    public static double ExpMultiplier = 1.0/30;
    
    void levelUp() 
    {
        if(Exp >= (level*10)) 
        {
            Exp = Exp - (level*10);
            level += 1;
        }
    }
    void Update() 
    {
        levelUp();
        textBox.GetComponent<Text>().text = "Level : " + level;
    }
}
