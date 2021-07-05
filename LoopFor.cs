using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopFor : MonoBehaviour
{
    int[] speed = new int[5] { 5, 6, 7, 8, 9};
    
    
    void Start()
    {
        
        for (int i = 0; i < speed.Length; i++)
        {
            Debug.Log(speed[i]);
        }
    
    }


}
