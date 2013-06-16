using UnityEngine;
using System.Collections;

public class MainCharacterBehavior : MonoBehaviour {
	
	public bool isGrounded = true;
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		// Retrieve and apply inputs
		LateralMotion();
		VerticalMotion();
	}
	void LateralMotion ()
	{
		//var horizontal = Mathf.Abs(Input.GetAxis("Horizontal"));
//		if(	horizontal > 0.1f	)
//		{
//			
//		}
	}
	void VerticalMotion ()
	{
		var vertical = Mathf.Abs(Input.GetAxis("Vertical"));
		if( vertical > 0.1f && isGrounded)
		{
			rigidbody.AddForce( transform.up* 400, ForceMode.Impulse );
		}
	}
	
	void OnCollisionEnter (Collision other)
	{
		//Debug.Log(other.collider.name);
		if(other.collider.CompareTag("Ground"))
			isGrounded = true;
	}
	void OnCollisionExit (Collision other)
	{
		if(other.collider.CompareTag("Ground"))
			isGrounded = false;
	}
}
