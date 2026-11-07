using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Token(Token = "0x200001E")]
	internal sealed class SplineSpawnerEditorSettings : ScriptableObject
	{
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_AutomaticUpdate;

		[Token(Token = "0x17000032")]
		internal bool automaticUpdate
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x2A0D18C", Offset = "0x2A0D18C", VA = "0x2A0D18C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2A0D194", Offset = "0x2A0D194", VA = "0x2A0D194")]
		public SplineSpawnerEditorSettings()
		{
		}
	}
}
