using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class JetpackJoyrideChallenge : MonoBehaviour
{
	public Rigidbody2D EndChecker;

	public float Length = 1f;

	public int Countdown = 1;

	private List<Vector3> startPositions;

	private List<Rigidbody2D> objectsToMove;

	public void Spawn(Vector3 position)
	{
		base.transform.position = position;
		if (startPositions == null)
		{
			objectsToMove = base.gameObject.GetComponentsInChildren<Rigidbody2D>().ToList();
			startPositions = new List<Vector3>();
			foreach (Rigidbody2D item in objectsToMove)
			{
				startPositions.Add(item.position);
			}
		}
		else
		{
			for (int i = 0; i < objectsToMove.Count; i++)
			{
				objectsToMove[i].transform.position = startPositions[i];
			}
		}
		base.gameObject.SetActive(true);
	}

	public void Move(float speed, Vector2 endPosition, Action endReached)
	{
		Vector2 vector = Vector2.left * speed * Time.deltaTime;
		foreach (Rigidbody2D item in objectsToMove)
		{
			item.MovePosition(vector + item.position);
		}
		if (EndChecker.position.x < endPosition.x)
		{
			endReached();
			base.gameObject.SetActive(false);
		}
	}
}
