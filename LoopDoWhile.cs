using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopDoWhile : MonoBehaviour
{
    int[] speed = new int[5] { 5, 6, 7, 8, 9};
    

    void Start()
    {
        
        int i = 0;
    
        do

        // "do" ne olursa olsun ilk işlemin yapılmasını sağlar       
       
        {
            Debug.Log(speed[i]);
            
            i++;        
        
        } while (i < 2);
        
        // Çıktı 5, 6
    
    }


}