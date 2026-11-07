using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OverworldArea : MonoBehaviour
{
	[Serializable]
	public class BridgeConnection
	{
		public OverworldBridgeIndicator bridge;

		public bool hasButton;

		[SerializeField]
		public Transform bridgepoint;

		[SerializeField]
		public OverworldIslandWall wall;

		[SerializeField]
		public OverworldButton button;
	}

	[CompilerGenerated]
	private Action<OverworldArea, OverworldButton> m_OnOpenBridge;

	public string description;

	public List<BridgeConnection> connectedBridges;

	[SerializeField]
	private Transform cameraTarget;

	[SerializeField]
	private BoxCollider borderPrefab;

	[SerializeField]
	private OverworldButton buttonPrefab;

	[SerializeField]
	private BoxCollider ground;

	private float wallWidth;

	private float bridgeWidth;

	public event Action<OverworldArea, OverworldButton> OnOpenBridge
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Awake()
	{
	}

	private void Bridge_OnChangeCount(BridgeConnection bridgeConnection)
	{
	}

	private void Button_OnPress(OverworldButton button, BridgeConnection bridgeConnection)
	{
	}

	private void Bridge_OnOpen(BridgeConnection bridgeConnection)
	{
	}

	public void GenerateIsland()
	{
	}

	private void MakeBridgeConnector(GeneratedIsland island)
	{
	}

	private void MakeWalls(GeneratedIsland island)
	{
	}

	private float distToClosestBridge(Vector3 start, Vector3 end, out BridgeConnection outBridge)
	{
		outBridge = null;
		return 0f;
	}

	private void MakeWall(string name, GeneratedIsland island, Vector3 start, Vector3 end)
	{
	}

	private Transform MakeWallObject(GameObject wallContainer, Vector3 start, Vector3 end)
	{
		return null;
	}

	public Vector3 GetCameraTarget(Vector3 pos)
	{
		return default;
	}

	public static Vector3 NearestPointOnLine(Vector3 a, Vector3 b, Vector3 point)
	{
		return default;
	}
}
