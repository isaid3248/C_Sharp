using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopWhile : MonoBehaviour
{
    int[] speed = new int[5] { 5, 6, 7, 8, 9};
    
// while sadece bir tane parametre alıyor

    void Start()
    {
        
        int i = 0;
    
        while (i < speed.Length)
        {
            Debug.Log(speed[i]);
            
            // "i" speedin kaçıncı parametresi olduğunu gösterir
            
            i++;        
        }
    
    }


}