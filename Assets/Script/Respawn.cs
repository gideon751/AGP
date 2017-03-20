using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour {
	public string sceneName;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			SceneManager.LoadScene(1);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
