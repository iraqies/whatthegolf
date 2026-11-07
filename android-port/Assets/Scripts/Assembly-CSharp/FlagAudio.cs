using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Audio.Rumble;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

[Token(Token = "0x2000397")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3F644", Offset = "0x3F644")]
public class FlagAudio : MonoBehaviour
{
	[Token(Token = "0x2000398")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F6AC", Offset = "0x3F6AC")]
	private sealed class _003CPlayAfterDelay_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40013D9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40013DA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40013DB")]
		[FieldOffset(Offset = "0x20")]
		public FlagAudio _003C_003E4__this;

		[Token(Token = "0x17000205")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001106")]
			[Address(RVA = "0x17A763C", Offset = "0x17A763C", VA = "0x17A763C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000206")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001108")]
			[Address(RVA = "0x17A7684", Offset = "0x17A7684", VA = "0x17A7684", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001103")]
		[Address(RVA = "0x17A74D0", Offset = "0x17A74D0", VA = "0x17A74D0")]
		[DebuggerHidden]
		public _003CPlayAfterDelay_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001104")]
		[Address(RVA = "0x17A74FC", Offset = "0x17A74FC", VA = "0x17A74FC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001105")]
		[Address(RVA = "0x17A7500", Offset = "0x17A7500", VA = "0x17A7500", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001106")]
		[Address(RVA = "0x17A763C", Offset = "0x17A763C", VA = "0x17A763C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001107")]
		[Address(RVA = "0x17A7644", Offset = "0x17A7644", VA = "0x17A7644", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001108")]
		[Address(RVA = "0x17A7684", Offset = "0x17A7684", VA = "0x17A7684", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40013CF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float playAfterDelay;

	[Token(Token = "0x40013D0")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float volume;

	[Token(Token = "0x40013D1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip sfxHit;

	[Token(Token = "0x40013D2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ClipSettingsCollection hitFullApplauseSFX;

	[Token(Token = "0x40013D3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ClipSettingsCollection hitNoApplauseSFX;

	[Token(Token = "0x40013D4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RumbleEventAsset rumble;

	[Token(Token = "0x40013D5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioMixerSnapshot snapshot;

	[Token(Token = "0x40013D6")]
	[FieldOffset(Offset = "0x48")]
	private GolfGoal goal;

	[Token(Token = "0x40013D7")]
	[FieldOffset(Offset = "0x50")]
	private float nextAudio;

	[Token(Token = "0x40013D8")]
	[FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CE70", Offset = "0x4CE70")]
	private bool PlayAudioRemotely__BackingField;

	[Token(Token = "0x17000204")]
	public bool PlayAudioRemotely
	{
		[Token(Token = "0x60010F9")]
		[Address(RVA = "0x1469F00", Offset = "0x1469F00", VA = "0x1469F00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6177C", Offset = "0x6177C")]
		get
		{
			return default;
		}
		[Token(Token = "0x60010FA")]
		[Address(RVA = "0x1469F08", Offset = "0x1469F08", VA = "0x1469F08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6178C", Offset = "0x6178C")]
		set
		{
		}
	}

	[Token(Token = "0x60010FB")]
	[Address(RVA = "0x1469F10", Offset = "0x1469F10", VA = "0x1469F10")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60010FC")]
	[Address(RVA = "0x146A040", Offset = "0x146A040", VA = "0x146A040")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60010FD")]
	[Address(RVA = "0x146A150", Offset = "0x146A150", VA = "0x146A150")]
	private void Goal_OnGoalProgress(GolfBallController controller, string message)
	{
	}

	[Token(Token = "0x60010FE")]
	[Address(RVA = "0x146A154", Offset = "0x146A154", VA = "0x146A154")]
	private void Goal_OnGoal(string obj)
	{
	}

	[Token(Token = "0x60010FF")]
	[Address(RVA = "0x146A2A0", Offset = "0x146A2A0", VA = "0x146A2A0")]
	public void GoodHit()
	{
	}

	[Token(Token = "0x6001100")]
	[Address(RVA = "0x146A3CC", Offset = "0x146A3CC", VA = "0x146A3CC")]
	public void BadHit()
	{
	}

	[Token(Token = "0x6001101")]
	[Address(RVA = "0x146A22C", Offset = "0x146A22C", VA = "0x146A22C")]
	private IEnumerator PlayAfterDelay()
	{
		return null;
	}

	[Token(Token = "0x6001102")]
	[Address(RVA = "0x146A4B4", Offset = "0x146A4B4", VA = "0x146A4B4")]
	public FlagAudio()
	{
	}
}
