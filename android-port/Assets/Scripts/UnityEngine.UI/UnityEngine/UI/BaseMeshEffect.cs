using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000076")]
	[ExecuteAlways]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
	{
		[NonSerialized]
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x18")]
		private Graphic m_Graphic;

		[Token(Token = "0x17000150")]
		protected Graphic graphic
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x2BF91B0", Offset = "0x2BF91B0", VA = "0x2BF91B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2BF925C", Offset = "0x2BF925C", VA = "0x2BF925C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2BF931C", Offset = "0x2BF931C", VA = "0x2BF931C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2BF93CC", Offset = "0x2BF93CC", VA = "0x2BF93CC", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2BF947C", Offset = "0x2BF947C", VA = "0x2BF947C", Slot = "19")]
		public virtual void ModifyMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x60004F6")]
		public abstract void ModifyMesh(VertexHelper vh);

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2BF9610", Offset = "0x2BF9610", VA = "0x2BF9610")]
		protected BaseMeshEffect()
		{
		}
	}
}
