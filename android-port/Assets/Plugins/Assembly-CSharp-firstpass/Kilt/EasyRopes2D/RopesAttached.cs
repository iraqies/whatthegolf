using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x20000B2")]
	public class RopesAttached : MonoBehaviour
	{
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x18")]
		public Action<Rope2D> OnRopePlugged;

		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x20")]
		public Action<Rope2D> OnRopeUnplugged;

		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x28")]
		public Action<Rope2D> OnIndirectRopeDestroyed;

		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x30")]
		public Action<Rope2D> OnIndirectRopeCreated;

		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x38")]
		public Action<Rope2D> OnIndirectRopeBreak;

		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x40")]
		public Action<Rope2D, int> OnRopeBreak;

		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x48")]
		private List<Rope2D> m_pluggedRopes;

		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x50")]
		private List<Rope2D> m_indirectRopes;

		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x58")]
		private bool _needRecalcIndirectRopes;

		[Token(Token = "0x170000BD")]
		public List<Rope2D> PluggedRopes
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x13F036C", Offset = "0x13F036C", VA = "0x13F036C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x13F03E8", Offset = "0x13F03E8", VA = "0x13F03E8")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public List<Rope2D> IndirectRopes
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x13F03F0", Offset = "0x13F03F0", VA = "0x13F03F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x13F0918", Offset = "0x13F0918", VA = "0x13F0918")]
			protected set
			{
			}
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x13F0920", Offset = "0x13F0920", VA = "0x13F0920", Slot = "4")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x13F0958", Offset = "0x13F0958", VA = "0x13F0958", Slot = "5")]
		protected virtual void HandleOnRopeDestroy(Rope2D p_rope)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x13F0964", Offset = "0x13F0964", VA = "0x13F0964", Slot = "6")]
		protected virtual void HandleOnRopeBreak(Rope2D p_rope, int p_brokenIndex)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x13F0A50", Offset = "0x13F0A50", VA = "0x13F0A50")]
		public List<GameObject> GetAllOtherAttachedObjectsInPluggedRopes()
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x13F048C", Offset = "0x13F048C", VA = "0x13F048C")]
		public List<Rope2D> GetAllIndirectRopes(bool p_includePluggedRopes = true)
		{
			return null;
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x13F0E08", Offset = "0x13F0E08", VA = "0x13F0E08")]
		public List<GameObject> GetAllIndirectObjects(bool p_includeOtherPluggedObjects = true)
		{
			return null;
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x13F1164", Offset = "0x13F1164", VA = "0x13F1164")]
		public float GetSelfMass(bool p_includeChildrens = true, bool p_multiplyByGravityScale = true)
		{
			return default;
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x13F1194", Offset = "0x13F1194", VA = "0x13F1194", Slot = "7")]
		public virtual float GetSumOfOtherObjectsMass(bool p_includeChildrens = true, bool p_multiplyByGravityScale = true)
		{
			return default;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x13F12FC", Offset = "0x13F12FC", VA = "0x13F12FC")]
		public float GetPluggedRopesMass(bool p_multiplyByGravityScale = true)
		{
			return default;
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x13F153C", Offset = "0x13F153C", VA = "0x13F153C")]
		public float GetIndirectRopesMass(bool p_includePluggedRopes = true, bool p_multiplyByGravityScale = true)
		{
			return default;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x13F170C", Offset = "0x13F170C", VA = "0x13F170C")]
		public float GetSumOfIndirectObjectsMass(bool p_includeOtherPluggedObjects = true, bool p_includeChildrens = true, bool p_multiplyByGravityScale = true)
		{
			return default;
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x13F1884", Offset = "0x13F1884", VA = "0x13F1884")]
		protected void IndirectRopeBroke(Rope2D p_destroyedRope)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x13F18FC", Offset = "0x13F18FC", VA = "0x13F18FC")]
		protected void IndirectRopeDestroyed(Rope2D p_destroyedRope)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x13F1974", Offset = "0x13F1974", VA = "0x13F1974")]
		protected void IndirectRopeCreated(Rope2D p_rope)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x13F19EC", Offset = "0x13F19EC", VA = "0x13F19EC", Slot = "8")]
		public virtual void AddPluggedRopeInList(Rope2D p_rope)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x13F1CEC", Offset = "0x13F1CEC", VA = "0x13F1CEC", Slot = "9")]
		public virtual void RemovePluggedRopeFromList(Rope2D p_rope)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x13F20FC", Offset = "0x13F20FC", VA = "0x13F20FC")]
		public RopesAttached()
		{
		}
	}
}
