using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopForeach : MonoBehaviour
{
    int[] speed = new int[5] { 5, 6, 7, 8, 9};
    
    void Start()
    {        

        //foreach (var item in speed) bu da çalışır
        // "foreach" item değişkenine speedin içindekileri atar
        
        foreach (int item in speed)
        {
            Debug.Log(item);
        }    
        
    
        // "var" değişkenin tipini bilemeyeceğimiz durumlar için 
    
    
    
    }


}