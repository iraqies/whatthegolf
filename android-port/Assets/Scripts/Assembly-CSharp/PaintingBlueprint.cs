using System.Collections.Generic;
using UnityEngine;

public class PaintingBlueprint : MonoBehaviour
{
	public Transform PaintPointsContainer;

	public Transform AvoidPointsContainer;

	public GameObject PoseObject;

	private List<Transform> paintPoints;

	public List<Transform> PaintPoints
	{
		get
		{
			if (paintPoints == null)
			{
				paintPoints = new List<Transform>(PaintPointsContainer.childCount);
				foreach (Transform item in PaintPointsContainer)
				{
					paintPoints.Add(item);
				}
			}
			return paintPoints;
		}
	}

	public void Activate()
	{
		if (PoseObject != null)
		{
			PoseObject.gameObject.SetActive(true);
		}
		foreach (Transform item in base.transform)
		{
			item.gameObject.SetActive(true);
		}
	}

	public void ToggleBlueprint(bool state)
	{
		PaintPointsContainer.gameObject.SetActive(state);
		if (AvoidPointsContainer != null)
		{
			AvoidPointsContainer.gameObject.SetActive(state);
		}
	}

	public void Deactivate()
	{
		if (PoseObject != null)
		{
			PoseObject.gameObject.SetActive(false);
		}
		foreach (Transform item in base.transform)
		{
			item.gameObject.SetActive(false);
		}
	}
}
