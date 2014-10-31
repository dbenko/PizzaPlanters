using UnityEngine;
using System.Collections;

public class chefMoves : MonoBehaviour {


	public float chefSpeed = 500f; // movement speed tuning variable
	public float rayLength = 1f;
	
	
	void Update () {
		// make chef walk around pizza
		rigidbody.AddForce ( transform.forward * Time.deltaTime * chefSpeed );
		
		// shoot a raycast rayLength in front of me, if hits crust, turn left or right
		if (Physics.Raycast ( transform.position, transform.forward, rayLength ) ) {
			
			// Mathf.Sign gives value of -1 or 1 based on sign of random range, 
			// easy way to choose left or right movement
			transform.Rotate (0f, Mathf.Sign ( Random.Range (-1f, 1f) ) * 90f, 0f );
		}
		
		// shows ray being shot in front of the object
		Debug.DrawRay ( transform.position, transform.forward * rayLength, Color.green );
	}
}
