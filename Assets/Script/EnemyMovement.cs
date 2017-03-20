using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public Transform[] cutscenePos;

	public float lerpTime, lerpTime02, lerpTime03, lerpTime04;

	public float[] currentLerpTime;

	public bool start = false;
	public bool start02 = false;
	public bool start03 = false;
	public bool start04 = false;
	public bool isPlaying = false;

	// Use this for initialization
	void Start () 
	{
		start = true;

	}

	// Update is called once per frame
	void Update ()
	{
		if (start) 
		{


			FirstMove ();
			transform.LookAt (cutscenePos [1]);
		}
		if (start02) 
		{
			SecondMove ();
			transform.LookAt (cutscenePos [2]);
		}
		if (start03) 
		{
			ThirdMove ();
			transform.LookAt (cutscenePos [3]);
		}
		if (start04) 
		{
			FourthMove ();
			transform.LookAt (cutscenePos [0]);
		}

	}

	void lookAtNextPoint(Transform target){
		Quaternion rotation = Quaternion.LookRotation (target.position - transform.position);
		transform.rotation = transform.rotation;
	}

	public void FirstMove()
	{
		print ("moving to second point");
		lookAtNextPoint (cutscenePos[1]);
		currentLerpTime[0] += Time.deltaTime;
		if (currentLerpTime[0] >= lerpTime) 
		{
			currentLerpTime[0] = lerpTime;
			start = false;
			StartCoroutine (FirstWait ());
		}

		float percent = currentLerpTime[0] / lerpTime;
		transform.position = Vector3.Lerp (cutscenePos [0].transform.position, cutscenePos [1].transform.position, percent);


	}
	public IEnumerator FirstWait()
	{
		yield return new WaitForSeconds (Random.Range(0f, 4f));
		start02 = true;
	}


	public void SecondMove()
	{
		lookAtNextPoint (cutscenePos[2]);
		currentLerpTime[1] += Time.deltaTime;
		if (currentLerpTime[1] >= lerpTime02) 
		{
			currentLerpTime[1] = lerpTime02;
			start02 = false;
			StartCoroutine (SecondWait ());
		}

		float percent02 = currentLerpTime[1] / lerpTime02;
		transform.position = Vector3.Lerp (cutscenePos [1].transform.position, cutscenePos [2].transform.position, percent02);
	}

	public IEnumerator SecondWait()
	{
		yield return new WaitForSeconds (Random.Range(0f, 4f));

		start03 = true;
	}

	public void ThirdMove()
	{
		lookAtNextPoint (cutscenePos[3]);
		currentLerpTime[2] += Time.deltaTime;
		if (currentLerpTime[2] >= lerpTime03) 
		{
			currentLerpTime[2] = lerpTime03;
			start03 = false;
			StartCoroutine (ThirdWait ());
		}

		float percent03 = currentLerpTime[2] / lerpTime03;
		transform.position = Vector3.Lerp (cutscenePos [2].transform.position, cutscenePos [3].transform.position, percent03);
	}

	public IEnumerator ThirdWait()
	{
		yield return new WaitForSeconds (Random.Range(0f, 4f));
		start04 = true;

	}

	public void FourthMove()
	{
		lookAtNextPoint (cutscenePos[0]);
		currentLerpTime[3] += Time.deltaTime;
		if (currentLerpTime[3] >= lerpTime03) 
		{
			currentLerpTime[3] = lerpTime04;
			start04 = false;
			StartCoroutine (FourthWait ());

		}

		float percent04 = currentLerpTime[3] / lerpTime04;
		transform.position = Vector3.Lerp (cutscenePos [3].transform.position, cutscenePos [0].transform.position, percent04);
	}

	public IEnumerator FourthWait()
	{
		yield return new WaitForSeconds (Random.Range(0f, 4f));
		start = true;
		for (int i = 0; i < currentLerpTime.Length; i++) {
			currentLerpTime [i] = 0f;
		}

	}

}
