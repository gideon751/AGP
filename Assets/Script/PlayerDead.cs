using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerDead : MonoBehaviour {
	public Spawnitems spawnItemsScript;
	public Transform respawnPosition;
	public float Health;
	public GameObject DestroyTarget;
	public Text Playerhealth;
	// Use this for initialization
	void Start () 
	{
		Health = 3;
	}
	void Update() {
		Playerhealth.text = "Health: " + Health.ToString ();
	}
	
	// Update is called once per frame
	void GameOver()
	{
		transform.position = respawnPosition.position;
		transform.rotation = respawnPosition.rotation;
		spawnItemsScript.DestroyDrum ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy") {
			other.gameObject.transform.eulerAngles = new Vector3 (0, 0, 0);
			DestroyTarget = other.gameObject;
			Destroy (DestroyTarget);
			Health -= 1;

			if (Health <= 0) {

				GameOver ();
				Debug.Log ("Collision");
			}
		}
	}
}
