using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFight : MonoBehaviour
{
    private int score;

    public void OnTargetHit()
    {
        score += 1;
    }
}
