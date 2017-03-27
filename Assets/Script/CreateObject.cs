using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour {

	public Transform Spawnpoint;
	public GameObject Prefab;
	public float Delay;
	private float spawned;



	void Start () {
		spawned = 0;

	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.gameObject.tag == "Player") 
		{
			SpawnEnemy();
			Invoke ("SpawnEnemy", 0.8f);
			Invoke ("SpawnEnemy", 1.6f);
			Invoke ("SpawnEnemy", 2.4f);
			Invoke ("SpawnEnemy", 3.2f);
				

		}

	}

		public void SpawnEnemy() {

		spawned += 1;

		if (spawned <= 5) {

		Instantiate (Prefab, Spawnpoint.position, Spawnpoint.rotation);

}
	}
	}

