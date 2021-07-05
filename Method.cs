using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour
{
    
    
    void Start()
    {
        SpeedStatus(10.2f);
        SpeedStatus(15.2f);
        SpeedStatus(3.4f);
    }
    
    void SpeedStatus(float speed)
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
            Debug.Log("Araç Yavaş Hızda.");
        }   
    }
}
