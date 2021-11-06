using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFixedUpdateMethods : MonoBehaviour
{
    
    // Fizik (RigidBody) gereken şeyler FixedUpdate ile yapılır
    // Geri kalan her şey Update ile yapılabilir
    
    
    void FixedUpdate()
    // Saniyede çağırılma sayısı "Fix"tir.

    
    {
        Debug.Log("FixedUpdate time: " + Time.deltaTime);
    }


    void Update()
    // Çağırılma sayısı sabit değildir.

    {
        Debug.Log("Update time: " + Time.deltaTime);
    }

}
