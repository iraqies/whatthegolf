using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D2")]
public class ChangePoleSizeBasedOnBoost : MonoBehaviour
{
	[Token(Token = "0x4000875")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 ScaleRange;

	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve GrowCurve;

	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0x30")]
	public float GrowSmoothTime;

	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 targetScale;

	[Token(Token = "0x400087A")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 velRef;

	[Token(Token = "0x600082F")]
	[Address(RVA = "0x1897E90", Offset = "0x1897E90", VA = "0x1897E90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000830")]
	[Address(RVA = "0x1897F64", Offset = "0x1897F64", VA = "0x1897F64")]
	private void ControllerOnOnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000831")]
	[Address(RVA = "0x1898078", Offset = "0x1898078", VA = "0x1898078")]
	private void Update()
	{
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0x1898114", Offset = "0x1898114", VA = "0x1898114")]
	public ChangePoleSizeBasedOnBoost()
	{
	}
}
