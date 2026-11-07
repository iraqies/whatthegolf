using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001FB")]
public class PaintingBlueprint : MonoBehaviour
{
	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x18")]
	public Transform PaintPointsContainer;

	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x20")]
	public Transform AvoidPointsContainer;

	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PoseObject;

	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x30")]
	private List<Transform> paintPoints;

	[Token(Token = "0x1700011C")]
	public List<Transform> PaintPoints
	{
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x15D7450", Offset = "0x15D7450", VA = "0x15D7450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x15D77B4", Offset = "0x15D77B4", VA = "0x15D77B4")]
	public void Activate()
	{
	}

	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x15D7B00", Offset = "0x15D7B00", VA = "0x15D7B00")]
	public void ToggleBlueprint(bool state)
	{
	}

	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x15D7BD8", Offset = "0x15D7BD8", VA = "0x15D7BD8")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x15D7F24", Offset = "0x15D7F24", VA = "0x15D7F24")]
	public PaintingBlueprint()
	{
	}
}
