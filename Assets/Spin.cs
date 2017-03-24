using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	public float GateTimer;
	public float DoorOpenMax;
	public bool Opened;



	// Use this for initialization
	void Start () {
		GateTimer = 0;
		DoorOpenMax = 300;
		Opened = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Opened == true) {

			if (GateTimer <= DoorOpenMax) {

			GateTimer += 1;	
			
		transform.Rotate(Vector3.up, -20 * Time.deltaTime);
	}
}
	}
}
