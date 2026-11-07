using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000002")]
public class AnimatedGifCombiner : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x32FDC", Offset = "0x32FDC")]
	private sealed class _003CLoad_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x20")]
		public AnimatedGifCombiner _003C_003E4__this;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x28")]
		private List<MemoryStream> _003Cstreams_003E5__2;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x30")]
		private List<string>.Enumerator _003C_003E7__wrap2;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x48")]
		private string _003Cpath_003E5__4;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x50")]
		private WWW _003Cwww_003E5__5;

		[Token(Token = "0x17000001")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x13315A8", Offset = "0x13315A8", VA = "0x13315A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000002")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x13315F0", Offset = "0x13315F0", VA = "0x13315F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1330BBC", Offset = "0x1330BBC", VA = "0x1330BBC")]
		[DebuggerHidden]
		public _003CLoad_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1330BE8", Offset = "0x1330BE8", VA = "0x1330BE8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1330E6C", Offset = "0x1330E6C", VA = "0x1330E6C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1330E10", Offset = "0x1330E10", VA = "0x1330E10")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1330D4C", Offset = "0x1330D4C", VA = "0x1330D4C")]
		private void _003C_003Em__Finally2()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x13315A8", Offset = "0x13315A8", VA = "0x13315A8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x13315B0", Offset = "0x13315B0", VA = "0x13315B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x13315F0", Offset = "0x13315F0", VA = "0x13315F0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	private List<string> filePaths;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x12EBBA4", Offset = "0x12EBBA4", VA = "0x12EBBA4")]
	public void SetFilePaths(List<string> paths)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x12EBC24", Offset = "0x12EBC24", VA = "0x12EBC24")]
	private IEnumerator Load()
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x12EBC98", Offset = "0x12EBC98", VA = "0x12EBC98")]
	public AnimatedGifCombiner()
	{
	}
}
