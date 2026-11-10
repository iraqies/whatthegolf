using System;
using UnityEngine;

[ExecuteInEditMode]
public class OverworldID : MonoBehaviour
{
	public string ID;

	public string id
	{
		get => ID;
		set => ID = value;
	}

	private static System.Random random;

	private void OnEnable()
	{
	}

	public string GenerateId(int length)
	{
		return ID;
	}

	public override string ToString()
	{
		return ID;
	}
}
