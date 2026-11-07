using System.Collections.Generic;
using UnityEngine;

public class ToggleGameobjectOnShot : MonoBehaviour
{
	public List<GameObject> Objects;

	public bool OnlyOnce;

	public bool StartState;

	private bool hasBeenToggled;

	private void Awake()
	{
	}

	private void BallOnOnShoot(Vector3 vector3)
	{
	}
}
