using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x200015B")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200015C")]
		public class References
		{
			[Token(Token = "0x400084E")]
			[FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x400084F")]
			[FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000850")]
			[FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000851")]
			[FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x4000852")]
			[FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x4000853")]
			[FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000854")]
			[FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x4000855")]
			[FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000856")]
			[FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x4000857")]
			[FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x4000858")]
			[FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x4000859")]
			[FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x400085A")]
			[FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400085B")]
			[FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x400085C")]
			[FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x400085D")]
			[FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x400085E")]
			[FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x400085F")]
			[FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x4000860")]
			[FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x4000861")]
			[FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x4000862")]
			[FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x4000863")]
			[FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x1700013E")]
			public bool isFilled
			{
				[Token(Token = "0x60009B1")]
				[Address(RVA = "0x1358D9C", Offset = "0x1358D9C", VA = "0x1358D9C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700013F")]
			public bool isEmpty
			{
				[Token(Token = "0x60009B2")]
				[Address(RVA = "0x13592A8", Offset = "0x13592A8", VA = "0x13592A8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x1358958", Offset = "0x1358958", VA = "0x1358958")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x135978C", Offset = "0x135978C", VA = "0x135978C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default;
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x1359B1C", Offset = "0x1359B1C", VA = "0x1359B1C")]
			public References()
			{
			}
		}

		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0x38")]
		public References references;

		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverVR solver;

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x1327A54", Offset = "0x1327A54", VA = "0x1327A54", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x39EC4", Offset = "0x39EC4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x1327A9C", Offset = "0x1327A9C", VA = "0x1327A9C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x39EFC", Offset = "0x39EFC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x1327AE4", Offset = "0x1327AE4", VA = "0x1327AE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x39F34", Offset = "0x39F34")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x1327B2C", Offset = "0x1327B2C", VA = "0x1327B2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x39F6C", Offset = "0x39F6C")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x1327B58", Offset = "0x1327B58", VA = "0x1327B58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x39FA4", Offset = "0x39FA4")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x1327B80", Offset = "0x1327B80", VA = "0x1327B80", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x1327B88", Offset = "0x1327B88", VA = "0x1327B88", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x1327C08", Offset = "0x1327C08", VA = "0x1327C08", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x1327D78", Offset = "0x1327D78", VA = "0x1327D78")]
		public VRIK()
		{
		}
	}
}
