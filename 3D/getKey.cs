using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getKey : MonoBehaviour 
{ 
	void Start () {
		
	}
	
	
	void Update () {
		bool down = Input.GetKeyDown(KeyCode.Space);   // ilk basıldığı an
		bool held = Input.GetKey(KeyCode.Space);   // Basılı tutulduğu zaman
		bool up = Input.GetKeyUp(KeyCode.Space);   // Elini Çektiğin an

		if (down) {
			Debug.Log("Down");
		}
		else if (held) {
			Debug.Log("Held");
		}
		else if (up) {
			Debug.Log("Up");
		}
		else {
			Debug.Log("Pas touché");
		}
		}
	
}
