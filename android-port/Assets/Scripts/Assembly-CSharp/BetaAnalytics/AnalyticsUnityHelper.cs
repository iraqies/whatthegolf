using System;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

namespace BetaAnalytics
{
	[Token(Token = "0x2001127")]
	public class AnalyticsUnityHelper : MonoBehaviour
	{
		[Token(Token = "0x4005AD9")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56CB0", Offset = "0x56CB0")]
		private Action<bool> m_onApplicationFocus;

		[Token(Token = "0x4005ADA")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56CC0", Offset = "0x56CC0")]
		private Action m_onApplicationQuit;

		[Token(Token = "0x4005ADB")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56CD0", Offset = "0x56CD0")]
		private Action m_onUpdate;

		[Token(Token = "0x14000080")]
		public event Action<bool> onApplicationFocus
		{
			[Token(Token = "0x6004D52")]
			[Address(RVA = "0x141592C", Offset = "0x141592C", VA = "0x141592C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD08", Offset = "0x6FD08")]
			add
			{
			}
			[Token(Token = "0x6004D53")]
			[Address(RVA = "0x14159D0", Offset = "0x14159D0", VA = "0x14159D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD18", Offset = "0x6FD18")]
			remove
			{
			}
		}

		[Token(Token = "0x14000081")]
		public event Action onApplicationQuit
		{
			[Token(Token = "0x6004D54")]
			[Address(RVA = "0x1415A74", Offset = "0x1415A74", VA = "0x1415A74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD28", Offset = "0x6FD28")]
			add
			{
			}
			[Token(Token = "0x6004D55")]
			[Address(RVA = "0x1415B18", Offset = "0x1415B18", VA = "0x1415B18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD38", Offset = "0x6FD38")]
			remove
			{
			}
		}

		[Token(Token = "0x14000082")]
		public event Action onUpdate
		{
			[Token(Token = "0x6004D56")]
			[Address(RVA = "0x1415BBC", Offset = "0x1415BBC", VA = "0x1415BBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD48", Offset = "0x6FD48")]
			add
			{
			}
			[Token(Token = "0x6004D57")]
			[Address(RVA = "0x1415C60", Offset = "0x1415C60", VA = "0x1415C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD58", Offset = "0x6FD58")]
			remove
			{
			}
		}

		[Token(Token = "0x6004D58")]
		[Address(RVA = "0x1415D04", Offset = "0x1415D04", VA = "0x1415D04")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004D59")]
		[Address(RVA = "0x1415E78", Offset = "0x1415E78", VA = "0x1415E78")]
		private void OnApplicationFocus(bool focus)
		{
		}

		[Token(Token = "0x6004D5A")]
		[Address(RVA = "0x1415EE8", Offset = "0x1415EE8", VA = "0x1415EE8")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6004D5B")]
		[Address(RVA = "0x1415EFC", Offset = "0x1415EFC", VA = "0x1415EFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6004D5C")]
		[Address(RVA = "0x1415DFC", Offset = "0x1415DFC", VA = "0x1415DFC")]
		private void ReInput_ControllerStatusChanged(ControllerStatusChangedEventArgs obj)
		{
		}

		[Token(Token = "0x6004D5D")]
		[Address(RVA = "0x1415F10", Offset = "0x1415F10", VA = "0x1415F10")]
		public AnalyticsUnityHelper()
		{
		}
	}
}
