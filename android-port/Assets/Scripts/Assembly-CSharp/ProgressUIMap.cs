using System.Collections.Generic;
using Audio;
using UnityEngine;

public class ProgressUIMap : MonoBehaviour
{
	public bool AutoDistributeFlags;

	public List<Transform> MapPoints;

	public ProgressUIFlag FlagTemplate;

	public List<ProgressUIFlag> Flags;

	public ArenaCharacters AssociatedArenaVista;

	public AmbientAudio mapAmbience;

	private float totalDistance;

	private List<Transform> travelPathPoints;

	private void Awake()
	{
		if (Flags == null)
		{
			Flags = new List<ProgressUIFlag>();
		}
		if (travelPathPoints == null)
		{
			travelPathPoints = new List<Transform>();
		}
	}

	public void CreateMapPoints(int points)
	{
		if (Flags == null)
		{
			Flags = new List<ProgressUIFlag>();
		}
		if (travelPathPoints == null)
		{
			travelPathPoints = new List<Transform>();
		}
		travelPathPoints.Clear();
		if (MapPoints != null && MapPoints.Count > 0)
		{
			for (int i = 0; i < Mathf.Min(points, MapPoints.Count); i++)
			{
				travelPathPoints.Add(MapPoints[i]);
			}
		}
		for (int i = 0; i < Flags.Count; i++)
		{
			if (Flags[i] != null)
			{
				Flags[i].Toggle(false);
			}
		}
	}

	public void CompleteFlag(int flagIndex, Color winnerColor)
	{
		if (Flags != null && flagIndex >= 0 && flagIndex < Flags.Count && Flags[flagIndex] != null)
		{
			Flags[flagIndex].Toggle(true);
			Flags[flagIndex].SetColor(winnerColor);
		}
	}

	public Transform GetPathPointForFlagIndex(int index)
	{
		if (travelPathPoints != null && index >= 0 && index < travelPathPoints.Count)
		{
			return travelPathPoints[index];
		}
		if (MapPoints != null && MapPoints.Count > 0)
		{
			return MapPoints[Mathf.Clamp(index, 0, MapPoints.Count - 1)];
		}
		return transform;
	}

	public void ResetMap()
	{
		if (Flags == null)
		{
			return;
		}
		for (int i = 0; i < Flags.Count; i++)
		{
			if (Flags[i] != null)
			{
				Flags[i].Toggle(false);
			}
		}
	}
}
