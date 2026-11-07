using System.Collections.Generic;
using Core;
using UnityEngine;

public class ToggleObjectOnOutOfBounds : MonoBehaviour
{
	public List<GameObject> ObjectToToggle;

	private void Start()
	{
	}

	private void Ball_OnReset()
	{
	}

	private void OnOutOfBounds(GolfBallController c, string msg, Level.State state)
	{
	}
}
