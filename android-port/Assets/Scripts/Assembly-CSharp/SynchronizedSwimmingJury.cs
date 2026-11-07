using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000270")]
public class SynchronizedSwimmingJury : MonoBehaviour
{
	[Token(Token = "0x2000271")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E734", Offset = "0x3E734")]
	private sealed class _003CCalculateScores_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x20")]
		public SynchronizedSwimmingJury _003C_003E4__this;

		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x28")]
		private float _003CevaluationEndTime_003E5__2;

		[Token(Token = "0x4000CC3")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CevaluationStartTime_003E5__3;

		[Token(Token = "0x4000CC4")]
		[FieldOffset(Offset = "0x30")]
		private float _003CbestScore_003E5__4;

		[Token(Token = "0x17000154")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x18611F8", Offset = "0x18611F8", VA = "0x18611F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000155")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x1861240", Offset = "0x1861240", VA = "0x1861240", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x1860D44", Offset = "0x1860D44", VA = "0x1860D44")]
		[DebuggerHidden]
		public _003CCalculateScores_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x1860D70", Offset = "0x1860D70", VA = "0x1860D70", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x1860D74", Offset = "0x1860D74", VA = "0x1860D74", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x18611F8", Offset = "0x18611F8", VA = "0x18611F8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x1861200", Offset = "0x1861200", VA = "0x1861200", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x1861240", Offset = "0x1861240", VA = "0x1861240", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SynchronizedSwimmerAI ai;

	[Token(Token = "0x4000CAF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform aiReferencePoint;

	[Token(Token = "0x4000CB0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SwimmerShooter player;

	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform playerReferencePoint;

	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<TextMeshProUGUI> scoreRenderers;

	[Token(Token = "0x4000CB3")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<Animator> animators;

	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float initialWait;

	[Token(Token = "0x4000CB5")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float scoreEvaluationDuration;

	[Token(Token = "0x4000CB6")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<float> scores;

	[Token(Token = "0x4000CB7")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<bool> scoresUpdated;

	[Token(Token = "0x4000CB8")]
	[FieldOffset(Offset = "0x60")]
	private float startTime;

	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AnimationCurve timingScoreCurve;

	[Token(Token = "0x4000CBA")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float distanceScoreNormalizer;

	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private AnimationCurve distanceScoreCurve;

	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4AE54", Offset = "0x4AE54")]
	[SerializeField]
	private float scoreHistoryWeight;

	[Token(Token = "0x4000CBD")]
	[FieldOffset(Offset = "0x88")]
	private string animTriggerParamName;

	[Token(Token = "0x4000CBE")]
	[FieldOffset(Offset = "0x90")]
	private string changeScoreStateName;

	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x16F61A4", Offset = "0x16F61A4", VA = "0x16F61A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x16F62C8", Offset = "0x16F62C8", VA = "0x16F62C8")]
	private void AI_OnMoveTargetReached(SynchronizedSwimmerAI syncSwimmerAI)
	{
	}

	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x16F63B8", Offset = "0x16F63B8", VA = "0x16F63B8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x16F6344", Offset = "0x16F6344", VA = "0x16F6344")]
	private IEnumerator CalculateScores()
	{
		return null;
	}

	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x16F6664", Offset = "0x16F6664", VA = "0x16F6664")]
	private void ShowScoreUpdateAnimation(int juryMemberIndex)
	{
	}

	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x16F67E4", Offset = "0x16F67E4", VA = "0x16F67E4")]
	public void UpdateScoreRenderer(Animator juryMember)
	{
	}

	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x16F66E4", Offset = "0x16F66E4", VA = "0x16F66E4")]
	private void UpdateScoreRenderer(int juryMemberIndex)
	{
	}

	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x16F68DC", Offset = "0x16F68DC", VA = "0x16F68DC")]
	public SynchronizedSwimmingJury()
	{
	}
}
