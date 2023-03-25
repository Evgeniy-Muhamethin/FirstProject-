using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer
{
	public void MovePlayerMethod(Rigidbody rigidbodyPlayer,
		float speed, KeyCode forward, KeyCode back,
		KeyCode turnLeft, KeyCode turnRight)
	{
		if (Input.GetKey(forward))
		{
			rigidbodyPlayer.transform.position += Vector3.forward *
				speed * Time.deltaTime;
		}
		if (Input.GetKey(back))
		{
			rigidbodyPlayer.transform.position += Vector3.back *
				speed * Time.deltaTime;
		}

		//TODO Переделать на повороты объекта в стороны с кнопок A и B
		if (Input.GetKey(turnRight))
		{
			rigidbodyPlayer.transform.position += Vector3.right *
				speed * Time.deltaTime;
		}
		if (Input.GetKey(turnLeft))
		{
			rigidbodyPlayer.transform.position += Vector3.left *
				speed * Time.deltaTime;
		}
	}
}

