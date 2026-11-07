using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000303")]
public class LinkParticleSpeedAndAim : MonoBehaviour
{
	[Token(Token = "0x40010B7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x40010B8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float max;

	[Token(Token = "0x40010B9")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float min;

	[Token(Token = "0x40010BA")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem p;

	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x1534650", Offset = "0x1534650", VA = "0x1534650")]
	private void Start()
	{
	}

	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0x1534724", Offset = "0x1534724", VA = "0x1534724")]
	private void OnAimUpdate(Vector3 boost, bool b)
	{
	}

	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x15347A8", Offset = "0x15347A8", VA = "0x15347A8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000DED")]
	[Address(RVA = "0x1534858", Offset = "0x1534858", VA = "0x1534858")]
	public LinkParticleSpeedAndAim()
	{
	}
}
