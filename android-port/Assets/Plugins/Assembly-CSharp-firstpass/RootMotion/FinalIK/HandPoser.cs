using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001A5")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000B50")]
		[FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000B51")]
		[FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000B53")]
		[FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x13818BC", Offset = "0x13818BC", VA = "0x13818BC", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x1381994", Offset = "0x1381994", VA = "0x1381994", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x1381B50", Offset = "0x1381B50", VA = "0x1381B50", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x1381C44", Offset = "0x1381C44", VA = "0x1381C44", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x13819F4", Offset = "0x13819F4", VA = "0x13819F4")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x1381FAC", Offset = "0x1381FAC", VA = "0x1381FAC")]
		public HandPoser()
		{
		}
	}
}
