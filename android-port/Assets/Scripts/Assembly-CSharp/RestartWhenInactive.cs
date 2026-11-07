using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[Token(Token = "0x2000B71")]
public class RestartWhenInactive : MonoBehaviour
{
	[Token(Token = "0x4003F77")]
	[FieldOffset(Offset = "0x18")]
	public float TimeBeforeCountdown;

	[Token(Token = "0x4003F78")]
	[FieldOffset(Offset = "0x1C")]
	public float CountdownTime;

	[Token(Token = "0x4003F79")]
	[FieldOffset(Offset = "0x20")]
	public List<string> DisableInScenes;

	[Token(Token = "0x4003F7A")]
	[FieldOffset(Offset = "0x28")]
	public List<string> FasterInScenes;

	[Token(Token = "0x4003F7B")]
	[FieldOffset(Offset = "0x30")]
	public TextWithShadow Text;

	[Token(Token = "0x4003F7C")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent RestartEvent;

	[Token(Token = "0x4003F7D")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent CountdownReachedEvent;

	[Token(Token = "0x4003F7E")]
	[FieldOffset(Offset = "0x48")]
	public UnityEvent CountdownCancelled;

	[Token(Token = "0x4003F7F")]
	[FieldOffset(Offset = "0x50")]
	public float timer;

	[Token(Token = "0x4003F80")]
	[FieldOffset(Offset = "0x54")]
	private bool countdownReached;

	[Token(Token = "0x4003F81")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 lastMousePos;

	[Token(Token = "0x4003F82")]
	[FieldOffset(Offset = "0x68")]
	private string activeSceneName;

	[Token(Token = "0x600370B")]
	[Address(RVA = "0x164D2E0", Offset = "0x164D2E0", VA = "0x164D2E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600370C")]
	[Address(RVA = "0x164D448", Offset = "0x164D448", VA = "0x164D448")]
	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
	{
	}

	[Token(Token = "0x600370D")]
	[Address(RVA = "0x164D480", Offset = "0x164D480", VA = "0x164D480")]
	private void Update()
	{
	}

	[Token(Token = "0x600370E")]
	[Address(RVA = "0x164D854", Offset = "0x164D854", VA = "0x164D854")]
	private void Reset()
	{
	}

	[Token(Token = "0x600370F")]
	[Address(RVA = "0x164D890", Offset = "0x164D890", VA = "0x164D890")]
	public RestartWhenInactive()
	{
	}
}
