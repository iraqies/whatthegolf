using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000A5D")]
public class ShowSpeechbubbleOnHit_Quest : MonoBehaviour
{
	[Token(Token = "0x2000A5E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42CD0", Offset = "0x42CD0")]
	private sealed class _003CHandleHit_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400398C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400398D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400398E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShowSpeechbubbleOnHit_Quest _003C_003E4__this;

		[Token(Token = "0x400398F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Func<string, string> OnPreprocessText;

		[Token(Token = "0x4003990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onTextShown;

		[Token(Token = "0x4003991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onDone;

		[Token(Token = "0x4003992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpeechbubbleList.SpeechbubbleTextInfo _003CtextInfo_003E5__2;

		[Token(Token = "0x4003993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SpeechBubbleUI.Task _003CshowTask_003E5__3;

		[Token(Token = "0x1700051F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600318B")]
			[Address(RVA = "0x184C710", Offset = "0x184C710", VA = "0x184C710", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000520")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600318D")]
			[Address(RVA = "0x184C758", Offset = "0x184C758", VA = "0x184C758", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003188")]
		[Address(RVA = "0x184BDC8", Offset = "0x184BDC8", VA = "0x184BDC8")]
		[DebuggerHidden]
		public _003CHandleHit_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003189")]
		[Address(RVA = "0x184BDF4", Offset = "0x184BDF4", VA = "0x184BDF4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600318A")]
		[Address(RVA = "0x184BDF8", Offset = "0x184BDF8", VA = "0x184BDF8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600318B")]
		[Address(RVA = "0x184C710", Offset = "0x184C710", VA = "0x184C710", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600318C")]
		[Address(RVA = "0x184C718", Offset = "0x184C718", VA = "0x184C718", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600318D")]
		[Address(RVA = "0x184C758", Offset = "0x184C758", VA = "0x184C758", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400396C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject SpeechBubblePrefab;

	[Token(Token = "0x400396D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject QuestItemParticlesPrefab;

	[Token(Token = "0x400396E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LevelData QuestLevelData;

	[Token(Token = "0x400396F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SpeechbubbleList TextList;

	[Token(Token = "0x4003970")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SpeechbubbleList TextListQuestComplete;

	[Token(Token = "0x4003971")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public QuestItemBehaviour QuestItemPrefab;

	[Token(Token = "0x4003972")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform QuestItemContainer;

	[Token(Token = "0x4003973")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject QuestMarker;

	[Token(Token = "0x4003974")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Camera QuestCamera;

	[Token(Token = "0x4003975")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UnityEvent OnQuestCompleted;

	[Token(Token = "0x4003976")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<string> ActivatorTags;

	[Token(Token = "0x4003977")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<AudioClip> OnHitClip;

	[Token(Token = "0x4003978")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float delay;

	[Token(Token = "0x4003979")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float bounceFactor;

	[Token(Token = "0x400397A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Vector2 bubbleDir;

	[Token(Token = "0x400397B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector2 localBubblePivot;

	[Token(Token = "0x400397C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float bubbleRotation;

	[Token(Token = "0x400397D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool ignoreActivatorTags;

	[Token(Token = "0x400397E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool UseRestartTimeLimit;

	[Token(Token = "0x400397F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float ConversationRestartTimeLimit;

	[Token(Token = "0x4003980")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool isAbleToTalk;

	[Token(Token = "0x4003981")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform speechBubblePreferredCenterTransform;

	[Token(Token = "0x4003982")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public SpeechAudioBase speechAudio;

	[Token(Token = "0x4003983")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private SpeechBubbleUI speechBubble;

	[Token(Token = "0x4003984")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Animator questItemBubble;

	[Token(Token = "0x4003985")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private QuestItemBehaviour questItem;

	[Token(Token = "0x4003986")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isHandlingHit;

	[Token(Token = "0x4003987")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	private bool isInterrupted;

	[Token(Token = "0x4003988")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private IConversation conversation;

	[Token(Token = "0x4003989")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float lastConversationTime;

	[Token(Token = "0x400398A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private bool questCompleted;

	[Token(Token = "0x400398B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Animator anim;

	[Token(Token = "0x6003177")]
	[Address(RVA = "0x16A776C", Offset = "0x16A776C", VA = "0x16A776C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003178")]
	[Address(RVA = "0x16A7B34", Offset = "0x16A7B34", VA = "0x16A7B34")]
	private void Update()
	{
	}

	[Token(Token = "0x6003179")]
	[Address(RVA = "0x16A7BB0", Offset = "0x16A7BB0", VA = "0x16A7BB0")]
	private void QuestIsCompleted()
	{
	}

	[Token(Token = "0x600317A")]
	[Address(RVA = "0x16A7820", Offset = "0x16A7820", VA = "0x16A7820")]
	private void ListenForInterruption()
	{
	}

	[Token(Token = "0x600317B")]
	[Address(RVA = "0x16A79E4", Offset = "0x16A79E4", VA = "0x16A79E4")]
	private void QuestSetup()
	{
	}

	[Token(Token = "0x600317C")]
	[Address(RVA = "0x16A7D08", Offset = "0x16A7D08", VA = "0x16A7D08")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x600317D")]
	[Address(RVA = "0x16A7FBC", Offset = "0x16A7FBC", VA = "0x16A7FBC")]
	public void ResetConversation()
	{
	}

	[Token(Token = "0x600317E")]
	[Address(RVA = "0x16A8018", Offset = "0x16A8018", VA = "0x16A8018")]
	public void Interrupt()
	{
	}

	[Token(Token = "0x600317F")]
	[Address(RVA = "0x16A8024", Offset = "0x16A8024", VA = "0x16A8024")]
	public void ForceStartSpeechBubble()
	{
	}

	[Token(Token = "0x6003180")]
	[Address(RVA = "0x16A7F30", Offset = "0x16A7F30", VA = "0x16A7F30")]
	public IEnumerator HandleHit([Optional] Action onDone, [Optional] Action onTextShown, [Optional] Func<string, string> OnPreprocessText)
	{
		return null;
	}

	[Token(Token = "0x6003181")]
	[Address(RVA = "0x16A80A4", Offset = "0x16A80A4", VA = "0x16A80A4")]
	public void SetState(bool state)
	{
	}

	[Token(Token = "0x6003182")]
	[Address(RVA = "0x16A80AC", Offset = "0x16A80AC", VA = "0x16A80AC")]
	private void PoolSpeechBubble()
	{
	}

	[Token(Token = "0x6003183")]
	[Address(RVA = "0x16A8100", Offset = "0x16A8100", VA = "0x16A8100")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6003184")]
	[Address(RVA = "0x16A81E8", Offset = "0x16A81E8", VA = "0x16A81E8")]
	public ShowSpeechbubbleOnHit_Quest()
	{
	}

	[Token(Token = "0x6003185")]
	[Address(RVA = "0x16A824C", Offset = "0x16A824C", VA = "0x16A824C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69A24", Offset = "0x69A24")]
	private void _003CListenForInterruption_003Eb__35_0()
	{
	}

	[Token(Token = "0x6003186")]
	[Address(RVA = "0x16A8258", Offset = "0x16A8258", VA = "0x16A8258")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69A34", Offset = "0x69A34")]
	private void _003CListenForInterruption_003Eb__35_2(List<LevelData> lvls)
	{
	}

	[Token(Token = "0x6003187")]
	[Address(RVA = "0x16A8264", Offset = "0x16A8264", VA = "0x16A8264")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69A44", Offset = "0x69A44")]
	private void _003CListenForInterruption_003Eb__35_1(bool active)
	{
	}
}
