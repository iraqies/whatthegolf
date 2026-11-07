using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009DB")]
public class OverworldArea : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20009DC")]
	public class BridgeConnection
	{
		[Token(Token = "0x4003628")]
		[FieldOffset(Offset = "0x10")]
		public OverworldBridgeIndicator bridge;

		[Token(Token = "0x4003629")]
		[FieldOffset(Offset = "0x18")]
		public bool hasButton;

		[Token(Token = "0x400362A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Transform bridgepoint;

		[Token(Token = "0x400362B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public OverworldIslandWall wall;

		[Token(Token = "0x400362C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public OverworldButton button;

		[Token(Token = "0x6002E6E")]
		[Address(RVA = "0x180C334", Offset = "0x180C334", VA = "0x180C334")]
		public BridgeConnection()
		{
		}
	}

	[Token(Token = "0x20009DD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42790", Offset = "0x42790")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x400362D")]
		[FieldOffset(Offset = "0x10")]
		public BridgeConnection b;

		[Token(Token = "0x400362E")]
		[FieldOffset(Offset = "0x18")]
		public OverworldArea _003C_003E4__this;

		[Token(Token = "0x6002E6F")]
		[Address(RVA = "0x180C2C0", Offset = "0x180C2C0", VA = "0x180C2C0")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6002E70")]
		[Address(RVA = "0x180C2C8", Offset = "0x180C2C8", VA = "0x180C2C8")]
		internal void _003CAwake_003Eb__0(OverworldBridgeIndicator brid)
		{
		}

		[Token(Token = "0x6002E71")]
		[Address(RVA = "0x180C2EC", Offset = "0x180C2EC", VA = "0x180C2EC")]
		internal void _003CAwake_003Eb__1(OverworldBridgeIndicator brid)
		{
		}

		[Token(Token = "0x6002E72")]
		[Address(RVA = "0x180C310", Offset = "0x180C310", VA = "0x180C310")]
		internal void _003CAwake_003Eb__2(OverworldButton btn)
		{
		}
	}

	[Token(Token = "0x400361F")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF8C", Offset = "0x4FF8C")]
	private Action<OverworldArea, OverworldButton> m_OnOpenBridge;

	[Token(Token = "0x4003620")]
	[FieldOffset(Offset = "0x20")]
	public string description;

	[Token(Token = "0x4003621")]
	[FieldOffset(Offset = "0x28")]
	public List<BridgeConnection> connectedBridges;

	[Token(Token = "0x4003622")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform cameraTarget;

	[Token(Token = "0x4003623")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private BoxCollider borderPrefab;

	[Token(Token = "0x4003624")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverworldButton buttonPrefab;

	[Token(Token = "0x4003625")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BoxCollider ground;

	[Token(Token = "0x4003626")]
	[FieldOffset(Offset = "0x50")]
	private float wallWidth;

	[Token(Token = "0x4003627")]
	[FieldOffset(Offset = "0x54")]
	private float bridgeWidth;

	[Token(Token = "0x14000050")]
	public event Action<OverworldArea, OverworldButton> OnOpenBridge
	{
		[Token(Token = "0x6002E5F")]
		[Address(RVA = "0x159F7FC", Offset = "0x159F7FC", VA = "0x159F7FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x689F8", Offset = "0x689F8")]
		add
		{
		}
		[Token(Token = "0x6002E60")]
		[Address(RVA = "0x159F8A0", Offset = "0x159F8A0", VA = "0x159F8A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68A08", Offset = "0x68A08")]
		remove
		{
		}
	}

	[Token(Token = "0x6002E61")]
	[Address(RVA = "0x159F944", Offset = "0x159F944", VA = "0x159F944")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002E62")]
	[Address(RVA = "0x159FD70", Offset = "0x159FD70", VA = "0x159FD70")]
	private void Bridge_OnChangeCount(BridgeConnection bridgeConnection)
	{
	}

	[Token(Token = "0x6002E63")]
	[Address(RVA = "0x15A0104", Offset = "0x15A0104", VA = "0x15A0104")]
	private void Button_OnPress(OverworldButton button, BridgeConnection bridgeConnection)
	{
	}

	[Token(Token = "0x6002E64")]
	[Address(RVA = "0x15A01F8", Offset = "0x15A01F8", VA = "0x15A01F8")]
	private void Bridge_OnOpen(BridgeConnection bridgeConnection)
	{
	}

	[Token(Token = "0x6002E65")]
	[Address(RVA = "0x15A029C", Offset = "0x15A029C", VA = "0x15A029C")]
	public void GenerateIsland()
	{
	}

	[Token(Token = "0x6002E66")]
	[Address(RVA = "0x15A04C4", Offset = "0x15A04C4", VA = "0x15A04C4")]
	private void MakeBridgeConnector(GeneratedIsland island)
	{
	}

	[Token(Token = "0x6002E67")]
	[Address(RVA = "0x15A0CC8", Offset = "0x15A0CC8", VA = "0x15A0CC8")]
	private void MakeWalls(GeneratedIsland island)
	{
	}

	[Token(Token = "0x6002E68")]
	[Address(RVA = "0x15A1400", Offset = "0x15A1400", VA = "0x15A1400")]
	private float distToClosestBridge(Vector3 start, Vector3 end, out BridgeConnection outBridge)
	{
		return default;
	}

	[Token(Token = "0x6002E69")]
	[Address(RVA = "0x15A101C", Offset = "0x15A101C", VA = "0x15A101C")]
	private void MakeWall(string name, GeneratedIsland island, Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x6002E6A")]
	[Address(RVA = "0x15A1740", Offset = "0x15A1740", VA = "0x15A1740")]
	private Transform MakeWallObject(GameObject wallContainer, Vector3 start, Vector3 end)
	{
		return null;
	}

	[Token(Token = "0x6002E6B")]
	[Address(RVA = "0x15A1974", Offset = "0x15A1974", VA = "0x15A1974")]
	public Vector3 GetCameraTarget(Vector3 pos)
	{
		return default;
	}

	[Token(Token = "0x6002E6C")]
	[Address(RVA = "0x15A1698", Offset = "0x15A1698", VA = "0x15A1698")]
	public static Vector3 NearestPointOnLine(Vector3 a, Vector3 b, Vector3 point)
	{
		return default;
	}

	[Token(Token = "0x6002E6D")]
	[Address(RVA = "0x15A1A18", Offset = "0x15A1A18", VA = "0x15A1A18")]
	public OverworldArea()
	{
	}
}
