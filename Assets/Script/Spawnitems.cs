using UnityEngine;
using System.Collections;

public class Spawnitems : MonoBehaviour {

	public Transform[] SpawnPoints;
	public float SpawnTime = 1.5f;

	//public GameObject Drums;
	public GameObject Drum;
	private GameObject latestDrum;

	// Use this for initialization
	void Start () 
	{
		SpawnDrum ();
	}

	public void SpawnDrum()
	{
		int spawnIndex = Random.Range (0, SpawnPoints.Length);//set the index number of the array randomly

		GameObject clone = Instantiate(Drum, SpawnPoints[spawnIndex].position, SpawnPoints [spawnIndex].rotation) as GameObject;
		latestDrum = clone;
	}

	public void DestroyDrum()
	{
		Destroy (latestDrum);
		SpawnDrum ();
	}
}
