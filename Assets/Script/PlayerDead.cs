using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour {
	public Spawnitems spawnItemsScript;
	public Transform respawnPosition;
	// Use this for initialization
	void Start () 
	{
		
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
			GameOver ();
			Debug.Log("Collision");
		}
	}
}
