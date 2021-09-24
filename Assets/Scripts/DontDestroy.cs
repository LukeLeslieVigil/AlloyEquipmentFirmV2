using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject waypoints;

    private void Awake()
    {
        DontDestroyOnLoad(waypoints);
    }
}
