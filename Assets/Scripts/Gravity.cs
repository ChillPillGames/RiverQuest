using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour
{
	public Transform gravityOrigin;
	public bool AlwaysUpright = true;
	
	void Start()
	{
		gravityOrigin = GameObject.Find("Gravity Origin").transform;
	}
	
	void FixedUpdate ()
	{
		rigidbody.AddForce( -(transform.position-gravityOrigin.position).normalized * 29.8f * Time.fixedDeltaTime*50f, ForceMode.Acceleration );
	}
	
	void Update ()
	{
		if(!AlwaysUpright)
			return;
		transform.up = (transform.position-gravityOrigin.position).normalized;
	}
}
