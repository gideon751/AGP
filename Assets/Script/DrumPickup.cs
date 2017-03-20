using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class DrumPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			SceneManager.LoadScene (2);
			Destroy (gameObject);
		}
	}
}
