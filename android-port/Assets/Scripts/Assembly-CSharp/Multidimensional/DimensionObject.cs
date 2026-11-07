using Il2CppDummyDll;
using UnityEngine;

namespace Multidimensional
{
	[Token(Token = "0x20010C9")]
	public class DimensionObject : MonoBehaviour
	{
		[Token(Token = "0x400586A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Dimension ParentDimension;

		[Token(Token = "0x400586B")]
		[FieldOffset(Offset = "0x20")]
		private DimensionManager dimensionManager;

		[Token(Token = "0x6004B2A")]
		[Address(RVA = "0x18DCC4C", Offset = "0x18DCC4C", VA = "0x18DCC4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6004B2B")]
		[Address(RVA = "0x18DCBC4", Offset = "0x18DCBC4", VA = "0x18DCBC4")]
		public void Shift()
		{
		}

		[Token(Token = "0x6004B2C")]
		[Address(RVA = "0x18DCCFC", Offset = "0x18DCCFC", VA = "0x18DCCFC")]
		public DimensionObject()
		{
		}
	}
}
