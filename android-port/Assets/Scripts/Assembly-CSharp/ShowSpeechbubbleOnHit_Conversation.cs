using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A59")]
public class ShowSpeechbubbleOnHit_Conversation : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A5A")]
	public class Participant
	{
		[Token(Token = "0x400395C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400395D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform transform;

		[Token(Token = "0x400395E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animator animator;

		[Token(Token = "0x400395F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<AudioClip> OnHitClip;

		[Token(Token = "0x4003960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 bubbleDir;

		[Token(Token = "0x4003961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2 bubbleOffset;

		[Token(Token = "0x600316A")]
		[Address(RVA = "0x184BD8C", Offset = "0x184BD8C", VA = "0x184BD8C")]
		public Participant()
		{
		}
	}

	[Token(Token = "0x2000A5B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42CB0", Offset = "0x42CB0")]
	private sealed class _003CHandleHit_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShowSpeechbubbleOnHit_Conversation _003C_003E4__this;

		[Token(Token = "0x4003965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Func<string, string> OnPreprocessText;

		[Token(Token = "0x4003966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onTextShown;

		[Token(Token = "0x4003967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onDone;

		[Token(Token = "0x4003968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpeechBubbleUI.Task _003CshowTask_003E5__2;

		[Token(Token = "0x1700051B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600316E")]
			[Address(RVA = "0x184BB8C", Offset = "0x184BB8C", VA = "0x184BB8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700051C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003170")]
			[Address(RVA = "0x184BBD4", Offset = "0x184BBD4", VA = "0x184BBD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600316B")]
		[Address(RVA = "0x184B348", Offset = "0x184B348", VA = "0x184B348")]
		[DebuggerHidden]
		public _003CHandleHit_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600316C")]
		[Address(RVA = "0x184B374", Offset = "0x184B374", VA = "0x184B374", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600316D")]
		[Address(RVA = "0x184B378", Offset = "0x184B378", VA = "0x184B378", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600316E")]
		[Address(RVA = "0x184BB8C", Offset = "0x184BB8C", VA = "0x184BB8C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600316F")]
		[Address(RVA = "0x184BB94", Offset = "0x184BB94", VA = "0x184BB94", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003170")]
		[Address(RVA = "0x184BBD4", Offset = "0x184BBD4", VA = "0x184BBD4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42CC0", Offset = "0x42CC0")]
	private sealed class _003CStopTalkingAnimation_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400396A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400396B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShowSpeechbubbleOnHit_Conversation _003C_003E4__this;

		[Token(Token = "0x1700051D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003174")]
			[Address(RVA = "0x184BD3C", Offset = "0x184BD3C", VA = "0x184BD3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700051E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003176")]
			[Address(RVA = "0x184BD84", Offset = "0x184BD84", VA = "0x184BD84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003171")]
		[Address(RVA = "0x184BBDC", Offset = "0x184BBDC", VA = "0x184BBDC")]
		[DebuggerHidden]
		public _003CStopTalkingAnimation_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003172")]
		[Address(RVA = "0x184BC08", Offset = "0x184BC08", VA = "0x184BC08", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003173")]
		[Address(RVA = "0x184BC0C", Offset = "0x184BC0C", VA = "0x184BC0C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003174")]
		[Address(RVA = "0x184BD3C", Offset = "0x184BD3C", VA = "0x184BD3C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003175")]
		[Address(RVA = "0x184BD44", Offset = "0x184BD44", VA = "0x184BD44", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003176")]
		[Address(RVA = "0x184BD84", Offset = "0x184BD84", VA = "0x184BD84", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject SpeechBubblePrefab;

	[Token(Token = "0x4003942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SpeechbubbleList TextList;

	[Token(Token = "0x4003943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float DelayBeforeStopTalkAnimation;

	[Token(Token = "0x4003944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<string> ActivatorTags;

	[Token(Token = "0x4003945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<AudioClip> OnHitClip;

	[Token(Token = "0x4003946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float delay;

	[Token(Token = "0x4003947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float bounceFactor;

	[Token(Token = "0x4003948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool hasPriority;

	[Token(Token = "0x4003949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool getCameraFocus;

	[Token(Token = "0x400394A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Participant> participants;

	[Token(Token = "0x400394B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> conversationLines;

	[Token(Token = "0x400394C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float bubbleRotation;

	[Token(Token = "0x400394D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool ignoreActivatorTags;

	[Token(Token = "0x400394E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool UseRestartTimeLimit;

	[Token(Token = "0x400394F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float ConversationRestartTimeLimit;

	[Token(Token = "0x4003950")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool isAbleToTalk;

	[Token(Token = "0x4003951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform speechBubblePreferredCenterTransform;

	[Token(Token = "0x4003952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public SpeechAudioBase speechAudio;

	[Token(Token = "0x4003953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private SpeechBubbleUI speechBubble;

	[Token(Token = "0x4003954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool isHandlingHit;

	[Token(Token = "0x4003955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool isInterrupted;

	[Token(Token = "0x4003956")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private IConversation conversation;

	[Token(Token = "0x4003957")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float lastConversationTime;

	[Token(Token = "0x4003958")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Participant currentParticipant;

	[Token(Token = "0x4003959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Animator m_anim;

	[Token(Token = "0x400395A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int m_conversationIndex;

	[Token(Token = "0x400395B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool m_isLooping;

	[Token(Token = "0x6003159")]
	[Address(RVA = "0x16A6B88", Offset = "0x16A6B88", VA = "0x16A6B88")]
	private void Awake()
	{
	}

	[Token(Token = "0x600315A")]
	[Address(RVA = "0x16A6DFC", Offset = "0x16A6DFC", VA = "0x16A6DFC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600315B")]
	[Address(RVA = "0x16A6C38", Offset = "0x16A6C38", VA = "0x16A6C38")]
	private void ListenForInterruption()
	{
	}

	[Token(Token = "0x600315C")]
	[Address(RVA = "0x16A6F14", Offset = "0x16A6F14", VA = "0x16A6F14")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x600315D")]
	[Address(RVA = "0x16A70A8", Offset = "0x16A70A8", VA = "0x16A70A8")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x600315E")]
	[Address(RVA = "0x16A73CC", Offset = "0x16A73CC", VA = "0x16A73CC")]
	public void ResetConversation()
	{
	}

	[Token(Token = "0x600315F")]
	[Address(RVA = "0x16A740C", Offset = "0x16A740C", VA = "0x16A740C")]
	public void Interrupt()
	{
	}

	[Token(Token = "0x6003160")]
	[Address(RVA = "0x16A7418", Offset = "0x16A7418", VA = "0x16A7418")]
	public void ForceStartSpeechBubble()
	{
	}

	[Token(Token = "0x6003161")]
	[Address(RVA = "0x16A701C", Offset = "0x16A701C", VA = "0x16A701C")]
	public IEnumerator HandleHit([Optional] Action onDone, [Optional] Action onTextShown, [Optional] Func<string, string> OnPreprocessText)
	{
		return null;
	}

	[Token(Token = "0x6003162")]
	[Address(RVA = "0x16A7498", Offset = "0x16A7498", VA = "0x16A7498")]
	private IEnumerator StopTalkingAnimation()
	{
		return null;
	}

	[Token(Token = "0x6003163")]
	[Address(RVA = "0x16A750C", Offset = "0x16A750C", VA = "0x16A750C")]
	public void SetState(bool state)
	{
	}

	[Token(Token = "0x6003164")]
	[Address(RVA = "0x16A7514", Offset = "0x16A7514", VA = "0x16A7514")]
	private void PoolSpeechBubble()
	{
	}

	[Token(Token = "0x6003165")]
	[Address(RVA = "0x16A7568", Offset = "0x16A7568", VA = "0x16A7568")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6003166")]
	[Address(RVA = "0x16A7584", Offset = "0x16A7584", VA = "0x16A7584")]
	public ShowSpeechbubbleOnHit_Conversation()
	{
	}

	[Token(Token = "0x6003167")]
	[Address(RVA = "0x16A7678", Offset = "0x16A7678", VA = "0x16A7678")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69954", Offset = "0x69954")]
	private void _003CListenForInterruption_003Eb__30_0()
	{
	}

	[Token(Token = "0x6003168")]
	[Address(RVA = "0x16A7684", Offset = "0x16A7684", VA = "0x16A7684")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69964", Offset = "0x69964")]
	private void _003CListenForInterruption_003Eb__30_2(List<LevelData> lvls)
	{
	}

	[Token(Token = "0x6003169")]
	[Address(RVA = "0x16A7690", Offset = "0x16A7690", VA = "0x16A7690")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69974", Offset = "0x69974")]
	private void _003CListenForInterruption_003Eb__30_1(bool active)
	{
	}
}
