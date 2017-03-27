using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrumInventory : MonoBehaviour {

	public bool Drum1Collected;
	public GameObject DestroyTarget;
	public float DrumCountFloat;
	public Text Drum1Text;
	public Text DrumCount;
	public GameObject Drum1;
	public GameObject Gate1;
	public GameObject Gate2;
	public GameObject Gate3;
	public GameObject Gate4;
	public GameObject Gate5;
	Spin Gate1Script;
	Spin Gate2Script;
	Spin Gate3Script;
	Spin Gate4Script;
	Spin Gate5Script;




	// Use this for initialization
	void Start () {
		// all drums can be drum1
		Drum1Collected = false;
		Drum1Text.text = "No Drum";
		DrumCountFloat = 0;
	}
	
	// Update is called once per frame
	void Update () {
		DrumCount.text = "Drums collected : " + DrumCountFloat.ToString ();
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Drum1")
			
		{
			DrumCountFloat += 1;
			Drum1Collected = true;
			Drum1Text.text = "Drum Collected";
			DestroyTarget = other.gameObject;
			Destroy (DestroyTarget);

	}
		if (other.gameObject.tag == "GateLever1") {
			Drum1Collected = false;
			Drum1Text.text = "No Drum";
			Gate1Script = Gate1.GetComponent<Spin> ();
			Gate1Script.Opened = true;

			//make new GateLever objects, 2,3,4,5......

}
		if (other.gameObject.tag == "GateLever2") {
			Drum1Collected = false;
			Drum1Text.text = "No Drum";
			Gate2Script = Gate2.GetComponent<Spin> ();
			Gate2Script.Opened = true;

			//make new GateLever objects, 2,3,4,5......

		}
}
}
