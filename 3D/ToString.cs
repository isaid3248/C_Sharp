using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToString : MonoBehaviour
{
    int[] speed = new int[5] { 5, 6, 7, 8, 9};
    
    void Start()
    {        
        
        foreach (var item in speed)
        {
            string text = item.ToString();
            // .ToString()  integer değeri string yapıyor
            
            Debug.Log(text);
        }
            
    
    
    
    }


}