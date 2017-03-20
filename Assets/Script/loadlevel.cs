using UnityEngine;
using System.Collections;

public class loadlevel : MonoBehaviour {

	public string levelName;
	void update (){
		Cursor.visible = true;
		Screen.lockCursor = true;
	}
	//Update is called once per frame
	public void LoadLevelNow (string x) {
		Application.LoadLevel (x);
	}
}