using Il2CppDummyDll;
using UnityEngine;

namespace Multidimensional
{
	[Token(Token = "0x20010C8")]
	public class DimensionManager : MonoBehaviour
	{
		[Token(Token = "0x4005867")]
		[FieldOffset(Offset = "0x18")]
		public Dimension CurrentDimension;

		[Token(Token = "0x4005868")]
		[FieldOffset(Offset = "0x20")]
		private DimensionObject[] dimensionObjects;

		[Token(Token = "0x4005869")]
		[FieldOffset(Offset = "0x28")]
		private Dimension StartDimension;

		[Token(Token = "0x6004B26")]
		[Address(RVA = "0x18DC99C", Offset = "0x18DC99C", VA = "0x18DC99C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004B27")]
		[Address(RVA = "0x18DCB18", Offset = "0x18DCB18", VA = "0x18DCB18")]
		private void SwitchDimension(Vector3 boost)
		{
		}

		[Token(Token = "0x6004B28")]
		[Address(RVA = "0x18DCC08", Offset = "0x18DCC08", VA = "0x18DCC08")]
		public DimensionManager()
		{
		}

		[Token(Token = "0x6004B29")]
		[Address(RVA = "0x18DCC10", Offset = "0x18DCC10", VA = "0x18DCC10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F914", Offset = "0x6F914")]
		private void _003CAwake_003Eb__3_0()
		{
		}
	}
}
