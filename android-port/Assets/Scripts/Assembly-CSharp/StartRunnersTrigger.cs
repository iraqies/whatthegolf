using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002A6")]
public class StartRunnersTrigger : MonoBehaviour
{
	[Token(Token = "0x4000E2A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Runner> runners;

	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform runnerContainer;

	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LayerMask acceptLayers;

	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool stopOnAwake;

	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x2D")]
	private bool startedRunners;

	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x16DB488", Offset = "0x16DB488", VA = "0x16DB488")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x16DB678", Offset = "0x16DB678", VA = "0x16DB678")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x16DB814", Offset = "0x16DB814", VA = "0x16DB814")]
	public StartRunnersTrigger()
	{
	}
}
