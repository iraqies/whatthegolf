using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

[Token(Token = "0x2000A86")]
public class TempEndMenu : MonoBehaviour
{
	[Token(Token = "0x2000A87")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42E50", Offset = "0x42E50")]
	private sealed class _003CSignupCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003A70")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003A71")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003A72")]
		[FieldOffset(Offset = "0x20")]
		public TempEndMenu _003C_003E4__this;

		[Token(Token = "0x4003A73")]
		[FieldOffset(Offset = "0x28")]
		public string email;

		[Token(Token = "0x4003A74")]
		[FieldOffset(Offset = "0x30")]
		public string comment;

		[Token(Token = "0x4003A75")]
		[FieldOffset(Offset = "0x38")]
		private UnityWebRequest _003Cwww_003E5__2;

		[Token(Token = "0x1700052F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003246")]
			[Address(RVA = "0x18622E0", Offset = "0x18622E0", VA = "0x18622E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000530")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003248")]
			[Address(RVA = "0x1862328", Offset = "0x1862328", VA = "0x1862328", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003242")]
		[Address(RVA = "0x1861BFC", Offset = "0x1861BFC", VA = "0x1861BFC")]
		[DebuggerHidden]
		public _003CSignupCoroutine_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003243")]
		[Address(RVA = "0x1861C28", Offset = "0x1861C28", VA = "0x1861C28", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003244")]
		[Address(RVA = "0x1861CA8", Offset = "0x1861CA8", VA = "0x1861CA8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003245")]
		[Address(RVA = "0x1861C74", Offset = "0x1861C74", VA = "0x1861C74")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6003246")]
		[Address(RVA = "0x18622E0", Offset = "0x18622E0", VA = "0x18622E0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003247")]
		[Address(RVA = "0x18622E8", Offset = "0x18622E8", VA = "0x18622E8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003248")]
		[Address(RVA = "0x1862328", Offset = "0x1862328", VA = "0x1862328", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003A62")]
	[FieldOffset(Offset = "0x18")]
	public TMP_InputField IdeaInputField;

	[Token(Token = "0x4003A63")]
	[FieldOffset(Offset = "0x20")]
	public TMP_InputField EmailInputField;

	[Token(Token = "0x4003A64")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI ErrorText;

	[Token(Token = "0x4003A65")]
	[FieldOffset(Offset = "0x30")]
	public ConfettiSpawner ConfettiSpawner;

	[Token(Token = "0x4003A66")]
	[FieldOffset(Offset = "0x38")]
	public OverworldGoalWithMenuPopup ConfettiSpawnPosition;

	[Token(Token = "0x4003A67")]
	[FieldOffset(Offset = "0x40")]
	public List<AudioClip> SuccessClips;

	[Token(Token = "0x4003A68")]
	[FieldOffset(Offset = "0x48")]
	public List<AudioClip> FailClips;

	[Token(Token = "0x4003A69")]
	[FieldOffset(Offset = "0x50")]
	public float Duration;

	[Token(Token = "0x4003A6A")]
	[FieldOffset(Offset = "0x54")]
	public float Speed;

	[Token(Token = "0x4003A6B")]
	[FieldOffset(Offset = "0x58")]
	public float Magnitude;

	[Token(Token = "0x4003A6C")]
	[FieldOffset(Offset = "0x60")]
	private string postUrl;

	[Token(Token = "0x4003A6D")]
	[FieldOffset(Offset = "0x68")]
	private string serverConnectionError;

	[Token(Token = "0x4003A6E")]
	[FieldOffset(Offset = "0x70")]
	private string signupError;

	[Token(Token = "0x4003A6F")]
	[FieldOffset(Offset = "0x78")]
	private PerlinShake shaker;

	[Token(Token = "0x600323B")]
	[Address(RVA = "0x16F8100", Offset = "0x16F8100", VA = "0x16F8100")]
	private void Start()
	{
	}

	[Token(Token = "0x600323C")]
	[Address(RVA = "0x16F815C", Offset = "0x16F815C", VA = "0x16F815C")]
	public void SaveButtonClicked()
	{
	}

	[Token(Token = "0x600323D")]
	[Address(RVA = "0x16F8240", Offset = "0x16F8240", VA = "0x16F8240")]
	private IEnumerator SignupCoroutine(string email, string comment)
	{
		return null;
	}

	[Token(Token = "0x600323E")]
	[Address(RVA = "0x16F82C8", Offset = "0x16F82C8", VA = "0x16F82C8")]
	private void SetErrorMessage(string message)
	{
	}

	[Token(Token = "0x600323F")]
	[Address(RVA = "0x16F8314", Offset = "0x16F8314", VA = "0x16F8314")]
	private void Update()
	{
	}

	[Token(Token = "0x6003240")]
	[Address(RVA = "0x16F83CC", Offset = "0x16F83CC", VA = "0x16F83CC")]
	private bool IsValidEmail(string email)
	{
		return default;
	}

	[Token(Token = "0x6003241")]
	[Address(RVA = "0x16F84C8", Offset = "0x16F84C8", VA = "0x16F84C8")]
	public TempEndMenu()
	{
	}
}
