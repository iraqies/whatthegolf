using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x20000B3")]
	public class Tack : MonoBehaviour
	{
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _isKinematic;

		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x19")]
		private bool m_isKinematic;

		[Token(Token = "0x170000BF")]
		public bool IsKinematic
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x13181C4", Offset = "0x13181C4", VA = "0x13181C4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x13181CC", Offset = "0x13181CC", VA = "0x13181CC")]
			set
			{
			}
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x13183F4", Offset = "0x13183F4", VA = "0x13183F4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1318400", Offset = "0x1318400", VA = "0x1318400", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x131840C", Offset = "0x131840C", VA = "0x131840C", Slot = "6")]
		protected virtual void CorrectValues()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1318324", Offset = "0x1318324", VA = "0x1318324")]
		public int GetTackIndex()
		{
			return default;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x131872C", Offset = "0x131872C", VA = "0x131872C")]
		public Tack()
		{
		}
	}
}
