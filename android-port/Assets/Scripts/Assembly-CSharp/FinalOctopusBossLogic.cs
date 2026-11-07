using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E14")]
public class FinalOctopusBossLogic : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000E15")]
	public class DestructiblePart
	{
		[Token(Token = "0x4004C88")]
		[FieldOffset(Offset = "0x10")]
		public GameObject tail;

		[Token(Token = "0x4004C89")]
		[FieldOffset(Offset = "0x18")]
		public GameObject catMesh;

		[Token(Token = "0x6004229")]
		[Address(RVA = "0x17A6750", Offset = "0x17A6750", VA = "0x17A6750")]
		public DestructiblePart()
		{
		}
	}

	[Token(Token = "0x2000E16")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44E58", Offset = "0x44E58")]
	private sealed class _003CHurtEffect_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004C8A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004C8B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004C8C")]
		[FieldOffset(Offset = "0x20")]
		public FinalOctopusBossLogic _003C_003E4__this;

		[Token(Token = "0x170006CA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600422D")]
			[Address(RVA = "0x17A6700", Offset = "0x17A6700", VA = "0x17A6700", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006CB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600422F")]
			[Address(RVA = "0x17A6748", Offset = "0x17A6748", VA = "0x17A6748", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600422A")]
		[Address(RVA = "0x17A65B4", Offset = "0x17A65B4", VA = "0x17A65B4")]
		[DebuggerHidden]
		public _003CHurtEffect_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600422B")]
		[Address(RVA = "0x17A65E0", Offset = "0x17A65E0", VA = "0x17A65E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600422C")]
		[Address(RVA = "0x17A65E4", Offset = "0x17A65E4", VA = "0x17A65E4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600422D")]
		[Address(RVA = "0x17A6700", Offset = "0x17A6700", VA = "0x17A6700", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600422E")]
		[Address(RVA = "0x17A6708", Offset = "0x17A6708", VA = "0x17A6708", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600422F")]
		[Address(RVA = "0x17A6748", Offset = "0x17A6748", VA = "0x17A6748", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004C81")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnLastLegDestroyed;

	[Token(Token = "0x4004C82")]
	[FieldOffset(Offset = "0x20")]
	public List<DestructiblePart> legsToDestroy;

	[Token(Token = "0x4004C83")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer squidRenderer;

	[Token(Token = "0x4004C84")]
	[FieldOffset(Offset = "0x30")]
	public List<SkinnedMeshRenderer> skinnedMeshRendererList;

	[Token(Token = "0x4004C85")]
	[FieldOffset(Offset = "0x38")]
	public List<Material> squidMaterials;

	[Token(Token = "0x4004C86")]
	[FieldOffset(Offset = "0x40")]
	private int m_hitsCount;

	[Token(Token = "0x4004C87")]
	[FieldOffset(Offset = "0x48")]
	private Coroutine hurtRoutine;

	[Token(Token = "0x6004225")]
	[Address(RVA = "0x14654A0", Offset = "0x14654A0", VA = "0x14654A0")]
	public void DestroyLeg()
	{
	}

	[Token(Token = "0x6004226")]
	[Address(RVA = "0x14655EC", Offset = "0x14655EC", VA = "0x14655EC")]
	private IEnumerator HurtEffect()
	{
		return null;
	}

	[Token(Token = "0x6004227")]
	[Address(RVA = "0x1465660", Offset = "0x1465660", VA = "0x1465660")]
	private void ChangeMaterialLoop(Material newMat)
	{
	}

	[Token(Token = "0x6004228")]
	[Address(RVA = "0x14657D0", Offset = "0x14657D0", VA = "0x14657D0")]
	public FinalOctopusBossLogic()
	{
	}
}
