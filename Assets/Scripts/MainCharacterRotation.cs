using UnityEngine;
using System.Collections;

public class MainCharacterRotation : MonoBehaviour
{
	void Awake ()
	{
		Application.targetFrameRate = 60;
	}
	// Update is called once per frame
	void Update ()
	{
		//transform.RotateAround( -transform.forward, 0.0005f);
		transform.RotateAround( -transform.forward, Time.smoothDeltaTime*60f* 0.0005f);
	}
}
