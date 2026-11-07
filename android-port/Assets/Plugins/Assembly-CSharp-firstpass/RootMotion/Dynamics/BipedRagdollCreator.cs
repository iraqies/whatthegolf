using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000131")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x2000132")]
		public struct Options
		{
			[Token(Token = "0x4000758")]
			[FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x4000759")]
			[FieldOffset(Offset = "0x4")]
			public bool spine;

			[Token(Token = "0x400075A")]
			[FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x400075B")]
			[FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x400075C")]
			[FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x400075D")]
			[FieldOffset(Offset = "0x8")]
			public JointType joints;

			[Token(Token = "0x400075E")]
			[FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x400075F")]
			[FieldOffset(Offset = "0x10")]
			public float colliderLengthOverlap;

			[Token(Token = "0x4000760")]
			[FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x4000761")]
			[FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x4000762")]
			[FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x4000763")]
			[FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x4000764")]
			[FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x4000765")]
			[FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x17000121")]
			public static Options Default
			{
				[Token(Token = "0x600086B")]
				[Address(RVA = "0x1338B18", Offset = "0x1338B18", VA = "0x1338B18")]
				get
				{
					return default;
				}
			}
		}

		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0xA8")]
		public Options options;

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x1305AC8", Offset = "0x1305AC8", VA = "0x1305AC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38D84", Offset = "0x38D84")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1305B10", Offset = "0x1305B10", VA = "0x1305B10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38DBC", Offset = "0x38DBC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x1305B58", Offset = "0x1305B58", VA = "0x1305B58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38DF4", Offset = "0x38DF4")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x1305BA0", Offset = "0x1305BA0", VA = "0x1305BA0")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x1305ED4", Offset = "0x1305ED4", VA = "0x1305ED4")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x13067CC", Offset = "0x13067CC", VA = "0x13067CC")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x1308070", Offset = "0x1308070", VA = "0x1308070")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x13082A0", Offset = "0x13082A0", VA = "0x13082A0")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x13086B0", Offset = "0x13086B0", VA = "0x13086B0")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x1307320", Offset = "0x1307320", VA = "0x1307320")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x1307798", Offset = "0x1307798", VA = "0x1307798")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x1308794", Offset = "0x1308794", VA = "0x1308794")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x1308D40", Offset = "0x1308D40", VA = "0x1308D40")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x13090F4", Offset = "0x13090F4", VA = "0x13090F4")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default;
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x1307F7C", Offset = "0x1307F7C", VA = "0x1307F7C")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default;
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x1305E30", Offset = "0x1305E30", VA = "0x1305E30")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default;
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x13091FC", Offset = "0x13091FC", VA = "0x13091FC")]
		public BipedRagdollCreator()
		{
		}
	}
}
