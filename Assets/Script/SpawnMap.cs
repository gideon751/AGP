using UnityEngine;
using System.Collections;

public class SpawnMap : MonoBehaviour {
	public GameObject map;
	public int spawnNum = 8;
	public float minX, maxX, minY, maxY, minZ, maxZ;

	void spawn()
	{
		for (int i = 0; i < spawnNum; i++) 
		{
			Vector3 mapPos = new Vector3 (Random.Range (minX, maxX), Random.Range (minY, maxY), Random.Range (minZ, maxZ));
			Instantiate (map, mapPos, Quaternion.identity);
		}
	}

	// Use this for initialization
	void Start () {
		spawn ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
