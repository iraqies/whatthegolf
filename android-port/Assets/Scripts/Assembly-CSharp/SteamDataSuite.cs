using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

[Token(Token = "0x2000CDC")]
public static class SteamDataSuite
{
	[Token(Token = "0x2000CDD")]
	private class SteamDataSuiteRunner : MonoBehaviour
	{
		[Token(Token = "0x6003CE0")]
		[Address(RVA = "0x185AFFC", Offset = "0x185AFFC", VA = "0x185AFFC")]
		public SteamDataSuiteRunner()
		{
		}
	}

	[Token(Token = "0x2000CDE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44508", Offset = "0x44508")]
	private sealed class _003CHandleFormPost_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40045EA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40045EB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40045EC")]
		[FieldOffset(Offset = "0x20")]
		public SteamDataSuiteConfig config;

		[Token(Token = "0x40045ED")]
		[FieldOffset(Offset = "0x28")]
		private UnityWebRequest _003Cwww_003E5__2;

		[Token(Token = "0x1700063E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003CE4")]
			[Address(RVA = "0x185AFAC", Offset = "0x185AFAC", VA = "0x185AFAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700063F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003CE6")]
			[Address(RVA = "0x185AFF4", Offset = "0x185AFF4", VA = "0x185AFF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0x185AC24", Offset = "0x185AC24", VA = "0x185AC24")]
		[DebuggerHidden]
		public _003CHandleFormPost_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0x185AC50", Offset = "0x185AC50", VA = "0x185AC50", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003CE3")]
		[Address(RVA = "0x185AC54", Offset = "0x185AC54", VA = "0x185AC54", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003CE4")]
		[Address(RVA = "0x185AFAC", Offset = "0x185AFAC", VA = "0x185AFAC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003CE5")]
		[Address(RVA = "0x185AFB4", Offset = "0x185AFB4", VA = "0x185AFB4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003CE6")]
		[Address(RVA = "0x185AFF4", Offset = "0x185AFF4", VA = "0x185AFF4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40045E8")]
	[FieldOffset(Offset = "0x0")]
	private static SteamDataSuiteRunner _instance;

	[Token(Token = "0x40045E9")]
	[FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5142C", Offset = "0x5142C")]
	private static Action<string> m_OnSuccessfulHTTPResponse;

	[Token(Token = "0x14000077")]
	public static event Action<string> OnSuccessfulHTTPResponse
	{
		[Token(Token = "0x6003CDA")]
		[Address(RVA = "0x16DE02C", Offset = "0x16DE02C", VA = "0x16DE02C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BE0C", Offset = "0x6BE0C")]
		add
		{
		}
		[Token(Token = "0x6003CDB")]
		[Address(RVA = "0x16DE550", Offset = "0x16DE550", VA = "0x16DE550")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BE1C", Offset = "0x6BE1C")]
		remove
		{
		}
	}

	[Token(Token = "0x6003CDC")]
	[Address(RVA = "0x16DE0F0", Offset = "0x16DE0F0", VA = "0x16DE0F0")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6003CDD")]
	[Address(RVA = "0x16DE614", Offset = "0x16DE614", VA = "0x16DE614")]
	private static void InternalInit()
	{
	}

	[Token(Token = "0x6003CDE")]
	[Address(RVA = "0x16DE804", Offset = "0x16DE804", VA = "0x16DE804")]
	private static void SendForm(SteamDataSuiteConfig config)
	{
	}

	[Token(Token = "0x6003CDF")]
	[Address(RVA = "0x16DE998", Offset = "0x16DE998", VA = "0x16DE998")]
	private static IEnumerator HandleFormPost(SteamDataSuiteConfig config)
	{
		return null;
	}
}
