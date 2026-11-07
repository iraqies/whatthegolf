using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000EF")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x18")]
		public bool fixTransforms;

		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x170000D5")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x13FC354", Offset = "0x13FC354", VA = "0x13FC354")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D6")]
		private bool isAnimated
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x13FC690", Offset = "0x13FC690", VA = "0x13FC690")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x13FC198", Offset = "0x13FC198", VA = "0x13FC198")]
		public void Disable()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x13FC23C", Offset = "0x13FC23C", VA = "0x13FC23C", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x13FC240", Offset = "0x13FC240", VA = "0x13FC240", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x13FC244", Offset = "0x13FC244", VA = "0x13FC244", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x13FC248", Offset = "0x13FC248", VA = "0x13FC248")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x13FC300", Offset = "0x13FC300", VA = "0x13FC300")]
		private void Start()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x13FC2AC", Offset = "0x13FC2AC", VA = "0x13FC2AC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x13FC640", Offset = "0x13FC640", VA = "0x13FC640")]
		private void Update()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x13FC44C", Offset = "0x13FC44C", VA = "0x13FC44C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x13FC758", Offset = "0x13FC758", VA = "0x13FC758")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x13FC7BC", Offset = "0x13FC7BC", VA = "0x13FC7BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x13FC818", Offset = "0x13FC818", VA = "0x13FC818")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x13FC860", Offset = "0x13FC860", VA = "0x13FC860")]
		public SolverManager()
		{
		}
	}
}
