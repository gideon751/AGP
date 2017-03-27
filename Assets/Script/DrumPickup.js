#pragma strict

public var wall : Collider;

function OnTriggerEnter (info : Collider)
{
	if (info.tag == "Player")
	{
		wall.enabled = false;
		Destroy(gameObject);
	}
}