using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{ 
//	public GameObject Cube;  (Başka bir object üzerinden yok edeceksek bkz. 15, 16 )
//  public ParticleSystem particleComponent;	(Direkt sadece component yok edeceksek bunu kullanabiliriz. Bkz. 19)
	void Start () {
		}
	
	void Update () {
		if (Input.GetKey(KeyCode.Space))
		{
		    Destroy(GetComponent<ParticleSystem>);
		 //	Destroy(Cube.gameObject);
		 // Destroy(Cube.GetComponent<ParticleSystem>);
		 //	Destroy(gameobject);
		 // Destroy(particleComponent);
		}
	}
	
}
