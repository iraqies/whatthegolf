using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B41")]
public class RollingClouds : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000B42")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43750", Offset = "0x43750")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003EB5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003EB6")]
		[FieldOffset(Offset = "0x8")]
		public static Func<SpriteRenderer, Transform> _003C_003E9__4_0;

		[Token(Token = "0x600358E")]
		[Address(RVA = "0x18362AC", Offset = "0x18362AC", VA = "0x18362AC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600358F")]
		[Address(RVA = "0x18362B4", Offset = "0x18362B4", VA = "0x18362B4")]
		internal Transform _003CStart_003Eb__4_0(SpriteRenderer s)
		{
			return null;
		}
	}

	[Token(Token = "0x4003EB1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _speed;

	[Token(Token = "0x4003EB2")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _width;

	[Token(Token = "0x4003EB3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform _container;

	[Token(Token = "0x4003EB4")]
	[FieldOffset(Offset = "0x28")]
	private List<Transform> _clouds;

	[Token(Token = "0x1700057A")]
	private Vector3 _start
	{
		[Token(Token = "0x6003588")]
		[Address(RVA = "0x165CA80", Offset = "0x165CA80", VA = "0x165CA80")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700057B")]
	private Vector3 _end
	{
		[Token(Token = "0x6003589")]
		[Address(RVA = "0x165CB08", Offset = "0x165CB08", VA = "0x165CB08")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6003587")]
	[Address(RVA = "0x165C8E0", Offset = "0x165C8E0", VA = "0x165C8E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600358A")]
	[Address(RVA = "0x165CB90", Offset = "0x165CB90", VA = "0x165CB90")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600358B")]
	[Address(RVA = "0x165CE4C", Offset = "0x165CE4C", VA = "0x165CE4C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600358C")]
	[Address(RVA = "0x165CF70", Offset = "0x165CF70", VA = "0x165CF70")]
	public RollingClouds()
	{
	}
}
