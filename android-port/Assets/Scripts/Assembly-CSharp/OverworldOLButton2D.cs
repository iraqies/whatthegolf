using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Tilemaps;

[Token(Token = "0x2000289")]
public class OverworldOLButton2D : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200028A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E7D4", Offset = "0x3E7D4")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000D6A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000D6B")]
		[FieldOffset(Offset = "0x8")]
		public static Converter<OverworldGoal, Vector3> _003C_003E9__26_0;

		[Token(Token = "0x4000D6C")]
		[FieldOffset(Offset = "0x10")]
		public static Func<bool, bool> _003C_003E9__36_0;

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x181BA34", Offset = "0x181BA34", VA = "0x181BA34")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x181BA3C", Offset = "0x181BA3C", VA = "0x181BA3C")]
		internal Vector3 _003CFlagHintRoutine_003Eb__26_0(OverworldGoal goal)
		{
			return default;
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x181BA68", Offset = "0x181BA68", VA = "0x181BA68")]
		internal bool _003CUpdateStatus_003Eb__36_0(bool i)
		{
			return default;
		}
	}

	[Token(Token = "0x200028B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E7E4", Offset = "0x3E7E4")]
	private sealed class _003CFlagHintRoutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000D6D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000D6E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000D6F")]
		[FieldOffset(Offset = "0x20")]
		public OverworldOLButton2D _003C_003E4__this;

		[Token(Token = "0x17000163")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0x181BF84", Offset = "0x181BF84", VA = "0x181BF84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000164")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0x181BFCC", Offset = "0x181BFCC", VA = "0x181BFCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x181BC30", Offset = "0x181BC30", VA = "0x181BC30")]
		[DebuggerHidden]
		public _003CFlagHintRoutine_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x181BC5C", Offset = "0x181BC5C", VA = "0x181BC5C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x181BC60", Offset = "0x181BC60", VA = "0x181BC60", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x181BF84", Offset = "0x181BF84", VA = "0x181BF84", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x181BF8C", Offset = "0x181BF8C", VA = "0x181BF8C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x181BFCC", Offset = "0x181BFCC", VA = "0x181BFCC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200028C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E7F4", Offset = "0x3E7F4")]
	private sealed class _003CBlinkRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000D70")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000D71")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000D72")]
		[FieldOffset(Offset = "0x20")]
		public OverworldOLButton2D _003C_003E4__this;

		[Token(Token = "0x4000D73")]
		[FieldOffset(Offset = "0x28")]
		private WaitForSeconds _003Cwait_003E5__2;

		[Token(Token = "0x17000165")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0x181BBE0", Offset = "0x181BBE0", VA = "0x181BBE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000166")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x181BC28", Offset = "0x181BC28", VA = "0x181BC28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x181BA70", Offset = "0x181BA70", VA = "0x181BA70")]
		[DebuggerHidden]
		public _003CBlinkRoutine_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x181BA9C", Offset = "0x181BA9C", VA = "0x181BA9C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x181BAA0", Offset = "0x181BAA0", VA = "0x181BAA0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x181BBE0", Offset = "0x181BBE0", VA = "0x181BBE0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x181BBE8", Offset = "0x181BBE8", VA = "0x181BBE8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x181BC28", Offset = "0x181BC28", VA = "0x181BC28", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000D53")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<OverworldGoal> goals;

	[Token(Token = "0x4000D54")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private OverworldOLDoor goldDoor;

	[Token(Token = "0x4000D55")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OverworldOLDoor silverDoor;

	[Token(Token = "0x4000D56")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private OverworldOLDoor bronzeDoor;

	[Token(Token = "0x4000D57")]
	[FieldOffset(Offset = "0x38")]
	private List<OverworldOLDoor> doors;

	[Token(Token = "0x4000D58")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool canOpen;

	[Token(Token = "0x4000D59")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool useOpenIndicator;

	[Token(Token = "0x4000D5A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform openIndicator;

	[Token(Token = "0x4000D5B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float BallDistanceThreshold;

	[Token(Token = "0x4000D5C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform hintStartPosition;

	[Token(Token = "0x4000D5D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private int maxHintLinesToShow;

	[Token(Token = "0x4000D5E")]
	[FieldOffset(Offset = "0x64")]
	public float UnlockBlinkRate;

	[Token(Token = "0x4000D5F")]
	[FieldOffset(Offset = "0x68")]
	public Color[] OpenColors;

	[Token(Token = "0x4000D60")]
	[FieldOffset(Offset = "0x70")]
	public Color[] UnlockedColors;

	[Token(Token = "0x4000D61")]
	[FieldOffset(Offset = "0x78")]
	public Color[] LockedColors;

	[Token(Token = "0x4000D62")]
	[FieldOffset(Offset = "0x80")]
	public SpriteRenderer[] ButtonRenderers;

	[Token(Token = "0x4000D63")]
	[FieldOffset(Offset = "0x88")]
	public SpriteRenderer[] ButtonBackRenderers;

	[Token(Token = "0x4000D64")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private bool hideButton;

	[Token(Token = "0x4000D65")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject buttonContainer;

	[Token(Token = "0x4000D66")]
	[FieldOffset(Offset = "0xA0")]
	private Coroutine currentBlinkRoutine;

	[Token(Token = "0x4000D67")]
	[FieldOffset(Offset = "0xA8")]
	private int levelsCompletedForWorstGoal;

	[Token(Token = "0x4000D68")]
	[FieldOffset(Offset = "0xB0")]
	private List<bool> doorOpenOrOpening;

	[Token(Token = "0x4000D69")]
	[FieldOffset(Offset = "0xB8")]
	private bool isShowingHintLines;

	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x15C6564", Offset = "0x15C6564", VA = "0x15C6564", Slot = "4")]
	public virtual void Init(Tilemap tilemap, List<OverworldGoal> goals, OverworldCamera camera)
	{
	}

	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x15C6CE4", Offset = "0x15C6CE4", VA = "0x15C6CE4")]
	private void HandlePreviousOpened()
	{
	}

	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x15C6CE8", Offset = "0x15C6CE8", VA = "0x15C6CE8")]
	public void AfterInit()
	{
	}

	[Token(Token = "0x6000B86")]
	[Address(RVA = "0x15C6CF4", Offset = "0x15C6CF4", VA = "0x15C6CF4")]
	private IEnumerator FlagHintRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x15C6D68", Offset = "0x15C6D68", VA = "0x15C6D68")]
	private IEnumerator BlinkRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x15C6DDC", Offset = "0x15C6DDC", VA = "0x15C6DDC")]
	private void Goal_OnUpdateData(OverworldGoal obj)
	{
	}

	[Token(Token = "0x6000B89")]
	[Address(RVA = "0x15C6DE8", Offset = "0x15C6DE8", VA = "0x15C6DE8")]
	private bool IsBronzeCompleted()
	{
		return default;
	}

	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0x15C6E04", Offset = "0x15C6E04", VA = "0x15C6E04")]
	private bool IsSilverCompleted()
	{
		return default;
	}

	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0x15C6E20", Offset = "0x15C6E20", VA = "0x15C6E20")]
	private bool IsGoldCompleted()
	{
		return default;
	}

	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0x15C6E3C", Offset = "0x15C6E3C", VA = "0x15C6E3C")]
	private int GetLevelsCompleted(OverworldGoal goal)
	{
		return default;
	}

	[Token(Token = "0x6000B8D")]
	[Address(RVA = "0x15C6900", Offset = "0x15C6900", VA = "0x15C6900")]
	private int GetLevelsCompletedForWorstGoal()
	{
		return default;
	}

	[Token(Token = "0x6000B8E")]
	[Address(RVA = "0x15C6AFC", Offset = "0x15C6AFC", VA = "0x15C6AFC")]
	public void SetOpenIndicator(bool open, bool setRotation = false)
	{
	}

	[Token(Token = "0x6000B8F")]
	[Address(RVA = "0x15C6FD8", Offset = "0x15C6FD8", VA = "0x15C6FD8")]
	public void ToggleBlinkRoutine(bool turnOn)
	{
	}

	[Token(Token = "0x6000B90")]
	[Address(RVA = "0x15C70A0", Offset = "0x15C70A0", VA = "0x15C70A0", Slot = "5")]
	public virtual void UpdateStatus()
	{
	}

	[Token(Token = "0x6000B91")]
	[Address(RVA = "0x15C7450", Offset = "0x15C7450", VA = "0x15C7450")]
	public void CheckOpen()
	{
	}

	[Token(Token = "0x6000B92")]
	[Address(RVA = "0x15C7804", Offset = "0x15C7804", VA = "0x15C7804")]
	private void ShowHints()
	{
	}

	[Token(Token = "0x6000B93")]
	[Address(RVA = "0x15C75CC", Offset = "0x15C75CC", VA = "0x15C75CC")]
	private bool CheckOpen(OverworldOLDoor relevantDoor)
	{
		return default;
	}

	[Token(Token = "0x6000B94")]
	[Address(RVA = "0x15C738C", Offset = "0x15C738C", VA = "0x15C738C")]
	private void SetButtonColors(Color[] colors)
	{
	}

	[Token(Token = "0x6000B95")]
	[Address(RVA = "0x15C7898", Offset = "0x15C7898", VA = "0x15C7898")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6000B96")]
	[Address(RVA = "0x15C7AD4", Offset = "0x15C7AD4", VA = "0x15C7AD4")]
	public OverworldOLButton2D()
	{
	}
}
