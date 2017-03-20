using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour {

	public Light sun;
	public float modifier;
	public bool hasLeft;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(Vector3.right * (5f * Time.deltaTime));
		if (hasLeft) 
		{
			sun.intensity += modifier * Time.deltaTime;
			if (sun.intensity >= 1) 
			{
				sun.intensity = 1;
			}
		}


	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "LightSwitch") 
		{
			hasLeft = false;

		}
	}

	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "LightSwitch") 
		{

			sun.intensity -= modifier * Time.deltaTime;
			if (sun.intensity == 0) 
			{
				sun.intensity = 0;
			}
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "LightSwitch") 
		{
			hasLeft = true;

		}
	}
}


