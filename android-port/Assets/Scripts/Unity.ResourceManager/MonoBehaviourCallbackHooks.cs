using System;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000006")]
internal class MonoBehaviourCallbackHooks : ComponentSingleton<MonoBehaviourCallbackHooks>
{
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x18")]
	internal Action<float> m_OnUpdateDelegate;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x20")]
	internal Action<float> m_OnLateUpdateDelegate;

	[Token(Token = "0x14000003")]
	public event Action<float> OnUpdateDelegate
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2A6A5CC", Offset = "0x2A6A5CC", VA = "0x2A6A5CC")]
		add
		{
		}
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2A6A650", Offset = "0x2A6A650", VA = "0x2A6A650")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	internal event Action<float> OnLateUpdateDelegate
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2A6A6D4", Offset = "0x2A6A6D4", VA = "0x2A6A6D4")]
		add
		{
		}
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2A6A758", Offset = "0x2A6A758", VA = "0x2A6A758")]
		remove
		{
		}
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2A6A7DC", Offset = "0x2A6A7DC", VA = "0x2A6A7DC", Slot = "4")]
	protected override string GetGameObjectName()
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2A6A820", Offset = "0x2A6A820", VA = "0x2A6A820")]
	internal void Update()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2A6A888", Offset = "0x2A6A888", VA = "0x2A6A888")]
	internal void LateUpdate()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2A6A8F0", Offset = "0x2A6A8F0", VA = "0x2A6A8F0")]
	public MonoBehaviourCallbackHooks()
	{
	}
}
