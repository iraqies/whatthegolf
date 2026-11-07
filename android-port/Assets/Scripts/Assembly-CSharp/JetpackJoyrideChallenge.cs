using System;
using System.Collections.Generic;
using UnityEngine;

public class JetpackJoyrideChallenge : MonoBehaviour
{
	public Rigidbody2D EndChecker;

	public float Length;

	public int Countdown;

	private List<Vector3> startPositions;

	private List<Rigidbody2D> objectsToMove;

	public void Spawn(Vector3 position)
	{
	}

	public void Move(float speed, Vector2 endPosition, Action endReached)
	{
	}
}
