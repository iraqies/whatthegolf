using System.Collections.Generic;
using UnityEngine;

public class PaintingBlueprint : MonoBehaviour
{
	public Transform PaintPointsContainer;

	public Transform AvoidPointsContainer;

	public GameObject PoseObject;

	private List<Transform> paintPoints;

	public List<Transform> PaintPoints => null;

	public void Activate()
	{
	}

	public void ToggleBlueprint(bool state)
	{
	}

	public void Deactivate()
	{
	}
}
