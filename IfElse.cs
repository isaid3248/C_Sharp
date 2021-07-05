using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    float speed = 10.2f;
    
    
    void Start()
    {
        if (speed >= 10.3f)
        {
            Debug.Log("Araç Çok Hızlı !");
        }
        else if (speed >= 5.5f)
        { 
            Debug.Log("Araç Orta Hızda.");
        }
        else
        {    
            Debug.Log("Araç Orta Hızda.");
        }    
    }


    
    void Update()
    {
        
    }
}
