using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Token(Token = "0x200017C")]
public class MainCampaignStartManager : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200017D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DDD0", Offset = "0x3DDD0")]
	private struct _003CStartPack_003Ed__22 : IAsyncStateMachine
	{
		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MainCampaignStartManager _003C_003E4__this;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x17F1090", Offset = "0x17F1090", VA = "0x17F1090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x17F147C", Offset = "0x17F147C", VA = "0x17F147C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200017E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DDE0", Offset = "0x3DDE0")]
	private struct _003CExit_003Ed__23 : IAsyncStateMachine
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MainCampaignStartManager _003C_003E4__this;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x17F0B5C", Offset = "0x17F0B5C", VA = "0x17F0B5C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x17F0D28", Offset = "0x17F0D28", VA = "0x17F0D28", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DDF0", Offset = "0x3DDF0")]
	private struct _003CPushAway_003Ed__24 : IAsyncStateMachine
	{
		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainCampaignStartManager _003C_003E4__this;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody2D _003Crigid_003E5__2;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _003Ctime_003E5__3;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object _003C_003Eu__1;

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x17F0D34", Offset = "0x17F0D34", VA = "0x17F0D34", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x17F1084", Offset = "0x17F1084", VA = "0x17F1084", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UserCriteria indicatorCriteria;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject indicator;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _newBanner;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _completeBanner;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _nameBanner;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject _progressBanner;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private TMP_Text _progressText;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image _progressImg;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private TextMeshProLocalized _campaignNameText;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isNew;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool packHasBeenEntered;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private string pack;

	[NonSerialized]
	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ContentPackDef packDef;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private UnityAction<ContentPackDef> _startAction;

	[Token(Token = "0x170000D7")]
	public ContentPackDef PackDef
	{
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1555134", Offset = "0x1555134", VA = "0x1555134")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D8")]
	public string adventureTitleID
	{
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x155542C", Offset = "0x155542C", VA = "0x155542C")]
		set
		{
		}
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x1555174", Offset = "0x1555174", VA = "0x1555174")]
	public void Start()
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x1555498", Offset = "0x1555498", VA = "0x1555498")]
	public void UpdateProgress()
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x1555838", Offset = "0x1555838", VA = "0x1555838")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x1555608", Offset = "0x1555608", VA = "0x1555608")]
	private void SetProgressText(float value)
	{
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x1555840", Offset = "0x1555840", VA = "0x1555840")]
	public void StartPack()
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x15558D8", Offset = "0x15558D8", VA = "0x15558D8")]
	private void Exit()
	{
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x1555970", Offset = "0x1555970", VA = "0x1555970")]
	private Task PushAway()
	{
		return null;
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x1555A4C", Offset = "0x1555A4C", VA = "0x1555A4C")]
	public MainCampaignStartManager()
	{
	}
}
