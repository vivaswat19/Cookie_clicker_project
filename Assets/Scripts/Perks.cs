using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perks : MonoBehaviour
{
    public void studentMultiplier()
    {
        StudentCount.studentMultiplier += 1.0/30;
    }
}
