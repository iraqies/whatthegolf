using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200023D")]
public class GrasRemoverCollection : MonoBehaviour
{
	[Token(Token = "0x200023E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E654", Offset = "0x3E654")]
	private sealed class _003CStart_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B78")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000B79")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000B7A")]
		[FieldOffset(Offset = "0x20")]
		public GrasRemoverCollection _003C_003E4__this;

		[Token(Token = "0x1700013B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x17B8610", Offset = "0x17B8610", VA = "0x17B8610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700013C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x17B8658", Offset = "0x17B8658", VA = "0x17B8658", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x17B8530", Offset = "0x17B8530", VA = "0x17B8530")]
		[DebuggerHidden]
		public _003CStart_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x17B855C", Offset = "0x17B855C", VA = "0x17B855C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x17B8560", Offset = "0x17B8560", VA = "0x17B8560", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x17B8610", Offset = "0x17B8610", VA = "0x17B8610", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x17B8618", Offset = "0x17B8618", VA = "0x17B8618", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x17B8658", Offset = "0x17B8658", VA = "0x17B8658", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000B6E")]
	[FieldOffset(Offset = "0x18")]
	public TerrainData GrassTerrain;

	[Token(Token = "0x4000B6F")]
	[FieldOffset(Offset = "0x20")]
	public int RemoveRadius;

	[Token(Token = "0x4000B70")]
	[FieldOffset(Offset = "0x24")]
	public float DistanceThreshold;

	[Token(Token = "0x4000B71")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem CutParticles;

	[Token(Token = "0x4000B72")]
	[FieldOffset(Offset = "0x30")]
	public float EmitParticlesModifier;

	[Token(Token = "0x4000B73")]
	[FieldOffset(Offset = "0x38")]
	public List<Transform> GrassCutters;

	[Token(Token = "0x4000B74")]
	[FieldOffset(Offset = "0x40")]
	public Dictionary<Transform, Vector3> lastCuts;

	[Token(Token = "0x4000B75")]
	[FieldOffset(Offset = "0x48")]
	private bool spawnParticles;

	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x50")]
	private int[,] detailLayer;

	[Token(Token = "0x4000B77")]
	[FieldOffset(Offset = "0x58")]
	private bool initialized;

	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0x14B66D4", Offset = "0x14B66D4", VA = "0x14B66D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x14B68E4", Offset = "0x14B68E4", VA = "0x14B68E4")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x14B6958", Offset = "0x14B6958", VA = "0x14B6958")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x14B6C30", Offset = "0x14B6C30", VA = "0x14B6C30")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5FA2C", Offset = "0x5FA2C")]
	private void Cut(Transform cutter)
	{
	}

	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x14B6FB0", Offset = "0x14B6FB0", VA = "0x14B6FB0", Slot = "4")]
	protected virtual bool CheckCoords(int[,] detailLayer, int x, int y, int fromX, int fromY)
	{
		return default;
	}

	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x14B6EB4", Offset = "0x14B6EB4", VA = "0x14B6EB4")]
	private Vector3 ConvertWorldCor2TerrCor(Vector3 worldCor)
	{
		return default;
	}

	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x14B7028", Offset = "0x14B7028", VA = "0x14B7028")]
	public GrasRemoverCollection()
	{
	}
}
