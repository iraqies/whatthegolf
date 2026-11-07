using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000142")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x35B28", Offset = "0x35B28")]
		public float weight;

		[Token(Token = "0x40007BE")]
		[FieldOffset(Offset = "0x20")]
		public Grounding solver;

		[Token(Token = "0x40007BF")]
		[FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x35B40", Offset = "0x35B40")]
		private bool initiated__BackingField;

		[Token(Token = "0x17000127")]
		public bool initiated
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x137A70C", Offset = "0x137A70C", VA = "0x137A70C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3902C", Offset = "0x3902C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x137A714", Offset = "0x137A714", VA = "0x137A714")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3903C", Offset = "0x3903C")]
			protected set
			{
			}
		}

		[Token(Token = "0x60008BE")]
		public abstract void ResetPosition();

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x137A71C", Offset = "0x137A71C", VA = "0x137A71C")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default;
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x137A8D8", Offset = "0x137A8D8", VA = "0x137A8D8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x137A7C8", Offset = "0x137A7C8", VA = "0x137A7C8")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default;
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x137A90C", Offset = "0x137A90C", VA = "0x137A90C")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default;
		}

		[Token(Token = "0x60008C5")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60008C6")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x137AA40", Offset = "0x137AA40", VA = "0x137AA40")]
		protected Grounder()
		{
		}
	}
}
