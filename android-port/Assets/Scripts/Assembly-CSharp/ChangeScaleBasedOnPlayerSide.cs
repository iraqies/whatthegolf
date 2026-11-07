using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class ChangeScaleBasedOnPlayerSide : MonoBehaviour
{
	[Serializable]
	public class ScaleChange
	{
		public LobbySpawnPoint.SpawnPointPositions Side;

		public Vector3 ScaleMod;
	}

	public List<ScaleChange> ScaleChanges;

	public GolfBallController Controller;

	private void Start()
	{
	}
}
