using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BF9")]
public class ShareToImgur : MonoBehaviour
{
	[Token(Token = "0x2000BFA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43EE8", Offset = "0x43EE8")]
	private sealed class _003CAppScreenshotUpload_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004250")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004251")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004252")]
		[FieldOffset(Offset = "0x20")]
		public ShareToImgur _003C_003E4__this;

		[Token(Token = "0x4004253")]
		[FieldOffset(Offset = "0x28")]
		private string _003Cfilename_003E5__2;

		[Token(Token = "0x4004254")]
		[FieldOffset(Offset = "0x30")]
		private float _003CstartTime_003E5__3;

		[Token(Token = "0x170005FC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600397D")]
			[Address(RVA = "0x1848C9C", Offset = "0x1848C9C", VA = "0x1848C9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005FD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600397F")]
			[Address(RVA = "0x1848CE4", Offset = "0x1848CE4", VA = "0x1848CE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600397A")]
		[Address(RVA = "0x184875C", Offset = "0x184875C", VA = "0x184875C")]
		[DebuggerHidden]
		public _003CAppScreenshotUpload_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600397B")]
		[Address(RVA = "0x1848788", Offset = "0x1848788", VA = "0x1848788", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600397C")]
		[Address(RVA = "0x184878C", Offset = "0x184878C", VA = "0x184878C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600397D")]
		[Address(RVA = "0x1848C9C", Offset = "0x1848C9C", VA = "0x1848C9C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600397E")]
		[Address(RVA = "0x1848CA4", Offset = "0x1848CA4", VA = "0x1848CA4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600397F")]
		[Address(RVA = "0x1848CE4", Offset = "0x1848CE4", VA = "0x1848CE4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x6003976")]
	[Address(RVA = "0x169DF5C", Offset = "0x169DF5C", VA = "0x169DF5C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003977")]
	[Address(RVA = "0x169DFD8", Offset = "0x169DFD8", VA = "0x169DFD8")]
	private IEnumerator AppScreenshotUpload()
	{
		return null;
	}

	[Token(Token = "0x6003978")]
	[Address(RVA = "0x169E04C", Offset = "0x169E04C", VA = "0x169E04C")]
	public bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return default;
	}

	[Token(Token = "0x6003979")]
	[Address(RVA = "0x169E234", Offset = "0x169E234", VA = "0x169E234")]
	public ShareToImgur()
	{
	}
}
