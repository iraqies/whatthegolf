using System;
using System.Collections.Generic;
using Cinemachine;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002EC")]
public class SwapControllerOnTriggerEnter : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20002ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ED6C", Offset = "0x3ED6C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x8")]
		public static Action<GameObject> _003C_003E9__13_0;

		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0x10")]
		public static Action<GameObject> _003C_003E9__14_0;

		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0x18")]
		public static Action<GameObject> _003C_003E9__14_1;

		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x185F23C", Offset = "0x185F23C", VA = "0x185F23C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x185F244", Offset = "0x185F244", VA = "0x185F244")]
		internal void _003CStart_003Eb__13_0(GameObject g)
		{
		}

		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x185F264", Offset = "0x185F264", VA = "0x185F264")]
		internal void _003CEnableThisController_003Eb__14_0(GameObject g)
		{
		}

		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x185F284", Offset = "0x185F284", VA = "0x185F284")]
		internal void _003CEnableThisController_003Eb__14_1(GameObject g)
		{
		}
	}

	[Token(Token = "0x4001022")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject NewControllerGO;

	[Token(Token = "0x4001023")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GolfBallController NewController;

	[Token(Token = "0x4001024")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform NewCamFollow;

	[Token(Token = "0x4001025")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float NewDollySpeed;

	[Token(Token = "0x4001026")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ParticleSystem ParticleEffect;

	[Token(Token = "0x4001027")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private DollyCartSpeedManager DollySpeedManager;

	[Token(Token = "0x4001028")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private CinemachineVirtualCamera VCam;

	[Token(Token = "0x4001029")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private CinemachineVirtualCamera NewVCam;

	[Token(Token = "0x400102A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool DebugStartFromHere;

	[Token(Token = "0x400102B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<GameObject> GameObjectsToActivate;

	[Token(Token = "0x400102C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<GameObject> GameObjectsToDeactivate;

	[Token(Token = "0x400102D")]
	[FieldOffset(Offset = "0x70")]
	private bool HasSwapped;

	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x16EF584", Offset = "0x16EF584", VA = "0x16EF584")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x16EF9D0", Offset = "0x16EF9D0", VA = "0x16EF9D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0x16EF6D4", Offset = "0x16EF6D4", VA = "0x16EF6D4")]
	private void EnableThisController()
	{
	}

	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x16EFC2C", Offset = "0x16EFC2C", VA = "0x16EFC2C")]
	public SwapControllerOnTriggerEnter()
	{
	}
}
