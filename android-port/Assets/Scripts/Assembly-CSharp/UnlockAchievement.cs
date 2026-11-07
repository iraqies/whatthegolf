using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000B")]
public class UnlockAchievement : MonoBehaviour
{
	[Token(Token = "0x200000C")]
	public enum UnlockMethod
	{
		[Token(Token = "0x4000026")]
		None = 0,
		[Token(Token = "0x4000027")]
		Goal = 1,
		[Token(Token = "0x4000028")]
		Start = 2,
		[Token(Token = "0x4000029")]
		Trigger = 3,
		[Token(Token = "0x400002A")]
		Collision = 4,
		[Token(Token = "0x400002B")]
		Trigger2D = 5
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D188", Offset = "0x3D188")]
	private sealed class _003CStart_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x20")]
		public UnlockAchievement _003C_003E4__this;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x28")]
		private IPlatform _003Cplatform_003E5__2;

		[Token(Token = "0x1700000B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1872438", Offset = "0x1872438", VA = "0x1872438", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700000C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1872480", Offset = "0x1872480", VA = "0x1872480", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x18721E4", Offset = "0x18721E4", VA = "0x18721E4")]
		[DebuggerHidden]
		public _003CStart_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1872210", Offset = "0x1872210", VA = "0x1872210", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1872214", Offset = "0x1872214", VA = "0x1872214", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1872438", Offset = "0x1872438", VA = "0x1872438", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1872440", Offset = "0x1872440", VA = "0x1872440", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1872480", Offset = "0x1872480", VA = "0x1872480", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D198", Offset = "0x3D198")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x8")]
		public static Action<bool, float> _003C_003E9__20_0;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x18721D8", Offset = "0x18721D8", VA = "0x18721D8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x18721E0", Offset = "0x18721E0", VA = "0x18721E0")]
		internal void _003CSetProgress_003Eb__20_0(bool success, float pct)
		{
		}
	}

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x18")]
	public float progress;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AchievementData m_AchievementData;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnlockMethod m_UnlockMethod;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool m_IsUnlocked;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x30")]
	private GolfGoal m_Goal;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x38")]
	private float nextTryUnlockTime;

	[Token(Token = "0x17000007")]
	public bool IsUnlocked
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x173B6BC", Offset = "0x173B6BC", VA = "0x173B6BC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000008")]
	private bool hasValidId
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x173B6C4", Offset = "0x173B6C4", VA = "0x173B6C4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000009")]
	private string getPlatformId
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x173B6E4", Offset = "0x173B6E4", VA = "0x173B6E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	private string saveUnlockId
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x173B7A0", Offset = "0x173B7A0", VA = "0x173B7A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x173B804", Offset = "0x173B804", VA = "0x173B804")]
	public void Init()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x173B9D8", Offset = "0x173B9D8", VA = "0x173B9D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x173BAB0", Offset = "0x173BAB0", VA = "0x173BAB0")]
	public void SetData(AchievementData a)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x173BAB8", Offset = "0x173BAB8", VA = "0x173BAB8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x173BB2C", Offset = "0x173BB2C", VA = "0x173BB2C")]
	public void ManualUnlock()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x173BD44", Offset = "0x173BD44", VA = "0x173BD44")]
	public void SetProgress(float progress)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x173BF2C", Offset = "0x173BF2C", VA = "0x173BF2C")]
	private void OnGoal()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x173C02C", Offset = "0x173C02C", VA = "0x173C02C")]
	private void SetUnlocked()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x173BB30", Offset = "0x173BB30", VA = "0x173BB30")]
	private void UnlockAchivement_Internal()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x173C17C", Offset = "0x173C17C", VA = "0x173C17C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x173C234", Offset = "0x173C234", VA = "0x173C234")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x173C248", Offset = "0x173C248", VA = "0x173C248")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x173C25C", Offset = "0x173C25C", VA = "0x173C25C")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x173C270", Offset = "0x173C270", VA = "0x173C270")]
	public UnlockAchievement()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x173C278", Offset = "0x173C278", VA = "0x173C278")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D064", Offset = "0x5D064")]
	private void _003CUnlockAchivement_Internal_003Eb__23_0(bool success, float pct)
	{
	}
}
