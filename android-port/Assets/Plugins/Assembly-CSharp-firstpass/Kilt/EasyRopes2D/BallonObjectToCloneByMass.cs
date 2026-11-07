using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Serializable]
	[Token(Token = "0x2000098")]
	public class BallonObjectToCloneByMass
	{
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject m_objectContainer;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_massToAcceptClone;

		[Token(Token = "0x17000061")]
		public GameObject ObjectContainer
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x12F87F8", Offset = "0x12F87F8", VA = "0x12F87F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public float MassToAcceptClone
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x12F8800", Offset = "0x12F8800", VA = "0x12F8800")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x12F8808", Offset = "0x12F8808", VA = "0x12F8808")]
		public BallonObjectToCloneByMass()
		{
		}
	}
}
