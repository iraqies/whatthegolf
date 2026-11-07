using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A03")]
public class OverworldGoal : MonoBehaviour
{
	[Token(Token = "0x2000A04")]
	public enum States
	{
		[Token(Token = "0x400375B")]
		Hidden = 0,
		[Token(Token = "0x400375C")]
		Unplayed = 1,
		[Token(Token = "0x400375D")]
		Won = 2,
		[Token(Token = "0x400375E")]
		Crown = 3
	}

	[Token(Token = "0x2000A05")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x428F8", Offset = "0x428F8")]
	private sealed class _003CUpdatePlayerTracking_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400375F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003760")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003761")]
		[FieldOffset(Offset = "0x20")]
		public bool force;

		[Token(Token = "0x4003762")]
		[FieldOffset(Offset = "0x28")]
		public OverworldGoal _003C_003E4__this;

		[Token(Token = "0x170004E1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F92")]
			[Address(RVA = "0x1811414", Offset = "0x1811414", VA = "0x1811414", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004E2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F94")]
			[Address(RVA = "0x181145C", Offset = "0x181145C", VA = "0x181145C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0x181121C", Offset = "0x181121C", VA = "0x181121C")]
		[DebuggerHidden]
		public _003CUpdatePlayerTracking_003Ed__45(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F90")]
		[Address(RVA = "0x1811248", Offset = "0x1811248", VA = "0x1811248", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F91")]
		[Address(RVA = "0x181124C", Offset = "0x181124C", VA = "0x181124C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002F92")]
		[Address(RVA = "0x1811414", Offset = "0x1811414", VA = "0x1811414", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002F93")]
		[Address(RVA = "0x181141C", Offset = "0x181141C", VA = "0x181141C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002F94")]
		[Address(RVA = "0x181145C", Offset = "0x181145C", VA = "0x181145C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A06")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42908", Offset = "0x42908")]
	private sealed class _003COneFrameDelayedSetStatus_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003763")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003764")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003765")]
		[FieldOffset(Offset = "0x20")]
		public OverworldGoal _003C_003E4__this;

		[Token(Token = "0x170004E3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F98")]
			[Address(RVA = "0x18111CC", Offset = "0x18111CC", VA = "0x18111CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004E4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F9A")]
			[Address(RVA = "0x1811214", Offset = "0x1811214", VA = "0x1811214", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002F95")]
		[Address(RVA = "0x1811130", Offset = "0x1811130", VA = "0x1811130")]
		[DebuggerHidden]
		public _003COneFrameDelayedSetStatus_003Ed__48(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F96")]
		[Address(RVA = "0x181115C", Offset = "0x181115C", VA = "0x181115C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F97")]
		[Address(RVA = "0x1811160", Offset = "0x1811160", VA = "0x1811160", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002F98")]
		[Address(RVA = "0x18111CC", Offset = "0x18111CC", VA = "0x18111CC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002F99")]
		[Address(RVA = "0x18111D4", Offset = "0x18111D4", VA = "0x18111D4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002F9A")]
		[Address(RVA = "0x1811214", Offset = "0x1811214", VA = "0x1811214", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000A07")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42918", Offset = "0x42918")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003766")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003767")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LevelData, bool> _003C_003E9__53_0;

		[Token(Token = "0x4003768")]
		[FieldOffset(Offset = "0x10")]
		public static Func<LevelData, bool> _003C_003E9__55_0;

		[Token(Token = "0x4003769")]
		[FieldOffset(Offset = "0x18")]
		public static Func<LevelData.LevelCollectable, bool> _003C_003E9__60_1;

		[Token(Token = "0x400376A")]
		[FieldOffset(Offset = "0x20")]
		public static Func<LevelData, bool> _003C_003E9__60_0;

		[Token(Token = "0x6002F9C")]
		[Address(RVA = "0x1810E24", Offset = "0x1810E24", VA = "0x1810E24")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002F9D")]
		[Address(RVA = "0x1810E2C", Offset = "0x1810E2C", VA = "0x1810E2C")]
		internal bool _003CHasChallenges_003Eb__53_0(LevelData g)
		{
			return default;
		}

		[Token(Token = "0x6002F9E")]
		[Address(RVA = "0x1810E84", Offset = "0x1810E84", VA = "0x1810E84")]
		internal bool _003CIsFullyCompleted_003Eb__55_0(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x6002F9F")]
		[Address(RVA = "0x1810EA0", Offset = "0x1810EA0", VA = "0x1810EA0")]
		internal bool _003CRefreshState_003Eb__60_0(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x6002FA0")]
		[Address(RVA = "0x1810FDC", Offset = "0x1810FDC", VA = "0x1810FDC")]
		internal bool _003CRefreshState_003Eb__60_1(LevelData.LevelCollectable c)
		{
			return default;
		}
	}

	[Token(Token = "0x2000A08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42928", Offset = "0x42928")]
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		[Token(Token = "0x400376B")]
		[FieldOffset(Offset = "0x10")]
		public LevelData.LevelCollectable c;

		[Token(Token = "0x6002FA1")]
		[Address(RVA = "0x1811100", Offset = "0x1811100", VA = "0x1811100")]
		public _003C_003Ec__DisplayClass60_0()
		{
		}

		[Token(Token = "0x6002FA2")]
		[Address(RVA = "0x1811108", Offset = "0x1811108", VA = "0x1811108")]
		internal bool _003CRefreshState_003Eb__2(string id)
		{
			return default;
		}
	}

	[Token(Token = "0x4003738")]
	[FieldOffset(Offset = "0x18")]
	public bool isSkipping;

	[Token(Token = "0x4003739")]
	[FieldOffset(Offset = "0x20")]
	public string description;

	[Token(Token = "0x400373A")]
	[FieldOffset(Offset = "0x28")]
	public LevelData levelData;

	[Token(Token = "0x400373B")]
	[FieldOffset(Offset = "0x30")]
	public List<LevelData> AdditionalLevelData;

	[Token(Token = "0x400373C")]
	[FieldOffset(Offset = "0x38")]
	public List<LevelData> ExcludeFromSequence;

	[Token(Token = "0x400373D")]
	[FieldOffset(Offset = "0x40")]
	public States state;

	[Token(Token = "0x400373E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject visualNotCompleted;

	[Token(Token = "0x400373F")]
	[FieldOffset(Offset = "0x50")]
	public GameObject visualWon;

	[Token(Token = "0x4003740")]
	[FieldOffset(Offset = "0x58")]
	public GameObject visualCrown;

	[Token(Token = "0x4003741")]
	[FieldOffset(Offset = "0x60")]
	public GameObject visualCrownOutline;

	[Token(Token = "0x4003742")]
	[FieldOffset(Offset = "0x68")]
	public GameObject visualPole;

	[Token(Token = "0x4003743")]
	[FieldOffset(Offset = "0x70")]
	public GameObject visualHole;

	[Token(Token = "0x4003744")]
	[FieldOffset(Offset = "0x78")]
	public GameObject activeAnimation;

	[Token(Token = "0x4003745")]
	[FieldOffset(Offset = "0x80")]
	public bool DontRotateBasedOnLevel;

	[Token(Token = "0x4003746")]
	[FieldOffset(Offset = "0x81")]
	public bool IsStuckToWall;

	[Token(Token = "0x4003747")]
	[FieldOffset(Offset = "0x82")]
	public bool dontSnapToGrid;

	[Token(Token = "0x4003748")]
	[FieldOffset(Offset = "0x88")]
	public OverworldGoal requireGoalToUnlock;

	[Token(Token = "0x4003749")]
	[FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50194", Offset = "0x50194")]
	private Action<OverworldGoal> m_OnUpdateData;

	[Token(Token = "0x400374A")]
	[FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x501A4", Offset = "0x501A4")]
	private Action<OverworldGoal, Vector3, OverworldBall2D> m_OnHit;

	[Token(Token = "0x400374B")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x501B4", Offset = "0x501B4")]
	private Action<OverworldGoal> m_OnCrownWon;

	[Token(Token = "0x400374C")]
	[FieldOffset(Offset = "0xA8")]
	public bool MoveBallWhenHit;

	[Token(Token = "0x400374D")]
	[FieldOffset(Offset = "0xB0")]
	public Action<OverworldGoal> PlayerOutOfRangeAgain;

	[Token(Token = "0x400374E")]
	[FieldOffset(Offset = "0xB8")]
	public bool DontShowActiveCircle;

	[Token(Token = "0x400374F")]
	[FieldOffset(Offset = "0xB9")]
	public bool isDuplicate;

	[Token(Token = "0x4003750")]
	[FieldOffset(Offset = "0xC0")]
	public OverworldGoal duplicateReference;

	[Token(Token = "0x4003751")]
	[FieldOffset(Offset = "0xC8")]
	private Collider2D circleCollider;

	[Token(Token = "0x4003752")]
	[FieldOffset(Offset = "0xD0")]
	private Collider2D boxCollider;

	[Token(Token = "0x4003753")]
	[FieldOffset(Offset = "0xD8")]
	private bool canShowIndicator;

	[Token(Token = "0x4003754")]
	[FieldOffset(Offset = "0xD9")]
	private bool hasUnfinishedContent;

	[Token(Token = "0x4003755")]
	[FieldOffset(Offset = "0xE0")]
	private Transform playerTransform;

	[Token(Token = "0x4003756")]
	[FieldOffset(Offset = "0xE8")]
	private float playerSize;

	[Token(Token = "0x4003757")]
	[FieldOffset(Offset = "0xEC")]
	private bool trackPlayerDistance;

	[Token(Token = "0x4003758")]
	[FieldOffset(Offset = "0xF0")]
	private Transmogrif.BALLSHAPES currentBallShape;

	[Token(Token = "0x4003759")]
	[FieldOffset(Offset = "0xF8")]
	private HubSection parentHubSection;

	[Token(Token = "0x170004DF")]
	public HubSection ParentHubSection
	{
		[Token(Token = "0x6002F76")]
		[Address(RVA = "0x15B7A54", Offset = "0x15B7A54", VA = "0x15B7A54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E0")]
	public bool CanShowIndicator
	{
		[Token(Token = "0x6002F8A")]
		[Address(RVA = "0x15B8B88", Offset = "0x15B8B88", VA = "0x15B8B88")]
		set
		{
		}
	}

	[Token(Token = "0x1400005C")]
	public event Action<OverworldGoal> OnUpdateData
	{
		[Token(Token = "0x6002F70")]
		[Address(RVA = "0x15A9854", Offset = "0x15A9854", VA = "0x15A9854")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68EA8", Offset = "0x68EA8")]
		add
		{
		}
		[Token(Token = "0x6002F71")]
		[Address(RVA = "0x15B7720", Offset = "0x15B7720", VA = "0x15B7720")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68EB8", Offset = "0x68EB8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400005D")]
	public event Action<OverworldGoal, Vector3, OverworldBall2D> OnHit
	{
		[Token(Token = "0x6002F72")]
		[Address(RVA = "0x15B77C4", Offset = "0x15B77C4", VA = "0x15B77C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68EC8", Offset = "0x68EC8")]
		add
		{
		}
		[Token(Token = "0x6002F73")]
		[Address(RVA = "0x15B7868", Offset = "0x15B7868", VA = "0x15B7868")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68ED8", Offset = "0x68ED8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400005E")]
	public event Action<OverworldGoal> OnCrownWon
	{
		[Token(Token = "0x6002F74")]
		[Address(RVA = "0x15B790C", Offset = "0x15B790C", VA = "0x15B790C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68EE8", Offset = "0x68EE8")]
		add
		{
		}
		[Token(Token = "0x6002F75")]
		[Address(RVA = "0x15B79B0", Offset = "0x15B79B0", VA = "0x15B79B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68EF8", Offset = "0x68EF8")]
		remove
		{
		}
	}

	[Token(Token = "0x6002F77")]
	[Address(RVA = "0x15B7B00", Offset = "0x15B7B00", VA = "0x15B7B00")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002F78")]
	[Address(RVA = "0x15B7B3C", Offset = "0x15B7B3C", VA = "0x15B7B3C")]
	public void Init(GridFiller filler)
	{
	}

	[Token(Token = "0x6002F79")]
	[Address(RVA = "0x15B8658", Offset = "0x15B8658", VA = "0x15B8658")]
	public IEnumerator UpdatePlayerTracking(bool force = false)
	{
		return null;
	}

	[Token(Token = "0x6002F7A")]
	[Address(RVA = "0x15B86D4", Offset = "0x15B86D4", VA = "0x15B86D4")]
	private void PlayerOutOfRange()
	{
	}

	[Token(Token = "0x6002F7B")]
	[Address(RVA = "0x15B876C", Offset = "0x15B876C", VA = "0x15B876C")]
	public void SetNewBallShape(Transmogrif.BALLSHAPES newShape)
	{
	}

	[Token(Token = "0x6002F7C")]
	[Address(RVA = "0x15B85E4", Offset = "0x15B85E4", VA = "0x15B85E4")]
	private IEnumerator OneFrameDelayedSetStatus()
	{
		return null;
	}

	[Token(Token = "0x6002F7D")]
	[Address(RVA = "0x15B87F4", Offset = "0x15B87F4", VA = "0x15B87F4")]
	public bool IsUnlocked()
	{
		return default;
	}

	[Token(Token = "0x6002F7E")]
	[Address(RVA = "0x15AA570", Offset = "0x15AA570", VA = "0x15AA570")]
	public bool IsCompleted()
	{
		return default;
	}

	[Token(Token = "0x6002F7F")]
	[Address(RVA = "0x15B88B8", Offset = "0x15B88B8", VA = "0x15B88B8")]
	public bool IsRotated2D()
	{
		return default;
	}

	[Token(Token = "0x6002F80")]
	[Address(RVA = "0x15ACCF4", Offset = "0x15ACCF4", VA = "0x15ACCF4")]
	public List<LevelData> GetAllGoalLevels()
	{
		return null;
	}

	[Token(Token = "0x6002F81")]
	[Address(RVA = "0x15B8944", Offset = "0x15B8944", VA = "0x15B8944")]
	public bool HasChallenges()
	{
		return default;
	}

	[Token(Token = "0x6002F82")]
	[Address(RVA = "0x15ACC50", Offset = "0x15ACC50", VA = "0x15ACC50")]
	public bool IsVisible()
	{
		return default;
	}

	[Token(Token = "0x6002F83")]
	[Address(RVA = "0x15AA618", Offset = "0x15AA618", VA = "0x15AA618")]
	public bool IsFullyCompleted()
	{
		return default;
	}

	[Token(Token = "0x6002F84")]
	[Address(RVA = "0x15B8A94", Offset = "0x15B8A94", VA = "0x15B8A94")]
	public void ForceShowCrownOutline()
	{
	}

	[Token(Token = "0x6002F85")]
	[Address(RVA = "0x15B8AD8", Offset = "0x15B8AD8", VA = "0x15B8AD8")]
	public void ForceShowCrown()
	{
	}

	[Token(Token = "0x6002F86")]
	[Address(RVA = "0x15B8B64", Offset = "0x15B8B64", VA = "0x15B8B64")]
	private void RefreshFlag(OverworldGoal other)
	{
	}

	[Token(Token = "0x6002F87")]
	[Address(RVA = "0x15B87D0", Offset = "0x15B87D0", VA = "0x15B87D0")]
	private void RefreshFlag()
	{
	}

	[Token(Token = "0x6002F88")]
	[Address(RVA = "0x15B83EC", Offset = "0x15B83EC", VA = "0x15B83EC")]
	private void RefreshState()
	{
	}

	[Token(Token = "0x6002F89")]
	[Address(RVA = "0x15AAF88", Offset = "0x15AAF88", VA = "0x15AAF88")]
	public void RefreshVisuals()
	{
	}

	[Token(Token = "0x6002F8B")]
	[Address(RVA = "0x15B8B90", Offset = "0x15B8B90", VA = "0x15B8B90")]
	public void ReloadData()
	{
	}

	[Token(Token = "0x6002F8C")]
	[Address(RVA = "0x15B8C58", Offset = "0x15B8C58", VA = "0x15B8C58", Slot = "4")]
	public virtual void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002F8D")]
	[Address(RVA = "0x15B8F00", Offset = "0x15B8F00", VA = "0x15B8F00")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002F8E")]
	[Address(RVA = "0x15B9014", Offset = "0x15B9014", VA = "0x15B9014")]
	public OverworldGoal()
	{
	}
}
