using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E96")]
public class PopCornSpawner : MonoBehaviour
{
	[Token(Token = "0x2000E97")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45138", Offset = "0x45138")]
	private sealed class _003CSpawnCoroutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004ECD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004ECE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004ECF")]
		[FieldOffset(Offset = "0x20")]
		public PopCornSpawner _003C_003E4__this;

		[Token(Token = "0x4004ED0")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170006FA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600441C")]
			[Address(RVA = "0x182A624", Offset = "0x182A624", VA = "0x182A624", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006FB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600441E")]
			[Address(RVA = "0x182A66C", Offset = "0x182A66C", VA = "0x182A66C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004419")]
		[Address(RVA = "0x182A1F8", Offset = "0x182A1F8", VA = "0x182A1F8")]
		[DebuggerHidden]
		public _003CSpawnCoroutine_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600441A")]
		[Address(RVA = "0x182A224", Offset = "0x182A224", VA = "0x182A224", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600441B")]
		[Address(RVA = "0x182A228", Offset = "0x182A228", VA = "0x182A228", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600441C")]
		[Address(RVA = "0x182A624", Offset = "0x182A624", VA = "0x182A624", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600441D")]
		[Address(RVA = "0x182A62C", Offset = "0x182A62C", VA = "0x182A62C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600441E")]
		[Address(RVA = "0x182A66C", Offset = "0x182A66C", VA = "0x182A66C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004EC0")]
	[FieldOffset(Offset = "0x18")]
	public int collectedCorn;

	[Token(Token = "0x4004EC1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MultiplePlayerCameraFollow m_multiCameraFollow;

	[Token(Token = "0x4004EC2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform m_popCornSpawnPosition;

	[Token(Token = "0x4004EC3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] m_cornPrefabs;

	[Token(Token = "0x4004EC4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_lid;

	[Token(Token = "0x4004EC5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Rigidbody m_stoveRb;

	[Token(Token = "0x4004EC6")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UnityEvent OnPopCornPops;

	[Token(Token = "0x4004EC7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UnityEvent OnLidAppears;

	[Token(Token = "0x4004EC8")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UnityEvent OnPopcornCooked;

	[Token(Token = "0x4004EC9")]
	[FieldOffset(Offset = "0x60")]
	private bool spawned;

	[Token(Token = "0x4004ECA")]
	[FieldOffset(Offset = "0x64")]
	private int popCornToSpawn;

	[Token(Token = "0x4004ECB")]
	[FieldOffset(Offset = "0x68")]
	private List<GameObject> storedCorn;

	[Token(Token = "0x4004ECC")]
	[FieldOffset(Offset = "0x70")]
	private List<Transform> popCorn;

	[Token(Token = "0x6004414")]
	[Address(RVA = "0x161A194", Offset = "0x161A194", VA = "0x161A194")]
	public void SpawnpopCorn()
	{
	}

	[Token(Token = "0x6004415")]
	[Address(RVA = "0x161A298", Offset = "0x161A298", VA = "0x161A298")]
	private void AddPopCorn()
	{
	}

	[Token(Token = "0x6004416")]
	[Address(RVA = "0x161A224", Offset = "0x161A224", VA = "0x161A224")]
	private IEnumerator SpawnCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6004417")]
	[Address(RVA = "0x161A2A8", Offset = "0x161A2A8", VA = "0x161A2A8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6004418")]
	[Address(RVA = "0x161A358", Offset = "0x161A358", VA = "0x161A358")]
	public PopCornSpawner()
	{
	}
}
