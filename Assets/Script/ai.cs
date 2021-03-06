﻿using UnityEngine;
using System.Collections;

public class ai : MonoBehaviour {

	public float fpsTargetDistance;
	public float enemylookDistance;
	public float attackDistance;
	public float enemyMovementSpeed;
	public float damping;
	public Transform fpsTarget;
	Rigidbody theRigidbody;
	public Renderer myRender;
	private bool playerSafe;


	// Use this for initialization
	void Start () {
		theRigidbody = GetComponent<Rigidbody> ();
		fpsTarget = GameObject.FindWithTag ("Player").GetComponent<Transform> ();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		fpsTargetDistance = Vector3.Distance (fpsTarget.position, transform.position);

		if (fpsTargetDistance < enemylookDistance ) 
		{
			playerSafe = fpsTarget.gameObject.GetComponent<SafeZone> ().isSafe;
			if (!playerSafe) 
			{
				myRender.material.color = Color.yellow;
				lookAtPlayer ();

			}
		}
		if (fpsTargetDistance < attackDistance && !playerSafe) {
			myRender.material.color = Color.red;
			attackPlease ();

		} 
		else 
		{
			myRender.material.color = Color.blue;

		}

	}



	void lookAtPlayer(){
		Quaternion rotation = Quaternion.LookRotation (fpsTarget.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}

	void attackPlease(){
		Vector3 moveToPlayer = transform.forward;
		moveToPlayer.y = 0.0f;
		theRigidbody.MovePosition(transform.position + moveToPlayer * enemyMovementSpeed * Time.deltaTime);
	}

	void update()
	{
		
		//		Vector3 spaceinbetween = (playerposx - newposx, playerposy - newposy, playerposz - newposz);
		//		Vector3 travel = spaceinbetween / (Mathf.Abs(spaceinbetween);
		//			(1,1,0
	}
}
