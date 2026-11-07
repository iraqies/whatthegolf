using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000E8")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1365120", Offset = "0x1365120", VA = "0x1365120")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1365278", Offset = "0x1365278", VA = "0x1365278")]
		public DemoGUIMessage()
		{
		}
	}
}
