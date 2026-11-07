using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldRoomDoors : MonoBehaviour
{
	[Serializable]
	public class DoorFlipFlopInfo
	{
		public OverworldButton2D door;

		public OverworldMainDoorPlate plate;

		public int offset;
	}

	public List<DoorFlipFlopInfo> doors;

	public float interval;

	private float nextDoor;

	private int doorIndex;

	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}
}
