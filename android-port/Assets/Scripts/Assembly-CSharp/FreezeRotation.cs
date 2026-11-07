using System;
using UnityEngine;

public class FreezeRotation : MonoBehaviour
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
	private Axis axis;

	[SerializeField]
	private Vector3 targetRotation;

	private void Update()
	{
	}
}
