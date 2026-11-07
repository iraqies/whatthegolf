using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000883")]
public class Recorder : MonoBehaviour
{
	[Token(Token = "0x2000884")]
	public struct Snapshot
	{
		[Token(Token = "0x4002EAD")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 Position;

		[Token(Token = "0x4002EAE")]
		[FieldOffset(Offset = "0xC")]
		public Quaternion Rotation;

		[Token(Token = "0x6002751")]
		[Address(RVA = "0x18318EC", Offset = "0x18318EC", VA = "0x18318EC")]
		public static Snapshot LerpSnapshots(Snapshot from, Snapshot to, float t)
		{
			return default;
		}

		[Token(Token = "0x6002752")]
		[Address(RVA = "0x18319AC", Offset = "0x18319AC", VA = "0x18319AC")]
		public static bool TryGetSnapshotAt(List<Snapshot> snapshots, float t, out Snapshot snapshot)
		{
			return default;
		}

		[Token(Token = "0x6002753")]
		[Address(RVA = "0x1831AEC", Offset = "0x1831AEC", VA = "0x1831AEC")]
		public static bool TryGetInterpolatedSnapshot(List<Snapshot> snapshots, out Snapshot interpolatedSnapshot, float time)
		{
			return default;
		}
	}

	[Token(Token = "0x4002EAB")]
	[FieldOffset(Offset = "0x18")]
	public List<Snapshot> Snapshots;

	[Token(Token = "0x4002EAC")]
	[FieldOffset(Offset = "0x20")]
	private TimeTravelController timeController;

	[Token(Token = "0x600274D")]
	[Address(RVA = "0x1646520", Offset = "0x1646520", VA = "0x1646520")]
	private void Start()
	{
	}

	[Token(Token = "0x600274E")]
	[Address(RVA = "0x16466E4", Offset = "0x16466E4", VA = "0x16466E4")]
	private void RecordSnapshot()
	{
	}

	[Token(Token = "0x600274F")]
	[Address(RVA = "0x16467B8", Offset = "0x16467B8", VA = "0x16467B8")]
	public void Reset()
	{
	}

	[Token(Token = "0x6002750")]
	[Address(RVA = "0x164689C", Offset = "0x164689C", VA = "0x164689C")]
	public Recorder()
	{
	}
}
