using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EC1")]
public class ZeroPitchAboveHeight : MonoBehaviour
{
	[Token(Token = "0x4004FC6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LayerMask groundMask;

	[Token(Token = "0x4004FC7")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float groundDist;

	[Token(Token = "0x4004FC8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float pitch;

	[Token(Token = "0x4004FC9")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 down;

	[Token(Token = "0x4004FCA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 checkOffset;

	[Token(Token = "0x4004FCB")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float AcceptedNormalUp;

	[Token(Token = "0x4004FCC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve HeightToPitchCurve;

	[Token(Token = "0x4004FCD")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool useLocalDown;

	[Token(Token = "0x4004FCE")]
	[FieldOffset(Offset = "0x50")]
	private GolfBallShooterExperimental shooter;

	[Token(Token = "0x60044E7")]
	[Address(RVA = "0x1761FA4", Offset = "0x1761FA4", VA = "0x1761FA4")]
	private void Start()
	{
	}

	[Token(Token = "0x60044E8")]
	[Address(RVA = "0x1762000", Offset = "0x1762000", VA = "0x1762000")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60044E9")]
	[Address(RVA = "0x17620C4", Offset = "0x17620C4", VA = "0x17620C4")]
	private float HasHitGroundFromPosition(Vector3 position, Vector3 d)
	{
		return default;
	}

	[Token(Token = "0x60044EA")]
	[Address(RVA = "0x17621CC", Offset = "0x17621CC", VA = "0x17621CC")]
	private bool AccecptNormals(RaycastHit hit)
	{
		return default;
	}

	[Token(Token = "0x60044EB")]
	[Address(RVA = "0x176222C", Offset = "0x176222C", VA = "0x176222C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60044EC")]
	[Address(RVA = "0x1762304", Offset = "0x1762304", VA = "0x1762304")]
	public ZeroPitchAboveHeight()
	{
	}
}
