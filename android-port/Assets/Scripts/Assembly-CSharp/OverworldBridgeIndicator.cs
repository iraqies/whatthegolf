using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009E4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x427A0", Offset = "0x427A0")]
public class OverworldBridgeIndicator : MonoBehaviour
{
	[Token(Token = "0x20009E5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42808", Offset = "0x42808")]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x4003666")]
		[FieldOffset(Offset = "0x10")]
		public OverworldBridgeIndicator _003C_003E4__this;

		[Token(Token = "0x4003667")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 end;

		[Token(Token = "0x4003668")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 start;

		[Token(Token = "0x6002EBE")]
		[Address(RVA = "0x180CDCC", Offset = "0x180CDCC", VA = "0x180CDCC")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6002EBF")]
		[Address(RVA = "0x180CDD4", Offset = "0x180CDD4", VA = "0x180CDD4")]
		internal void _003COpen_003Eb__0(float t)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20009E6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42818", Offset = "0x42818")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003669")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400366A")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__24_1;

		[Token(Token = "0x6002EC1")]
		[Address(RVA = "0x180CDC0", Offset = "0x180CDC0", VA = "0x180CDC0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002EC2")]
		[Address(RVA = "0x180CDC8", Offset = "0x180CDC8", VA = "0x180CDC8")]
		internal void _003COpen_003Eb__24_1()
		{
		}
	}

	[Token(Token = "0x4003659")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5004C", Offset = "0x5004C")]
	private Action<OverworldBridgeIndicator> m_OnOpen;

	[Token(Token = "0x400365A")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5005C", Offset = "0x5005C")]
	private Action<OverworldBridgeIndicator> m_OnChangeCount;

	[Token(Token = "0x400365B")]
	[FieldOffset(Offset = "0x28")]
	public bool isOpen;

	[Token(Token = "0x400365C")]
	[FieldOffset(Offset = "0x30")]
	public List<OverworldGoal> requireGoals;

	[Token(Token = "0x400365D")]
	[FieldOffset(Offset = "0x38")]
	public int requireCountMinus;

	[Token(Token = "0x400365E")]
	[FieldOffset(Offset = "0x40")]
	public Transform startPoint;

	[Token(Token = "0x400365F")]
	[FieldOffset(Offset = "0x48")]
	public Transform endPoint;

	[Token(Token = "0x4003660")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem openParticles;

	[Token(Token = "0x4003661")]
	[FieldOffset(Offset = "0x58")]
	public GeneratedIsland visualBridge;

	[Token(Token = "0x4003662")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private BoxCollider borderPrefab;

	[Token(Token = "0x4003663")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private BoxCollider groundPrefab;

	[Token(Token = "0x4003664")]
	[FieldOffset(Offset = "0x70")]
	public ParticleSystem openParticlesPrefab;

	[Token(Token = "0x4003665")]
	[FieldOffset(Offset = "0x78")]
	private float bridgeWidth;

	[Token(Token = "0x14000055")]
	public event Action<OverworldBridgeIndicator> OnOpen
	{
		[Token(Token = "0x6002EAC")]
		[Address(RVA = "0x159FE38", Offset = "0x159FE38", VA = "0x159FE38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68A98", Offset = "0x68A98")]
		add
		{
		}
		[Token(Token = "0x6002EAD")]
		[Address(RVA = "0x15A60E8", Offset = "0x15A60E8", VA = "0x15A60E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68AA8", Offset = "0x68AA8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000056")]
	public event Action<OverworldBridgeIndicator> OnChangeCount
	{
		[Token(Token = "0x6002EAE")]
		[Address(RVA = "0x159FEDC", Offset = "0x159FEDC", VA = "0x159FEDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68AB8", Offset = "0x68AB8")]
		add
		{
		}
		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0x15A618C", Offset = "0x15A618C", VA = "0x15A618C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68AC8", Offset = "0x68AC8")]
		remove
		{
		}
	}

	[Token(Token = "0x6002EB0")]
	[Address(RVA = "0x15A6230", Offset = "0x15A6230", VA = "0x15A6230")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002EB1")]
	[Address(RVA = "0x15A6410", Offset = "0x15A6410", VA = "0x15A6410")]
	private void Goal_OnUpdateData(OverworldGoal obj)
	{
	}

	[Token(Token = "0x6002EB2")]
	[Address(RVA = "0x159FF80", Offset = "0x159FF80", VA = "0x159FF80")]
	public int GetFlagsMissingCount()
	{
		return default;
	}

	[Token(Token = "0x6002EB3")]
	[Address(RVA = "0x15A6470", Offset = "0x15A6470", VA = "0x15A6470")]
	private void UpdateLockStatus(bool instant)
	{
	}

	[Token(Token = "0x6002EB4")]
	[Address(RVA = "0x15A017C", Offset = "0x15A017C", VA = "0x15A017C")]
	public void TryOpen(bool instant = false)
	{
	}

	[Token(Token = "0x6002EB5")]
	[Address(RVA = "0x15A00E8", Offset = "0x15A00E8", VA = "0x15A00E8")]
	public bool CanBeOpened()
	{
		return default;
	}

	[Token(Token = "0x6002EB6")]
	[Address(RVA = "0x15A6604", Offset = "0x15A6604", VA = "0x15A6604")]
	private void Unlock(bool instant)
	{
	}

	[Token(Token = "0x6002EB7")]
	[Address(RVA = "0x15A661C", Offset = "0x15A661C", VA = "0x15A661C")]
	public void Open(bool instant)
	{
	}

	[Token(Token = "0x6002EB8")]
	[Address(RVA = "0x15A6964", Offset = "0x15A6964", VA = "0x15A6964")]
	public void Make()
	{
	}

	[Token(Token = "0x6002EB9")]
	[Address(RVA = "0x15A7330", Offset = "0x15A7330", VA = "0x15A7330")]
	private void MakeParticles(GeneratedIsland island, Vector3 dir)
	{
	}

	[Token(Token = "0x6002EBA")]
	[Address(RVA = "0x15A6DFC", Offset = "0x15A6DFC", VA = "0x15A6DFC")]
	private void MakeGround(GeneratedIsland island, Vector3 dir)
	{
	}

	[Token(Token = "0x6002EBB")]
	[Address(RVA = "0x15A6F60", Offset = "0x15A6F60", VA = "0x15A6F60")]
	private void MakeWalls(GeneratedIsland island, Vector3 dir)
	{
	}

	[Token(Token = "0x6002EBC")]
	[Address(RVA = "0x15A74A4", Offset = "0x15A74A4", VA = "0x15A74A4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002EBD")]
	[Address(RVA = "0x15A76A8", Offset = "0x15A76A8", VA = "0x15A76A8")]
	public OverworldBridgeIndicator()
	{
	}
}
