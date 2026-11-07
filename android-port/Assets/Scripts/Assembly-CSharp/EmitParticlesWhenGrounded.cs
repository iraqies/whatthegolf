using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BE1")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43DF0", Offset = "0x43DF0")]
public class EmitParticlesWhenGrounded : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000BE2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43E58", Offset = "0x43E58")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40041E1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40041E2")]
		[FieldOffset(Offset = "0x8")]
		public static Func<RealCar, int> _003C_003E9__7_0;

		[Token(Token = "0x60038FD")]
		[Address(RVA = "0x179ED58", Offset = "0x179ED58", VA = "0x179ED58")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60038FE")]
		[Address(RVA = "0x179ED60", Offset = "0x179ED60", VA = "0x179ED60")]
		internal int _003CAwake_003Eb__7_0(RealCar c)
		{
			return default;
		}
	}

	[Token(Token = "0x40041DA")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Offset;

	[Token(Token = "0x40041DB")]
	[FieldOffset(Offset = "0x24")]
	public float Distance;

	[Token(Token = "0x40041DC")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask GroundLayers;

	[Token(Token = "0x40041DD")]
	[FieldOffset(Offset = "0x2C")]
	public float ParticlesToEmitPerUnit;

	[Token(Token = "0x40041DE")]
	[FieldOffset(Offset = "0x30")]
	private RealCar[] cars;

	[Token(Token = "0x40041DF")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystem particles;

	[Token(Token = "0x40041E0")]
	[FieldOffset(Offset = "0x40")]
	private Vector3[] lastPositions;

	[Token(Token = "0x60038F8")]
	[Address(RVA = "0x1441E9C", Offset = "0x1441E9C", VA = "0x1441E9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60038F9")]
	[Address(RVA = "0x1442324", Offset = "0x1442324", VA = "0x1442324")]
	private void Update()
	{
	}

	[Token(Token = "0x60038FA")]
	[Address(RVA = "0x1442568", Offset = "0x1442568", VA = "0x1442568")]
	private void EmitForWheel(Transform wheel, int i)
	{
	}

	[Token(Token = "0x60038FB")]
	[Address(RVA = "0x14427C8", Offset = "0x14427C8", VA = "0x14427C8")]
	public EmitParticlesWhenGrounded()
	{
	}
}
