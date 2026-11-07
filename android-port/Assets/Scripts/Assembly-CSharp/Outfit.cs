using System;
using UnityEngine;

[Serializable]
public class Outfit
{
	public Material material;

	public GameObject prop;

	public Vector3 relativePosition;

	public Vector3 relativeRotation;

	public Vector3 relativeScale;

	public Transform parent;
}
