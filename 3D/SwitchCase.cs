using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCase : MonoBehaviour
{
    float speed = 5.5f;
    
    
    void Start()
    {
        switch (speed)
        {
            case 10.3f: Debug.Log("Araç Çok Hızlı"); break;
            case 5.5f: Debug.Log("Araç Orta Hızda"); break;
            default: Debug.Log("Araç Çok Yavaş"); break;
        }   
    }


    
    void Update()
    {
        
    }
}
