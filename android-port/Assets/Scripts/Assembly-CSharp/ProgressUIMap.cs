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
	}

	public void CreateMapPoints(int points)
	{
	}

	public void CompleteFlag(int flagIndex, Color winnerColor)
	{
	}

	public Transform GetPathPointForFlagIndex(int index)
	{
		return null;
	}

	public void ResetMap()
	{
	}
}
