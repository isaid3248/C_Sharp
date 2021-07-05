using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeStartMethods : MonoBehaviour
{
    // Awake ve Start sadece bir kez çalışır
    
    void Awake()
    // Awake Start'tan önce çalışır
    // Awake script dosyası işaretli değilken de çalışır, Start çalışmaz
    {
        Debug.Log("Awake");
    }

    void Start()
    {
        Debug.Log("Start");
    }
}
