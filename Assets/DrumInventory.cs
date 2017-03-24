using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrumInventory : MonoBehaviour {

	public bool Drum1Collected;
	public GameObject DestroyTarget;
	public Text Drum1Text;
	public GameObject Drum1;

	// Use this for initialization
	void Start () {

		Drum1Collected = false;
		Drum1Text.text = "No Drum";
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void OnTriggerEnter(Collider other) {
		if (Drum1.tag == "Drum1")
			
		{
			Drum1Collected = true;
			DestroyTarget = other.gameObject;
			Destroy (DestroyTarget);

	}
}
}
