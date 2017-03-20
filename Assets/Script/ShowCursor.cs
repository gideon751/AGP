using UnityEngine;
using System.Collections;

public class ShowCursor : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		//ShowCursor = true;
	}
}
