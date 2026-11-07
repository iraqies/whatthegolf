using System;
using Il2CppDummyDll;

namespace UnityEngine.U2D.IK
{
	[Serializable]
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "MovedFromAttribute", RVA = "0x1B0B24", Offset = "0x1B0B24")]
	public class IKChain2D
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B0C9C", Offset = "0x1B0C9C")]
		private Transform m_EffectorTransform;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B0CE8", Offset = "0x1B0CE8")]
		[SerializeField]
		private Transform m_TargetTransform;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_TransformCount;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform[] m_Transforms;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Quaternion[] m_DefaultLocalRotations;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Quaternion[] m_StoredLocalRotations;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x40")]
		protected float[] m_Lengths;

		[Token(Token = "0x17000001")]
		public Transform effector
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2A11E5C", Offset = "0x2A11E5C", VA = "0x2A11E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public Transform target
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2A11E64", Offset = "0x2A11E64", VA = "0x2A11E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public Transform[] transforms
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2A11E6C", Offset = "0x2A11E6C", VA = "0x2A11E6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public Transform rootTransform
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2A11E74", Offset = "0x2A11E74", VA = "0x2A11E74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private Transform lastTransform
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2A11EBC", Offset = "0x2A11EBC", VA = "0x2A11EBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public int transformCount
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2A11F0C", Offset = "0x2A11F0C", VA = "0x2A11F0C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2A11F14", Offset = "0x2A11F14", VA = "0x2A11F14")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool isValid
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2A11F40", Offset = "0x2A11F40", VA = "0x2A11F40")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000008")]
		public float[] lengths
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2A120E8", Offset = "0x2A120E8", VA = "0x2A120E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2A11F44", Offset = "0x2A11F44", VA = "0x2A11F44")]
		private bool Validate()
		{
			return default;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2A123B4", Offset = "0x2A123B4", VA = "0x2A123B4")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2A12120", Offset = "0x2A12120", VA = "0x2A12120")]
		private void PrepareLengths()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2A12634", Offset = "0x2A12634", VA = "0x2A12634")]
		public void RestoreDefaultPose(bool targetRotationIsConstrained)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2A126DC", Offset = "0x2A126DC", VA = "0x2A126DC")]
		public void StoreLocalRotations()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2A12780", Offset = "0x2A12780", VA = "0x2A12780")]
		public void BlendFkToIk(float finalWeight, bool targetRotationIsConstrained)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2A12890", Offset = "0x2A12890", VA = "0x2A12890")]
		public IKChain2D()
		{
		}
	}
}
