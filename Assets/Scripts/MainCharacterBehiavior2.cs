using UnityEngine;
using System.Collections;

public class MainCharacterBehiavior2 : MonoBehaviour
{
	
	// Update is called once per frame
	void Update ()
	{
		if( Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) )
			iTween.MoveBy(gameObject, transform.right * -2f, 3f);
		else if( Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) )
			iTween.MoveBy(gameObject, transform.right * 2f, 3f);
		
		if( Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) )
			iTween.MoveBy(gameObject, transform.up * 2f, 3f);
		
		if( Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) )
			iTween.MoveBy(gameObject, transform.up * -2f, 3f);
		
	}
}
