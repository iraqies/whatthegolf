using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001AE")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20001AF")]
		public class ReachCone
		{
			[Token(Token = "0x4000B8E")]
			[FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000B8F")]
			[FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000B90")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000B91")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x1700019B")]
			public Vector3 a
			{
				[Token(Token = "0x6000CC4")]
				[Address(RVA = "0x1355D14", Offset = "0x1355D14", VA = "0x1355D14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700019C")]
			public Vector3 b
			{
				[Token(Token = "0x6000CC5")]
				[Address(RVA = "0x1355D50", Offset = "0x1355D50", VA = "0x1355D50")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700019D")]
			public Vector3 c
			{
				[Token(Token = "0x6000CC6")]
				[Address(RVA = "0x1355D8C", Offset = "0x1355D8C", VA = "0x1355D8C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700019E")]
			public bool isValid
			{
				[Token(Token = "0x6000CC8")]
				[Address(RVA = "0x1355EE8", Offset = "0x1355EE8", VA = "0x1355EE8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x1355DC8", Offset = "0x1355DC8", VA = "0x1355DC8")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x1355EF8", Offset = "0x1355EF8", VA = "0x1355EF8")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B0")]
		public class LimitPoint
		{
			[Token(Token = "0x4000B92")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000B93")]
			[FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0x1355CD8", Offset = "0x1355CD8", VA = "0x1355CD8")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000B89")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x368DC", Offset = "0x368DC")]
		public float twistLimit;

		[Token(Token = "0x4000B8A")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x368F8", Offset = "0x368F8")]
		public int smoothIterations;

		[Token(Token = "0x4000B8B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public LimitPoint[] points;

		[Token(Token = "0x4000B8C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public Vector3[] P;

		[Token(Token = "0x4000B8D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x13F4348", Offset = "0x13F4348", VA = "0x13F4348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3ABAC", Offset = "0x3ABAC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x13F4390", Offset = "0x13F4390", VA = "0x13F4390")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3ABE4", Offset = "0x3ABE4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x13F43D8", Offset = "0x13F43D8", VA = "0x13F43D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AC1C", Offset = "0x3AC1C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x13F4420", Offset = "0x13F4420", VA = "0x13F4420")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3AC54", Offset = "0x3AC54")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x13F4468", Offset = "0x13F4468", VA = "0x13F4468")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x13F48C8", Offset = "0x13F48C8", VA = "0x13F48C8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default;
		}

		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x13F4958", Offset = "0x13F4958", VA = "0x13F4958")]
		private void Start()
		{
		}

		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x13F4E88", Offset = "0x13F4E88", VA = "0x13F4E88")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x13F4504", Offset = "0x13F4504", VA = "0x13F4504")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x13F5208", Offset = "0x13F5208", VA = "0x13F5208")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x13F5638", Offset = "0x13F5638", VA = "0x13F5638")]
		private float GetScalar(int k)
		{
			return default;
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x13F5674", Offset = "0x13F5674", VA = "0x13F5674")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default;
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x13F56D4", Offset = "0x13F56D4", VA = "0x13F56D4")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default;
		}

		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x13F4C18", Offset = "0x13F4C18", VA = "0x13F4C18")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default;
		}

		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x13F5740", Offset = "0x13F5740", VA = "0x13F5740")]
		private int GetReachCone(Vector3 L)
		{
			return default;
		}

		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x13F5830", Offset = "0x13F5830", VA = "0x13F5830")]
		public RotationLimitPolygonal()
		{
		}
	}
}
