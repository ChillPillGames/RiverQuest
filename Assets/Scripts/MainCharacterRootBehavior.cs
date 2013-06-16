using UnityEngine;
using System.Collections;

public class MainCharacterRootBehavior : MonoBehaviour
{
	public Transform COM;
	public Transform COM_pivot;
	float speed = 0.7f;
	public AnimationCurve speedSteps;
	float speedStep = 0.025f;
	float speedStepCount = 0; // Used as speedSteps curve's x axis to calculate speed
	// Use this for initialization
	
	
	void Start ()
	{
		Application.targetFrameRate = 60;
		
		StartCoroutine(IncrementSpeed());
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		//var t0 = Time.realtimeSinceStartup; var t1 = 0f;
		
		rigidbody.centerOfMass = COM.localPosition;
		
		// Apply gravity
		//if(	Mathf.Abs(Input.GetAxis("Vertical")) > 0.1f	)
			rigidbody.AddForce( transform.forward * 1000f * speed * Time.smoothDeltaTime*50f );
		
		//t1 = Time.realtimeSinceStartup; Debug.Log(	(t1-t0)*1000);
		//rigidbody.AddForce(constantForce.);
		
		
	}
	
	IEnumerator IncrementSpeed()
	{
		while(true)
		{
			if( speed <= 1)
			{
				speed = speedSteps.Evaluate( speedStepCount );
				speedStepCount += speedStep;
			}
			yield return new WaitForSeconds(7);
		}
	}
	
	
}
