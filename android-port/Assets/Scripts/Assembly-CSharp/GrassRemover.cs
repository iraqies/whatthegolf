using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000247")]
public class GrassRemover : MonoBehaviour
{
	[Token(Token = "0x2000248")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E6B4", Offset = "0x3E6B4")]
	private sealed class _003CStart_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000BB3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000BB4")]
		[FieldOffset(Offset = "0x20")]
		public GrassRemover _003C_003E4__this;

		[Token(Token = "0x17000143")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x17B9220", Offset = "0x17B9220", VA = "0x17B9220", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000144")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x17B9268", Offset = "0x17B9268", VA = "0x17B9268", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x17B90D0", Offset = "0x17B90D0", VA = "0x17B90D0")]
		[DebuggerHidden]
		public _003CStart_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x17B90FC", Offset = "0x17B90FC", VA = "0x17B90FC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x17B9100", Offset = "0x17B9100", VA = "0x17B9100", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x17B9220", Offset = "0x17B9220", VA = "0x17B9220", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x17B9228", Offset = "0x17B9228", VA = "0x17B9228", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x17B9268", Offset = "0x17B9268", VA = "0x17B9268", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000BA5")]
	[FieldOffset(Offset = "0x18")]
	public TerrainData GrassTerrain;

	[Token(Token = "0x4000BA6")]
	[FieldOffset(Offset = "0x20")]
	public int RemoveRadius;

	[Token(Token = "0x4000BA7")]
	[FieldOffset(Offset = "0x24")]
	public float DistanceThreshold;

	[Token(Token = "0x4000BA8")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem CutParticles;

	[Token(Token = "0x4000BA9")]
	[FieldOffset(Offset = "0x30")]
	public float EmitParticlesModifier;

	[Token(Token = "0x4000BAA")]
	[FieldOffset(Offset = "0x38")]
	public AudioSource cutAudioSource;

	[Token(Token = "0x4000BAB")]
	[FieldOffset(Offset = "0x40")]
	public float maxVolume;

	[Token(Token = "0x4000BAC")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 lastCut;

	[Token(Token = "0x4000BAD")]
	[FieldOffset(Offset = "0x50")]
	private float audioCutTimer;

	[Token(Token = "0x4000BAE")]
	[FieldOffset(Offset = "0x54")]
	private bool spawnParticles;

	[Token(Token = "0x4000BAF")]
	[FieldOffset(Offset = "0x58")]
	private float targetVolume;

	[Token(Token = "0x4000BB0")]
	[FieldOffset(Offset = "0x60")]
	private int[,] detailLayer;

	[Token(Token = "0x4000BB1")]
	[FieldOffset(Offset = "0x68")]
	private bool initialized;

	[Token(Token = "0x6000A39")]
	[Address(RVA = "0x14B8040", Offset = "0x14B8040", VA = "0x14B8040")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0x14B80C4", Offset = "0x14B80C4", VA = "0x14B80C4")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0x14B8138", Offset = "0x14B8138", VA = "0x14B8138")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x14B82E8", Offset = "0x14B82E8", VA = "0x14B82E8")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5FBA4", Offset = "0x5FBA4")]
	private void Cut()
	{
	}

	[Token(Token = "0x6000A3D")]
	[Address(RVA = "0x14B862C", Offset = "0x14B862C", VA = "0x14B862C", Slot = "4")]
	protected virtual bool CheckCoords(int[,] detailLayer, int x, int y, int fromX, int fromY)
	{
		return default;
	}

	[Token(Token = "0x6000A3E")]
	[Address(RVA = "0x14B8530", Offset = "0x14B8530", VA = "0x14B8530")]
	private Vector3 ConvertWorldCor2TerrCor(Vector3 worldCor)
	{
		return default;
	}

	[Token(Token = "0x6000A3F")]
	[Address(RVA = "0x14B86A4", Offset = "0x14B86A4", VA = "0x14B86A4")]
	public GrassRemover()
	{
	}
}
