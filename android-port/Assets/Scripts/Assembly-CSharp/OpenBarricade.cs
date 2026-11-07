using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DB8")]
public class OpenBarricade : MonoBehaviour
{
	[Token(Token = "0x4004ACC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string id;

	[Token(Token = "0x4004ACD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> _gameObjectsToDeactiveteIfdoorIsOpen;

	[Token(Token = "0x4004ACE")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x524D4", Offset = "0x524D4")]
	[SerializeField]
	private List<GameObject> _gameObjectsToActivate;

	[Token(Token = "0x170006A1")]
	public bool isOpen
	{
		[Token(Token = "0x6004093")]
		[Address(RVA = "0x159C228", Offset = "0x159C228", VA = "0x159C228")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6004094")]
	[Address(RVA = "0x159C2A0", Offset = "0x159C2A0", VA = "0x159C2A0")]
	public void OpenDoor(bool setObjectState = false)
	{
	}

	[Token(Token = "0x6004095")]
	[Address(RVA = "0x159C734", Offset = "0x159C734", VA = "0x159C734")]
	private void InstanceOnOnToggleOverworld(bool obj)
	{
	}

	[Token(Token = "0x6004096")]
	[Address(RVA = "0x159C860", Offset = "0x159C860", VA = "0x159C860")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004097")]
	[Address(RVA = "0x159C8F4", Offset = "0x159C8F4", VA = "0x159C8F4")]
	public void UpdateState()
	{
	}

	[Token(Token = "0x6004098")]
	[Address(RVA = "0x159C7CC", Offset = "0x159C7CC", VA = "0x159C7CC")]
	private void SetState()
	{
	}

	[Token(Token = "0x6004099")]
	[Address(RVA = "0x159C3B4", Offset = "0x159C3B4", VA = "0x159C3B4")]
	private void DeactiveObjects()
	{
	}

	[Token(Token = "0x600409A")]
	[Address(RVA = "0x159C988", Offset = "0x159C988", VA = "0x159C988")]
	public void SetActive(List<GameObject> toList)
	{
	}

	[Token(Token = "0x600409B")]
	[Address(RVA = "0x159C9EC", Offset = "0x159C9EC", VA = "0x159C9EC")]
	public void SetDecals(List<GameObject> toList)
	{
	}

	[Token(Token = "0x600409C")]
	[Address(RVA = "0x159CA50", Offset = "0x159CA50", VA = "0x159CA50")]
	public OpenBarricade()
	{
	}
}
