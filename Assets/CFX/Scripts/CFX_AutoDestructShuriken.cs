using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem))]
public class CFX_AutoDestructShuriken : MonoBehaviour
{
	void Update ()
	{
		if(!particleSystem.IsAlive(true))
		{
			GameObject.Destroy(this.gameObject);
		}
	}
}
