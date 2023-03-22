using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFight : MonoBehaviour
{
    public int score;
    public Target targetPrefab;

    public void OnTargetHit()
    {
        score += 1;
        SpawnTarget();
    }

    private void SpawnTarget()
    {
        Target newTarget = Instantiate(targetPrefab, Vector3.zero, Quaternion.identity);
    }
}
