using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x2000B80")]
public class SaveThrobber : SingletonBehaviour<SaveThrobber>
{
	[Token(Token = "0x2000B81")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43A58", Offset = "0x43A58")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x400401F")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		[Token(Token = "0x6003788")]
		[Address(RVA = "0x183E364", Offset = "0x183E364", VA = "0x183E364")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6003789")]
		[Address(RVA = "0x183E36C", Offset = "0x183E36C", VA = "0x183E36C")]
		internal void _003CShowThrobber_003Eb__0()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000B82")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43A68", Offset = "0x43A68")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004020")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004021")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__15_0;

		[Token(Token = "0x600378B")]
		[Address(RVA = "0x183E308", Offset = "0x183E308", VA = "0x183E308")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600378C")]
		[Address(RVA = "0x183E310", Offset = "0x183E310", VA = "0x183E310")]
		internal void _003CHideThrobber_003Eb__15_0()
		{
		}
	}

	[Token(Token = "0x4004015")]
	public const float Rotationspeed = 7f;

	[Token(Token = "0x4004016")]
	public const float DoorDuration = 0.5f;

	[Token(Token = "0x4004017")]
	[FieldOffset(Offset = "0x18")]
	private Canvas _holderCanvas;

	[Token(Token = "0x4004018")]
	[FieldOffset(Offset = "0x20")]
	private Animator _animator;

	[Token(Token = "0x4004019")]
	[FieldOffset(Offset = "0x28")]
	private float _displayDuration;

	[Token(Token = "0x400401A")]
	[FieldOffset(Offset = "0x2C")]
	private float _timeLeft;

	[Token(Token = "0x400401B")]
	[FieldOffset(Offset = "0x30")]
	private bool _displaying;

	[Token(Token = "0x400401C")]
	[FieldOffset(Offset = "0x0")]
	private static bool _isLoading;

	[Token(Token = "0x400401D")]
	[FieldOffset(Offset = "0x8")]
	private static Action _callbacks;

	[Token(Token = "0x400401E")]
	[FieldOffset(Offset = "0x10")]
	private static Scene activeScene;

	[Token(Token = "0x600377B")]
	[Address(RVA = "0x1678BA8", Offset = "0x1678BA8", VA = "0x1678BA8", Slot = "4")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x600377C")]
	[Address(RVA = "0x1678CA8", Offset = "0x1678CA8", VA = "0x1678CA8")]
	private void Start()
	{
	}

	[Token(Token = "0x600377D")]
	[Address(RVA = "0x1678DD0", Offset = "0x1678DD0", VA = "0x1678DD0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600377E")]
	[Address(RVA = "0x1678DE0", Offset = "0x1678DE0", VA = "0x1678DE0")]
	private void Update()
	{
	}

	[Token(Token = "0x600377F")]
	[Address(RVA = "0x1678508", Offset = "0x1678508", VA = "0x1678508")]
	public static void ShowThrobber(float duration = 1f)
	{
	}

	[Token(Token = "0x6003780")]
	[Address(RVA = "0x1679318", Offset = "0x1679318", VA = "0x1679318")]
	public static void HideThrobber()
	{
	}

	[Token(Token = "0x6003781")]
	[Address(RVA = "0x167945C", Offset = "0x167945C", VA = "0x167945C")]
	public static void PreLoad()
	{
	}

	[Token(Token = "0x6003782")]
	[Address(RVA = "0x16790EC", Offset = "0x16790EC", VA = "0x16790EC")]
	private static void LoadAndInvoke(Action callback)
	{
	}

	[Token(Token = "0x6003783")]
	[Address(RVA = "0x1679460", Offset = "0x1679460", VA = "0x1679460")]
	private void ShowIt(float duration = 1f)
	{
	}

	[Token(Token = "0x6003784")]
	[Address(RVA = "0x1679488", Offset = "0x1679488", VA = "0x1679488")]
	private void Hide()
	{
	}

	[Token(Token = "0x6003785")]
	[Address(RVA = "0x1678E4C", Offset = "0x1678E4C", VA = "0x1678E4C")]
	private void SetObjectsActive(bool state)
	{
	}

	[Token(Token = "0x6003786")]
	[Address(RVA = "0x16794CC", Offset = "0x16794CC", VA = "0x16794CC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6AC84", Offset = "0x6AC84")]
	public void Show()
	{
	}

	[Token(Token = "0x6003787")]
	[Address(RVA = "0x16794D4", Offset = "0x16794D4", VA = "0x16794D4")]
	public SaveThrobber()
	{
	}
}
