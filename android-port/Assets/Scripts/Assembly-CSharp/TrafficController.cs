using System;
using System.Collections.Generic;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B90")]
public class TrafficController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000B91")]
	public class TrafficPoint
	{
		[Token(Token = "0x4004075")]
		[FieldOffset(Offset = "0x10")]
		public List<Transform> PathPoints;

		[Token(Token = "0x4004076")]
		[FieldOffset(Offset = "0x18")]
		public List<GameObject> CurrentCars;

		[Token(Token = "0x4004077")]
		[FieldOffset(Offset = "0x20")]
		public float Delay;

		[Token(Token = "0x60037D5")]
		[Address(RVA = "0x1869BCC", Offset = "0x1869BCC", VA = "0x1869BCC")]
		public TrafficPoint()
		{
		}
	}

	[Token(Token = "0x4004068")]
	[FieldOffset(Offset = "0x18")]
	public List<TrafficPoint> TrafficPoints;

	[Token(Token = "0x4004069")]
	[FieldOffset(Offset = "0x20")]
	private int trafficPointsSum;

	[Token(Token = "0x400406A")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> CarPrefabs;

	[Token(Token = "0x400406B")]
	[FieldOffset(Offset = "0x30")]
	public bool PrePopulate;

	[Token(Token = "0x400406C")]
	[FieldOffset(Offset = "0x34")]
	public int NumberOfCars;

	[Token(Token = "0x400406D")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 DelayRange;

	[Token(Token = "0x400406E")]
	[FieldOffset(Offset = "0x40")]
	public float CheckRadius;

	[Token(Token = "0x400406F")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 ScaleMod;

	[Token(Token = "0x4004070")]
	[FieldOffset(Offset = "0x50")]
	public List<AudioClip> engineLoopSequence;

	[Token(Token = "0x4004071")]
	[FieldOffset(Offset = "0x58")]
	private List<CarAgent> _cars;

	[Token(Token = "0x4004072")]
	[FieldOffset(Offset = "0x60")]
	private int engineLoopIndex;

	[Token(Token = "0x4004073")]
	[FieldOffset(Offset = "0x68")]
	private Timeline timeline;

	[Token(Token = "0x4004074")]
	[FieldOffset(Offset = "0x70")]
	private List<int> interestingPoints;

	[Token(Token = "0x60037CC")]
	[Address(RVA = "0x172159C", Offset = "0x172159C", VA = "0x172159C")]
	public void ChangeTimelineClock(string newClockName)
	{
	}

	[Token(Token = "0x60037CD")]
	[Address(RVA = "0x1721784", Offset = "0x1721784", VA = "0x1721784")]
	private void Start()
	{
	}

	[Token(Token = "0x60037CE")]
	[Address(RVA = "0x17222AC", Offset = "0x17222AC", VA = "0x17222AC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60037CF")]
	[Address(RVA = "0x172256C", Offset = "0x172256C", VA = "0x172256C")]
	private void Update()
	{
	}

	[Token(Token = "0x60037D0")]
	[Address(RVA = "0x17213A4", Offset = "0x17213A4", VA = "0x17213A4")]
	public AudioClip GetNextEngineClip()
	{
		return null;
	}

	[Token(Token = "0x60037D1")]
	[Address(RVA = "0x1721BAC", Offset = "0x1721BAC", VA = "0x1721BAC")]
	private void TrySpawnCars(bool prePopulate = false)
	{
	}

	[Token(Token = "0x60037D2")]
	[Address(RVA = "0x172280C", Offset = "0x172280C", VA = "0x172280C")]
	public void RemoveAndDeactivateCar(TrafficPoint point, CarAgent car)
	{
	}

	[Token(Token = "0x60037D3")]
	[Address(RVA = "0x17228A4", Offset = "0x17228A4", VA = "0x17228A4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60037D4")]
	[Address(RVA = "0x1722C3C", Offset = "0x1722C3C", VA = "0x1722C3C")]
	public TrafficController()
	{
	}
}
