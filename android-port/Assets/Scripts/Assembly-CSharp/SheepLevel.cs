using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006CB")]
public class SheepLevel : MonoBehaviour
{
	[Token(Token = "0x20006CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41110", Offset = "0x41110")]
	private sealed class _003CResetSheep_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400239B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400239C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400239D")]
		[FieldOffset(Offset = "0x20")]
		public SheepLevel _003C_003E4__this;

		[Token(Token = "0x1700039F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F66")]
			[Address(RVA = "0x1848FE4", Offset = "0x1848FE4", VA = "0x1848FE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003A0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001F68")]
			[Address(RVA = "0x184902C", Offset = "0x184902C", VA = "0x184902C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001F63")]
		[Address(RVA = "0x1848E34", Offset = "0x1848E34", VA = "0x1848E34")]
		[DebuggerHidden]
		public _003CResetSheep_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x1848E60", Offset = "0x1848E60", VA = "0x1848E60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x1848E64", Offset = "0x1848E64", VA = "0x1848E64", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x1848FE4", Offset = "0x1848FE4", VA = "0x1848FE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x1848FEC", Offset = "0x1848FEC", VA = "0x1848FEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x184902C", Offset = "0x184902C", VA = "0x184902C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002393")]
	[FieldOffset(Offset = "0x18")]
	public int target;

	[Token(Token = "0x4002394")]
	[FieldOffset(Offset = "0x20")]
	public GolfGoal goal;

	[Token(Token = "0x4002395")]
	[FieldOffset(Offset = "0x28")]
	public Transform spawnTransform;

	[Token(Token = "0x4002396")]
	[FieldOffset(Offset = "0x30")]
	public RagdollReset sheep;

	[Token(Token = "0x4002397")]
	[FieldOffset(Offset = "0x38")]
	public Sheep sheepMovement;

	[Token(Token = "0x4002398")]
	[FieldOffset(Offset = "0x40")]
	public SkinnedMeshRenderer[] meshes;

	[Token(Token = "0x4002399")]
	[FieldOffset(Offset = "0x48")]
	private int progress;

	[Token(Token = "0x400239A")]
	[FieldOffset(Offset = "0x50")]
	private Coroutine coroutine;

	[Token(Token = "0x6001F5D")]
	[Address(RVA = "0x169ED84", Offset = "0x169ED84", VA = "0x169ED84")]
	public void OnSheepCounted()
	{
	}

	[Token(Token = "0x6001F5E")]
	[Address(RVA = "0x169EEBC", Offset = "0x169EEBC", VA = "0x169EEBC")]
	public void OnSheepOutOfBounds()
	{
	}

	[Token(Token = "0x6001F5F")]
	[Address(RVA = "0x169EF58", Offset = "0x169EF58", VA = "0x169EF58")]
	public void OnSheepNearFence()
	{
	}

	[Token(Token = "0x6001F60")]
	[Address(RVA = "0x169EF78", Offset = "0x169EF78", VA = "0x169EF78")]
	public void OnSheepPassedFence()
	{
	}

	[Token(Token = "0x6001F61")]
	[Address(RVA = "0x169EE48", Offset = "0x169EE48", VA = "0x169EE48")]
	private IEnumerator ResetSheep()
	{
		return null;
	}

	[Token(Token = "0x6001F62")]
	[Address(RVA = "0x169EF98", Offset = "0x169EF98", VA = "0x169EF98")]
	public SheepLevel()
	{
	}
}
