using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Prime31
{
	[Token(Token = "0x2000018")]
	public class LifecycleHelper : MonoBehaviour
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1905C0", Offset = "0x1905C0")]
		private Action<bool> m_onApplicationPausedEvent;

		[Token(Token = "0x14000001")]
		public event Action<bool> onApplicationPausedEvent
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x233D314", Offset = "0x233D314", VA = "0x233D314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190650", Offset = "0x190650")]
			add
			{
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x233D3B8", Offset = "0x233D3B8", VA = "0x233D3B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190660", Offset = "0x190660")]
			remove
			{
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x233D45C", Offset = "0x233D45C", VA = "0x233D45C")]
		private void OnApplicationPause(bool paused)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x233D4CC", Offset = "0x233D4CC", VA = "0x233D4CC")]
		public LifecycleHelper()
		{
		}
	}
}
