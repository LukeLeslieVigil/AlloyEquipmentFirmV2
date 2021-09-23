﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCollectedText : MonoBehaviour
{
    public GameObject itself;
    public GameObject proteinShake;
    public GameObject shakeText;
    private bool shakeExist = true;
    
    void Update()
    {
        CheckForShake();
    }

    void CheckForShake()
    {
        if (shakeExist)
        {
            if(proteinShake == null)
            {
                shakeText.SetActive(true);
                Destroy(itself, 3);
            }
        }
    }
}
