using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Değişkenler : MonoBehaviour

// Bu bizim global kısmımız süslü parantezimiz
// Bir değişken iki farklı parantezde olacaksa ortak oldukları paranteze tanımlanmalı
{
    int speed;
    
    string model = "BMW";
    
    void Start()
    {
        speed = 10;
        
        Debug.Log("Aracın modeli: " + model);
         
    }

    
    void Update()
    {
        Debug.Log("Aracın hızı: " + speed);
    }
}
