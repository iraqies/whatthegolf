using Il2CppDummyDll;
using UnityEngine;

namespace Kilt
{
	[Token(Token = "0x2000082")]
	public class DirtyBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x18")]
		protected bool _started;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x19")]
		protected bool _isDirty;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1365644", Offset = "0x1365644", VA = "0x1365644", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1365664", Offset = "0x1365664", VA = "0x1365664", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x136567C", Offset = "0x136567C", VA = "0x136567C", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x136568C", Offset = "0x136568C", VA = "0x136568C", Slot = "7")]
		public virtual void SetDirty()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1365698", Offset = "0x1365698", VA = "0x1365698", Slot = "8")]
		public virtual void TryApply(bool p_force = false)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x13656B8", Offset = "0x13656B8", VA = "0x13656B8", Slot = "9")]
		protected virtual void Apply()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x13656BC", Offset = "0x13656BC", VA = "0x13656BC")]
		public DirtyBehaviour()
		{
		}
	}
}
