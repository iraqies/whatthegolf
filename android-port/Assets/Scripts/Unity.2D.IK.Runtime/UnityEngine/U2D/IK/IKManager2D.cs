using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.U2D.IK
{
	[Token(Token = "0x2000003")]
	[Attribute(Name = "DefaultExecutionOrder", RVA = "0x1B0B5C", Offset = "0x1B0B5C")]
	[ExecuteInEditMode]
	[Attribute(Name = "MovedFromAttribute", RVA = "0x1B0B5C", Offset = "0x1B0B5C")]
	public class IKManager2D : MonoBehaviour
	{
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Solver2D> m_Solvers;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1B0D84", Offset = "0x1B0D84")]
		[SerializeField]
		private float m_Weight;

		[Token(Token = "0x17000009")]
		public float weight
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2A12898", Offset = "0x2A12898", VA = "0x2A12898")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2A128A0", Offset = "0x2A128A0", VA = "0x2A128A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public List<Solver2D> solvers
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2A128C8", Offset = "0x2A128C8", VA = "0x2A128C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A128D0", Offset = "0x2A128D0", VA = "0x2A128D0")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2A12900", Offset = "0x2A12900", VA = "0x2A12900")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2A12904", Offset = "0x2A12904", VA = "0x2A12904")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2A12908", Offset = "0x2A12908", VA = "0x2A12908")]
		private void FindChildSolvers()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2A12B6C", Offset = "0x2A12B6C", VA = "0x2A12B6C")]
		public void AddSolver(Solver2D solver)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A12C10", Offset = "0x2A12C10", VA = "0x2A12C10")]
		public void RemoveSolver(Solver2D solver)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2A12C78", Offset = "0x2A12C78", VA = "0x2A12C78")]
		public void UpdateManager()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2A130BC", Offset = "0x2A130BC", VA = "0x2A130BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2A128FC", Offset = "0x2A128FC", VA = "0x2A128FC")]
		private void OnEditorDataValidate()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2A12C0C", Offset = "0x2A12C0C", VA = "0x2A12C0C")]
		private void AddSolverEditorData()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2A12C74", Offset = "0x2A12C74", VA = "0x2A12C74")]
		private void RemoveSolverEditorData(Solver2D solver)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2A130C0", Offset = "0x2A130C0", VA = "0x2A130C0")]
		public IKManager2D()
		{
		}
	}
}
