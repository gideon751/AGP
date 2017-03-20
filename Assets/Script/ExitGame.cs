using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	public void Quit()
	{
		Debug.Log ("Quit");
		Application.Quit();
	}
}
