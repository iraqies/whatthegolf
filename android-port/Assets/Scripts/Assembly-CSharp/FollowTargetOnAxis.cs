using System;
using UnityEngine;

public class FollowTargetOnAxis : MonoBehaviour
{
	[Flags]
	private enum Axis
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 4
	}

	[SerializeField]
	private Transform target;

	[SerializeField]
	private Axis axis;

	private void Update()
	{
	}
}
