using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    // Bakılan nesnenin Transform özellikleri lazım
    
    void Update()
    {
        transform.LookAt(target);
    //  Nesne nereye bakacak?
    
    // RigidBody constraints lerinden konumunu sabitleyecez
    }
}

// public GameObject target;

//      transform.LookAt(target.transform);
// Birden fazla türe dönüşecekse eğer gameobject ile tanımlamak daha mantıklı