using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace I2.Loc
{
	[Token(Token = "0x2001320")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		[Token(Token = "0x4006695")]
		[FieldOffset(Offset = "0x18")]
		public UnityEvent _OnLocalize;

		[Token(Token = "0x600594B")]
		[Address(RVA = "0x18C7528", Offset = "0x18C7528", VA = "0x18C7528")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600594C")]
		[Address(RVA = "0x18C7608", Offset = "0x18C7608", VA = "0x18C7608")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600594D")]
		[Address(RVA = "0x18C76C0", Offset = "0x18C76C0", VA = "0x18C76C0")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x600594E")]
		[Address(RVA = "0x18C76DC", Offset = "0x18C76DC", VA = "0x18C76DC")]
		public CustomLocalizeCallback()
		{
		}
	}
}
