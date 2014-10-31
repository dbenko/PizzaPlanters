using UnityEngine;
using System.Collections;

public class Reload : MonoBehaviour {

	

	void Update () {



		// if user presses "r", scene reploads
		if(Input.GetKeyDown(KeyCode.R)){
			
			Application.LoadLevel(0); //or whatever number your scene is
			
		}
	
	}
}
