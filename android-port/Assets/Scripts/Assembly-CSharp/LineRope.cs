using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000758")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x41330", Offset = "0x41330")]
public class LineRope : MonoBehaviour
{
	[Token(Token = "0x40026FD")]
	[FieldOffset(Offset = "0x18")]
	public Transform LineStart;

	[Token(Token = "0x40026FE")]
	[FieldOffset(Offset = "0x20")]
	public Transform LineEnd;

	[Token(Token = "0x40026FF")]
	[FieldOffset(Offset = "0x28")]
	public bool DoLineJiggle;

	[Token(Token = "0x4002700")]
	[FieldOffset(Offset = "0x2C")]
	public int Segments;

	[Token(Token = "0x4002701")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve Curve;

	[Token(Token = "0x4002702")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve EffectOverTime;

	[Token(Token = "0x4002703")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve CurveEffect;

	[Token(Token = "0x4002704")]
	[FieldOffset(Offset = "0x48")]
	public float JiggleStrength;

	[Token(Token = "0x4002705")]
	[FieldOffset(Offset = "0x4C")]
	public float JiggleTimerSpeed;

	[Token(Token = "0x4002706")]
	[FieldOffset(Offset = "0x50")]
	public float IsKinematicSpeedMultiplier;

	[Token(Token = "0x4002707")]
	[FieldOffset(Offset = "0x58")]
	private Rigidbody rigid;

	[Token(Token = "0x4002708")]
	[FieldOffset(Offset = "0x60")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x4002709")]
	[FieldOffset(Offset = "0x68")]
	private float jiggleTimer;

	[Token(Token = "0x60021E7")]
	[Address(RVA = "0x1533908", Offset = "0x1533908", VA = "0x1533908")]
	private void Start()
	{
	}

	[Token(Token = "0x60021E8")]
	[Address(RVA = "0x15339B4", Offset = "0x15339B4", VA = "0x15339B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60021E9")]
	[Address(RVA = "0x1533E98", Offset = "0x1533E98", VA = "0x1533E98")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60021EA")]
	[Address(RVA = "0x1533F2C", Offset = "0x1533F2C", VA = "0x1533F2C")]
	public LineRope()
	{
	}
}
