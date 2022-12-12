using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    public static WallManager Instance;

    public List<Wall> Walls = new List<Wall>();

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
}
