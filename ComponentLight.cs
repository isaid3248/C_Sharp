using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentLight : MonoBehaviour
{
    private Light myLight;
    // Private değişkenlerine sadece aynı Class'takiler ulaaşabilir
    // Bir Component'a ulaşmak istiyorsak o veri tipinde değişken oluşturulur   
    
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled; 
            // '!' Tersini alıyor. Aktifse pasif, pasifse aktif yapıyor        
        }

        if (Input.GetKey(KeyCode.B))
        {
            myLight.color = Color.blue;
        }

        if (Input.GetKey(KeyCode.R))
        {
            myLight.color = Color.red;
        }

    }
}
