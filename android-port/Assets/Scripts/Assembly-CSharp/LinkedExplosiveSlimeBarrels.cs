using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D9A")]
public class LinkedExplosiveSlimeBarrels : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000D9B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44BA0", Offset = "0x44BA0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004A15")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004A16")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ExplosionBarrel2D, GameObject> _003C_003E9__6_0;

		[Token(Token = "0x6003FF6")]
		[Address(RVA = "0x17E9CB8", Offset = "0x17E9CB8", VA = "0x17E9CB8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003FF7")]
		[Address(RVA = "0x17E9CC0", Offset = "0x17E9CC0", VA = "0x17E9CC0")]
		internal GameObject _003CStart_003Eb__6_0(ExplosionBarrel2D b)
		{
			return null;
		}
	}

	[Token(Token = "0x4004A0F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<ExplosionBarrel2D> _barrel;

	[Token(Token = "0x4004A10")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private OpenBarricade _barricade;

	[Token(Token = "0x4004A11")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<GameObject> _decals;

	[Token(Token = "0x4004A12")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<GameObject> _deactivateObjectsOnExplode;

	[Token(Token = "0x4004A13")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private OverworldMainDoorRobot _robot;

	[Token(Token = "0x4004A14")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UnityEvent _onExplode;

	[Token(Token = "0x6003FF2")]
	[Address(RVA = "0x1534860", Offset = "0x1534860", VA = "0x1534860")]
	private void Start()
	{
	}

	[Token(Token = "0x6003FF3")]
	[Address(RVA = "0x1534B88", Offset = "0x1534B88", VA = "0x1534B88")]
	public void ExplodeAll(Collider2D col)
	{
	}

	[Token(Token = "0x6003FF4")]
	[Address(RVA = "0x1534EB4", Offset = "0x1534EB4", VA = "0x1534EB4")]
	public LinkedExplosiveSlimeBarrels()
	{
	}
}
