using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaypointFollow : MonoBehaviour
{
	//Transform[] Waypoints;
	public List<Transform> WaypointContainers;
	
	public Transform currentWP;
	
	List<Transform> continuousWaypoints;
	
	int currentWPCount;
	
	float damping = 1f;
	
	void Start ()
	{
		currentWPCount = 0;
//		for(int i=0; i<WaypointContainers[2].childCount; ++i)
//			Debug.Log(WaypointContainers[2].GetChild(i));
		continuousWaypoints = new List<Transform>();
		
		foreach(Transform t in WaypointContainers)
		{
			for(int i=0; i<t.childCount; ++i)
			{
				continuousWaypoints.Add( t.GetChild(i) );
			}
		}
		
//		foreach(Transform t in continuousWaypoints)
//		{
//			Debug.Log(t.name);
//		}
		
		currentWP = continuousWaypoints[0];
	}
	
	// Update is called once per frame
	void Update ()
	{
		//transform.rotation = Quaternion.Slerp( transform.rotation, currentWP.rotation , Time.deltaTime*1f);
		//transform.LookAt(currentWP);
		var rotation = Quaternion.LookRotation(currentWP.position - transform.position);
		Debug.Log( Vector3.Angle(transform.forward, Vector3.up) );
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
		
		transform.Translate( Vector3.forward * Time.deltaTime);
		
		// switching current wp
		if( Vector3.Distance(currentWP.position, transform.position) < 1f)
		{
			if( currentWPCount >= continuousWaypoints.Count - 1)
				currentWPCount = 0;
			else
				++currentWPCount;
			currentWP = continuousWaypoints[currentWPCount];
		}
		
		//var acc = Input.acceleration.x;
		var acc = Input.GetAxis("Horizontal");
		if(acc > 0.1)
		{
		}
		else if(acc < -0.1)
		{
		}
		else
		{
		}
		
	}
}
