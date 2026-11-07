using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BeatFighter
{
	[Token(Token = "0x20010E6")]
	public class AttackObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20010E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47BC4", Offset = "0x47BC4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005910")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005911")]
			[FieldOffset(Offset = "0x8")]
			public static Func<float, float> _003C_003E9__6_0;

			[Token(Token = "0x6004BB1")]
			[Address(RVA = "0x176F870", Offset = "0x176F870", VA = "0x176F870")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004BB2")]
			[Address(RVA = "0x176F878", Offset = "0x176F878", VA = "0x176F878")]
			internal float _003CInitialize_003Eb__6_0(float x)
			{
				return default;
			}
		}

		[Token(Token = "0x400590A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform attackObject;

		[Token(Token = "0x400590B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float speed;

		[Token(Token = "0x400590C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool bounce;

		[Token(Token = "0x400590D")]
		[FieldOffset(Offset = "0x28")]
		public float attackTime;

		[Token(Token = "0x400590E")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 offset;

		[Token(Token = "0x400590F")]
		[FieldOffset(Offset = "0x38")]
		private Func<float, float> timeFunc;

		[Token(Token = "0x6004BAD")]
		[Address(RVA = "0x142BF88", Offset = "0x142BF88", VA = "0x142BF88")]
		public void Initialize(float attackTime)
		{
		}

		[Token(Token = "0x6004BAE")]
		[Address(RVA = "0x142C114", Offset = "0x142C114", VA = "0x142C114")]
		public void Move(float t)
		{
		}

		[Token(Token = "0x6004BAF")]
		[Address(RVA = "0x142C1BC", Offset = "0x142C1BC", VA = "0x142C1BC")]
		public AttackObject()
		{
		}
	}
}
