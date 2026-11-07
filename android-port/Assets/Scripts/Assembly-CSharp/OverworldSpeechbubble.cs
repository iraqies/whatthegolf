using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000A52")]
public class OverworldSpeechbubble : MonoBehaviour
{
	[Token(Token = "0x2000A53")]
	public enum SpeechbubbleStateEnum
	{
		[Token(Token = "0x4003916")]
		Inactive = 0,
		[Token(Token = "0x4003917")]
		DisplayingText = 1,
		[Token(Token = "0x4003918")]
		Idle = 2,
		[Token(Token = "0x4003919")]
		Disabling = 3
	}

	[Token(Token = "0x2000A54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42C80", Offset = "0x42C80")]
	private sealed class _003CShowText_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400391A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400391B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400391C")]
		[FieldOffset(Offset = "0x20")]
		public OverworldSpeechbubble _003C_003E4__this;

		[Token(Token = "0x400391D")]
		[FieldOffset(Offset = "0x28")]
		public SpeechbubbleList textList;

		[Token(Token = "0x400391E")]
		[FieldOffset(Offset = "0x30")]
		private float _003CdisappearTimer_003E5__2;

		[Token(Token = "0x17000514")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003138")]
			[Address(RVA = "0x181E078", Offset = "0x181E078", VA = "0x181E078", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000515")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600313A")]
			[Address(RVA = "0x181E0C0", Offset = "0x181E0C0", VA = "0x181E0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003135")]
		[Address(RVA = "0x181DA80", Offset = "0x181DA80", VA = "0x181DA80")]
		[DebuggerHidden]
		public _003CShowText_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003136")]
		[Address(RVA = "0x181DAAC", Offset = "0x181DAAC", VA = "0x181DAAC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003137")]
		[Address(RVA = "0x181DAB0", Offset = "0x181DAB0", VA = "0x181DAB0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003138")]
		[Address(RVA = "0x181E078", Offset = "0x181E078", VA = "0x181E078", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003139")]
		[Address(RVA = "0x181E080", Offset = "0x181E080", VA = "0x181E080", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600313A")]
		[Address(RVA = "0x181E0C0", Offset = "0x181E0C0", VA = "0x181E0C0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A55")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42C90", Offset = "0x42C90")]
	private sealed class _003CPlaySounds_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400391F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003920")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003921")]
		[FieldOffset(Offset = "0x20")]
		public OverworldSpeechbubble _003C_003E4__this;

		[Token(Token = "0x17000516")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600313E")]
			[Address(RVA = "0x181DA30", Offset = "0x181DA30", VA = "0x181DA30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000517")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003140")]
			[Address(RVA = "0x181DA78", Offset = "0x181DA78", VA = "0x181DA78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600313B")]
		[Address(RVA = "0x181D944", Offset = "0x181D944", VA = "0x181D944")]
		[DebuggerHidden]
		public _003CPlaySounds_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600313C")]
		[Address(RVA = "0x181D970", Offset = "0x181D970", VA = "0x181D970", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600313D")]
		[Address(RVA = "0x181D974", Offset = "0x181D974", VA = "0x181D974", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600313E")]
		[Address(RVA = "0x181DA30", Offset = "0x181DA30", VA = "0x181DA30", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600313F")]
		[Address(RVA = "0x181DA38", Offset = "0x181DA38", VA = "0x181DA38", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003140")]
		[Address(RVA = "0x181DA78", Offset = "0x181DA78", VA = "0x181DA78", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003904")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro Text;

	[Token(Token = "0x4003905")]
	[FieldOffset(Offset = "0x20")]
	public Transform BubbleContainer;

	[Token(Token = "0x4003906")]
	[FieldOffset(Offset = "0x28")]
	public Transform BubbleWithText;

	[Token(Token = "0x4003907")]
	[FieldOffset(Offset = "0x30")]
	public float WaitTimeBetweenLetters;

	[Token(Token = "0x4003908")]
	[FieldOffset(Offset = "0x34")]
	public float TimeBeforeDisappear;

	[Token(Token = "0x4003909")]
	[FieldOffset(Offset = "0x38")]
	public float HitBlockTime;

	[Token(Token = "0x400390A")]
	[FieldOffset(Offset = "0x3C")]
	public float WaitTimeBetweenSounds;

	[Token(Token = "0x400390B")]
	[FieldOffset(Offset = "0x40")]
	public RandomAudioClips speechClips;

	[Token(Token = "0x400390C")]
	[FieldOffset(Offset = "0x48")]
	private SpeechbubbleStateEnum state;

	[Token(Token = "0x400390D")]
	[FieldOffset(Offset = "0x4C")]
	private int counter;

	[Token(Token = "0x400390E")]
	[FieldOffset(Offset = "0x50")]
	private int visibleCount;

	[Token(Token = "0x400390F")]
	[FieldOffset(Offset = "0x54")]
	private int totalVisibleCharacters;

	[Token(Token = "0x4003910")]
	[FieldOffset(Offset = "0x58")]
	private float lastHitTime;

	[Token(Token = "0x4003911")]
	[FieldOffset(Offset = "0x60")]
	private Coroutine ShowBubbleRoutine;

	[Token(Token = "0x4003912")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine PlaySoundRoutine;

	[Token(Token = "0x4003913")]
	[FieldOffset(Offset = "0x70")]
	private List<Interlocutor> interlocutors;

	[Token(Token = "0x4003914")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<SpeechbubbleList, IConversation> conversations;

	[Token(Token = "0x600312E")]
	[Address(RVA = "0x15CC444", Offset = "0x15CC444", VA = "0x15CC444")]
	private IEnumerator ShowText(SpeechbubbleList textList)
	{
		return null;
	}

	[Token(Token = "0x600312F")]
	[Address(RVA = "0x15CC4BC", Offset = "0x15CC4BC", VA = "0x15CC4BC")]
	private IEnumerator PlaySounds()
	{
		return null;
	}

	[Token(Token = "0x6003130")]
	[Address(RVA = "0x15CC530", Offset = "0x15CC530", VA = "0x15CC530")]
	public void ShowSpeechbubble(SpeechbubbleList list, List<Interlocutor> interlocutors)
	{
	}

	[Token(Token = "0x6003131")]
	[Address(RVA = "0x15CC638", Offset = "0x15CC638", VA = "0x15CC638")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003132")]
	[Address(RVA = "0x15CC66C", Offset = "0x15CC66C", VA = "0x15CC66C")]
	public OverworldSpeechbubble()
	{
	}

	[Token(Token = "0x6003133")]
	[Address(RVA = "0x15CC708", Offset = "0x15CC708", VA = "0x15CC708")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x697F4", Offset = "0x697F4")]
	private void _003CShowText_003Eb__18_1(float t)
	{
	}

	[Token(Token = "0x6003134")]
	[Address(RVA = "0x15CC7DC", Offset = "0x15CC7DC", VA = "0x15CC7DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69804", Offset = "0x69804")]
	private void _003CShowText_003Eb__18_0(float t)
	{
	}
}
