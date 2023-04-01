using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer
{
	private Vector3 rotationsRight = new Vector3(0,1,0);
	private Vector3 rotationsLeft = new Vector3(0,-1,0);

	public void MovePlayerMethod(Rigidbody rigidbodyPlayer,
		float speed, float speedRotations, KeyCode forward, KeyCode back,
		KeyCode turnLeft, KeyCode turnRight)
	{
		if (Input.GetKey(forward))
		{
			//rigidbodyPlayer.transform.position += Vector3.forward *
			//	speed * Time.deltaTime;
		}
		if (Input.GetKey(back))
		{
			rigidbodyPlayer.transform.position += Vector3.back *
				speed * Time.deltaTime;
		}

		if (Input.GetKey(turnRight))
		{
			rigidbodyPlayer.transform.Rotate(rotationsRight * 
				speedRotations * Time.deltaTime);
		}
		if (Input.GetKey(turnLeft))
		{
			rigidbodyPlayer.transform.Rotate(rotationsLeft * 
				speedRotations * Time.deltaTime);
		}
	}
}

