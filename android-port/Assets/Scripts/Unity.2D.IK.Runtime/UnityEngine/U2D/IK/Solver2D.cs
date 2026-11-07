using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.U2D.IK
{
	[Token(Token = "0x2000006")]
	[Attribute(Name = "MovedFromAttribute", RVA = "0x1B0C2C", Offset = "0x1B0C2C")]
	public abstract class Solver2D : MonoBehaviour
	{
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_ConstrainRotation;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B0DF4", Offset = "0x1B0DF4")]
		[SerializeField]
		private bool m_SolveFromDefaultPose;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x1B0E40", Offset = "0x1B0E40")]
		private float m_Weight;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		private Plane m_Plane;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x30")]
		private List<Vector3> m_TargetPositions;

		[Token(Token = "0x1700000C")]
		public int chainCount
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2A13B98", Offset = "0x2A13B98", VA = "0x2A13B98")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000D")]
		public bool constrainRotation
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2A13BA4", Offset = "0x2A13BA4", VA = "0x2A13BA4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2A13BAC", Offset = "0x2A13BAC", VA = "0x2A13BAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public bool solveFromDefaultPose
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2A13BB4", Offset = "0x2A13BB4", VA = "0x2A13BB4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2A13BBC", Offset = "0x2A13BBC", VA = "0x2A13BBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public bool isValid
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2A12F5C", Offset = "0x2A12F5C", VA = "0x2A12F5C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000010")]
		public bool allChainsHaveTargets
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2A13C50", Offset = "0x2A13C50", VA = "0x2A13C50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000011")]
		public float weight
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2A13D3C", Offset = "0x2A13D3C", VA = "0x2A13D3C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2A13D44", Offset = "0x2A13D44", VA = "0x2A13D44")]
			set
			{
			}
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2A13D6C", Offset = "0x2A13D6C", VA = "0x2A13D6C", Slot = "4")]
		protected virtual void OnValidate()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2A13BC4", Offset = "0x2A13BC4", VA = "0x2A13BC4")]
		private bool Validate()
		{
			return default;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2A13C54", Offset = "0x2A13C54", VA = "0x2A13C54")]
		private bool HasTargets()
		{
			return default;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2A12FE8", Offset = "0x2A12FE8", VA = "0x2A12FE8")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2A13E6C", Offset = "0x2A13E6C", VA = "0x2A13E6C")]
		private void Prepare()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2A14044", Offset = "0x2A14044", VA = "0x2A14044")]
		private void PrepareEffectorPositions()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2A13068", Offset = "0x2A13068", VA = "0x2A13068")]
		public void UpdateIK(float globalWeight)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2A14188", Offset = "0x2A14188", VA = "0x2A14188")]
		public void UpdateIK(List<Vector3> positions, float globalWeight)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2A143FC", Offset = "0x2A143FC", VA = "0x2A143FC")]
		private void StoreLocalRotations()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2A1446C", Offset = "0x2A1446C", VA = "0x2A1446C")]
		private void BlendFkToIk(float finalWeight)
		{
		}

		[Token(Token = "0x600003D")]
		public abstract IKChain2D GetChain(int index);

		[Token(Token = "0x600003E")]
		protected abstract int GetChainCount();

		[Token(Token = "0x600003F")]
		protected abstract void DoUpdateIK(List<Vector3> effectorPositions);

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2A14580", Offset = "0x2A14580", VA = "0x2A14580", Slot = "8")]
		protected virtual bool DoValidate()
		{
			return default;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2A133CC", Offset = "0x2A133CC", VA = "0x2A133CC", Slot = "9")]
		protected virtual void DoInitialize()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2A14588", Offset = "0x2A14588", VA = "0x2A14588", Slot = "10")]
		protected virtual void DoPrepare()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2A1458C", Offset = "0x2A1458C", VA = "0x2A1458C", Slot = "11")]
		protected virtual Transform GetPlaneRootTransform()
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2A14614", Offset = "0x2A14614", VA = "0x2A14614")]
		protected Vector3 GetPointOnSolverPlane(Vector3 worldPosition)
		{
			return default;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2A14684", Offset = "0x2A14684", VA = "0x2A14684")]
		protected Vector3 GetWorldPositionFromSolverPlanePoint(Vector2 planePoint)
		{
			return default;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2A13B08", Offset = "0x2A13B08", VA = "0x2A13B08")]
		protected Solver2D()
		{
		}
	}
}
