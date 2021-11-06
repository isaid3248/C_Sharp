using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePassive  : MonoBehaviour
{
    public GameObject myObject;
    // myObject değişkeni hangi objeye etki edecekse o obje değişkene kaydırılacak
    
    void Start()
    {
        myObject.SetActive(true);
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
            myObject.SetActive(false);
        
        if (Input.GetKey(KeyCode.A))
            myObject.SetActive(true);
    
        
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy: " + myObject.activeInHierarchy);
        // İkisi de aynı şey
    }
}
