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

	private float wallWidth = 3f;

	private float bridgeWidth = 10f;

	public event Action<OverworldArea, OverworldButton> OnOpenBridge
	{
		[CompilerGenerated]
		add
		{
			m_OnOpenBridge = (Action<OverworldArea, OverworldButton>)Delegate.Combine(m_OnOpenBridge, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnOpenBridge = (Action<OverworldArea, OverworldButton>)Delegate.Remove(m_OnOpenBridge, value);
		}
	}

	public void Awake()
	{
		if (connectedBridges == null)
		{
			return;
		}
		for (int i = 0; i < connectedBridges.Count; i++)
		{
			BridgeConnection conn = connectedBridges[i];
			if (conn == null)
			{
				continue;
			}
			if (conn.bridge != null)
			{
				conn.bridge.OnChangeCount += _ => Bridge_OnChangeCount(conn);
				conn.bridge.OnOpen += _ => Bridge_OnOpen(conn);
			}
			if (conn.button != null)
			{
				conn.button.OnPress += btn => Button_OnPress(btn, conn);
			}
			Bridge_OnChangeCount(conn);
			if (conn.bridge != null && conn.bridge.isOpen)
			{
				Bridge_OnOpen(conn);
			}
		}
	}

	private void Bridge_OnChangeCount(BridgeConnection bridgeConnection)
	{
		if (bridgeConnection == null || bridgeConnection.bridge == null)
		{
			return;
		}
		int missing = bridgeConnection.bridge.GetFlagsMissingCount();
		if (bridgeConnection.button != null)
		{
			bridgeConnection.button.SetText(missing > 0 ? missing.ToString() : "");
			bridgeConnection.button.SetBridgeStatus(missing <= 0);
		}
	}

	private void Button_OnPress(OverworldButton button, BridgeConnection bridgeConnection)
	{
		if (bridgeConnection != null && bridgeConnection.bridge != null && bridgeConnection.bridge.CanBeOpened())
		{
			bridgeConnection.bridge.TryOpen(false);
			m_OnOpenBridge?.Invoke(this, button);
		}
	}

	private void Bridge_OnOpen(BridgeConnection bridgeConnection)
	{
		if (bridgeConnection == null)
		{
			return;
		}
		if (bridgeConnection.wall != null)
		{
			bridgeConnection.wall.SetBridgeCollider(true);
		}
		if (bridgeConnection.button != null)
		{
			bridgeConnection.button.SetBridgeStatus(true);
		}
	}

	public void GenerateIsland()
	{
		GeneratedIsland island = GetComponentInChildren<GeneratedIsland>();
		if (island == null)
		{
			GameObject go = new GameObject("GeneratedIsland");
			go.transform.SetParent(transform, false);
			island = go.AddComponent<GeneratedIsland>();
		}
		MakeBridgeConnector(island);
		MakeWalls(island);
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
		float best = float.PositiveInfinity;
		if (connectedBridges == null)
		{
			return best;
		}
		Vector3 mid = (start + end) * 0.5f;
		for (int i = 0; i < connectedBridges.Count; i++)
		{
			BridgeConnection c = connectedBridges[i];
			if (c != null && c.bridgepoint != null)
			{
				float d = Vector3.Distance(mid, c.bridgepoint.position);
				if (d < best)
				{
					best = d;
					outBridge = c;
				}
			}
		}
		return best;
	}

	private void MakeWall(string name, GeneratedIsland island, Vector3 start, Vector3 end)
	{
		if (island != null)
		{
			MakeWallObject(island.gameObject, start, end);
		}
	}

	private Transform MakeWallObject(GameObject wallContainer, Vector3 start, Vector3 end)
	{
		if (borderPrefab == null || wallContainer == null)
		{
			return null;
		}
		BoxCollider col = UnityEngine.Object.Instantiate(borderPrefab, wallContainer.transform);
		Vector3 dir = end - start;
		col.transform.position = (start + end) * 0.5f;
		if (dir.sqrMagnitude > 0.001f)
		{
			col.transform.forward = dir.normalized;
		}
		col.transform.localScale = new Vector3(wallWidth, 3.5f, dir.magnitude);
		return col.transform;
	}

	public Vector3 GetCameraTarget(Vector3 pos)
	{
		if (cameraTarget != null)
		{
			return cameraTarget.position;
		}
		return transform.position;
	}

	public static Vector3 NearestPointOnLine(Vector3 a, Vector3 b, Vector3 point)
	{
		Vector3 ab = b - a;
		float sqrLen = ab.sqrMagnitude;
		if (sqrLen < 0.0001f)
		{
			return a;
		}
		float t = Mathf.Clamp01(Vector3.Dot(point - a, ab) / sqrLen);
		return a + ab * t;
	}
}
