using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000134")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000135")]
		public enum ColliderType
		{
			[Token(Token = "0x4000778")]
			Box = 0,
			[Token(Token = "0x4000779")]
			Capsule = 1
		}

		[Serializable]
		[Token(Token = "0x2000136")]
		public enum JointType
		{
			[Token(Token = "0x400077B")]
			Configurable = 0,
			[Token(Token = "0x400077C")]
			Character = 1
		}

		[Serializable]
		[Token(Token = "0x2000137")]
		public enum Direction
		{
			[Token(Token = "0x400077E")]
			X = 0,
			[Token(Token = "0x400077F")]
			Y = 1,
			[Token(Token = "0x4000780")]
			Z = 2
		}

		[Token(Token = "0x2000138")]
		public struct CreateJointParams
		{
			[Token(Token = "0x2000139")]
			public struct Limits
			{
				[Token(Token = "0x4000787")]
				[FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x4000788")]
				[FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x4000789")]
				[FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x400078A")]
				[FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x6000880")]
				[Address(RVA = "0x135AED0", Offset = "0x135AED0", VA = "0x135AED0")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x4000781")]
			[FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x4000782")]
			[FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Token(Token = "0x4000783")]
			[FieldOffset(Offset = "0x10")]
			public Transform child;

			[Token(Token = "0x4000784")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x4000785")]
			[FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Token(Token = "0x4000786")]
			[FieldOffset(Offset = "0x34")]
			public JointType type;

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x1353EF0", Offset = "0x1353EF0", VA = "0x1353EF0")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x13D63B8", Offset = "0x13D63B8", VA = "0x13D63B8")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x13D65C4", Offset = "0x13D65C4", VA = "0x13D65C4")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x13D6818", Offset = "0x13D6818", VA = "0x13D6818")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x13D6C70", Offset = "0x13D6C70", VA = "0x13D6C70")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x13D6B8C", Offset = "0x13D6B8C", VA = "0x13D6B8C")]
		protected static float GetScaleF(Transform t)
		{
			return default;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x13D6FD0", Offset = "0x13D6FD0", VA = "0x13D6FD0")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x13D6FE0", Offset = "0x13D6FE0", VA = "0x13D6FE0")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x13D7000", Offset = "0x13D7000", VA = "0x13D7000")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x13D7024", Offset = "0x13D7024", VA = "0x13D7024")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x13D6BBC", Offset = "0x13D6BBC", VA = "0x13D6BBC")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x13D7048", Offset = "0x13D7048", VA = "0x13D7048")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x13D71D0", Offset = "0x13D71D0", VA = "0x13D71D0")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x13D739C", Offset = "0x13D739C", VA = "0x13D739C")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x13D794C", Offset = "0x13D794C", VA = "0x13D794C")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default;
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x13D7980", Offset = "0x13D7980", VA = "0x13D7980")]
		protected RagdollCreator()
		{
		}
	}
}
