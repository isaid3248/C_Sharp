using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    int[] speed = new int[4] { 5, 6, 7, 8};
//  int[] speed = new int[4];     ("[]" kaç tane = ?)
    
    
//  void Start()
//  {
//      speed[0] = 5;
//      speed[1] = 6;
//      speed[2] = 7;
//      speed[3] = 8;
//  }

    
    void Update()
    {
        Debug.Log(speed[2]);
    }
}