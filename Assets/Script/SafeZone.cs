using UnityEngine;
using System.Collections;

public class SafeZone : MonoBehaviour 
{
	public bool isSafe;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Safe") 
		{
			isSafe = true;
		}
	}


	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Safe") 
		{
			isSafe = false;
		}
	}
}
