using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x2000077")]
	public static class TMPro_EventManager
	{
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT;

		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x8")]
		public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT;

		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x10")]
		public static readonly FastAction<bool, Object> FONT_PROPERTY_EVENT;

		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x18")]
		public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT;

		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x20")]
		public static readonly FastAction<bool, Object> TEXTMESHPRO_PROPERTY_EVENT;

		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x28")]
		public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT;

		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x30")]
		public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT;

		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x38")]
		public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT;

		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x40")]
		public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT;

		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x48")]
		public static readonly FastAction RESOURCE_LOAD_EVENT;

		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x50")]
		public static readonly FastAction<bool, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT;

		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x58")]
		public static readonly FastAction<Object> TEXT_CHANGED_EVENT;

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2ABC6A4", Offset = "0x2ABC6A4", VA = "0x2ABC6A4")]
		public static void ON_TEXT_CHANGED(Object obj)
		{
		}
	}
}
