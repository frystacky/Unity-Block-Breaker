using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    //config param's
    [SerializeField] int breakableBlocks;       //seralized for debugging purposes

    //cached reference
    ScenceLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<ScenceLoader>();
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if(breakableBlocks <= 0)
        {
            sceneloader.LoadNextScence();
        }
    }
}
