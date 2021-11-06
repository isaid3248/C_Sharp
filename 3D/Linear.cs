using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linear : MonoBehaviour
{ 
	public Transform target;
	void Start () {
		
	}
	
	
	void Update () {
	 
		transform.position = Vector3.Lerp(transform.position, target.position, .2f); 
	 // Lerp, linear interpolation yapar. Bu da hareketin kademeler halinde yapılmasını sağlar.
	 // ( "Hangi noktadan gidilecek" , "Hangi noktaya gideceğim" , "Hangi oranlarda gideceğim")
	 // 1f = %100 yani adım atmadan gider.
	
	 // transform.position = target.position;
	
	}
	
}
