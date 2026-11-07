using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Serializable]
	[Token(Token = "0x2000133")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x400076B")]
		[FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Token(Token = "0x400076E")]
		[FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Token(Token = "0x400076F")]
		[FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x1306078", Offset = "0x1306078", VA = "0x1306078")]
		public bool IsValid(ref string msg)
		{
			return default;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x1309250", Offset = "0x1309250", VA = "0x1309250")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default;
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x1308DB8", Offset = "0x1308DB8", VA = "0x1308DB8")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x130934C", Offset = "0x130934C", VA = "0x130934C")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default;
		}
	}
}
