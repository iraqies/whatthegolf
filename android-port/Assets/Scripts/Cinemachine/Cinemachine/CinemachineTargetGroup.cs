using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000033")]
	[ExecuteAlways]
	public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup
	{
		[Serializable]
		[Token(Token = "0x2000034")]
		public struct Target
		{
			[Token(Token = "0x400010E")]
			[FieldOffset(Offset = "0x0")]
			public Transform target;

			[Token(Token = "0x400010F")]
			[FieldOffset(Offset = "0x8")]
			public float weight;

			[Token(Token = "0x4000110")]
			[FieldOffset(Offset = "0xC")]
			public float radius;
		}

		[Token(Token = "0x2000035")]
		public enum PositionMode
		{
			[Token(Token = "0x4000112")]
			GroupCenter = 0,
			[Token(Token = "0x4000113")]
			GroupAverage = 1
		}

		[Token(Token = "0x2000036")]
		public enum RotationMode
		{
			[Token(Token = "0x4000115")]
			Manual = 0,
			[Token(Token = "0x4000116")]
			GroupAverage = 1
		}

		[Token(Token = "0x2000037")]
		public enum UpdateMethod
		{
			[Token(Token = "0x4000118")]
			Update = 0,
			[Token(Token = "0x4000119")]
			FixedUpdate = 1,
			[Token(Token = "0x400011A")]
			LateUpdate = 2
		}

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x18")]
		public PositionMode m_PositionMode;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x1C")]
		public RotationMode m_RotationMode;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x20")]
		public UpdateMethod m_UpdateMethod;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x28")]
		public Target[] m_Targets;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78710", Offset = "0x78710")]
		private Bounds BoundingBox__BackingField;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x48")]
		private float mMaxWeight;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 mAveragePos;

		[Token(Token = "0x17000040")]
		public Transform Transform
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1902500", Offset = "0x1902500", VA = "0x1902500", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public Bounds BoundingBox
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1902508", Offset = "0x1902508", VA = "0x1902508", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x795D8", Offset = "0x795D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x190251C", Offset = "0x190251C", VA = "0x190251C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x795E8", Offset = "0x795E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public BoundingSphere Sphere
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1902530", Offset = "0x1902530", VA = "0x1902530", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000043")]
		public bool IsEmpty
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x190260C", Offset = "0x190260C", VA = "0x190260C", Slot = "9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1902728", Offset = "0x1902728", VA = "0x1902728")]
		public void AddMember(Transform t, float weight, float radius)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1902808", Offset = "0x1902808", VA = "0x1902808")]
		public void RemoveMember(Transform t)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x19028E0", Offset = "0x19028E0", VA = "0x19028E0")]
		public int FindMember(Transform t)
		{
			return default;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x19029CC", Offset = "0x19029CC", VA = "0x19029CC")]
		public BoundingSphere GetWeightedBoundsForMember(int index)
		{
			return default;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1902C64", Offset = "0x1902C64", VA = "0x1902C64", Slot = "5")]
		public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer)
		{
			return default;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1902AF0", Offset = "0x1902AF0", VA = "0x1902AF0")]
		private static BoundingSphere WeightedMemberBounds(Target t, Vector3 avgPos, float maxWeight)
		{
			return default;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1902DC0", Offset = "0x1902DC0", VA = "0x1902DC0")]
		public void DoUpdate()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1902EC8", Offset = "0x1902EC8", VA = "0x1902EC8")]
		private Vector3 CalculateAveragePosition(out float maxWeight)
		{
			return default;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x19032A0", Offset = "0x19032A0", VA = "0x19032A0")]
		private Quaternion CalculateAverageOrientation()
		{
			return default;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x19030A4", Offset = "0x19030A4", VA = "0x19030A4")]
		private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight)
		{
			return default;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x190340C", Offset = "0x190340C", VA = "0x190340C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x19034D8", Offset = "0x19034D8", VA = "0x19034D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x19034EC", Offset = "0x19034EC", VA = "0x19034EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x190352C", Offset = "0x190352C", VA = "0x190352C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1903540", Offset = "0x1903540", VA = "0x1903540", Slot = "6")]
		public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x19037E8", Offset = "0x19037E8", VA = "0x19037E8")]
		public CinemachineTargetGroup()
		{
		}
	}
}
