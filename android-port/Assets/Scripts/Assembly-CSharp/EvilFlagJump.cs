using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000738")]
public class EvilFlagJump : MonoBehaviour, IFlagMovable
{
	[Token(Token = "0x2000739")]
	public enum PointSelectionMode
	{
		[Token(Token = "0x4002642")]
		Farthest = 0,
		[Token(Token = "0x4002643")]
		Sequence = 1,
		[Token(Token = "0x4002644")]
		Random = 2
	}

	[Token(Token = "0x4002630")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> Positions;

	[Token(Token = "0x4002631")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController ball;

	[Token(Token = "0x4002632")]
	[FieldOffset(Offset = "0x28")]
	public float TravelTime;

	[Token(Token = "0x4002633")]
	[FieldOffset(Offset = "0x2C")]
	public float Height;

	[Token(Token = "0x4002634")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve XZ_Curve;

	[Token(Token = "0x4002635")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve Y_Curve;

	[Token(Token = "0x4002636")]
	[FieldOffset(Offset = "0x40")]
	public PointSelectionMode jumpMode;

	[Token(Token = "0x4002637")]
	[FieldOffset(Offset = "0x48")]
	public ClipSettingsCollection jumpStartSFX;

	[Token(Token = "0x4002638")]
	[FieldOffset(Offset = "0x50")]
	public float endSFXThreshold;

	[Token(Token = "0x4002639")]
	[FieldOffset(Offset = "0x58")]
	public ClipSettingsCollection jumpEndSFX;

	[Token(Token = "0x400263A")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody m_Rigidbody;

	[Token(Token = "0x400263B")]
	[FieldOffset(Offset = "0x68")]
	private Transform m_CurrentTarget;

	[Token(Token = "0x400263C")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 m_PositionFrom;

	[Token(Token = "0x400263D")]
	[FieldOffset(Offset = "0x7C")]
	private float m_TravelTimer;

	[Token(Token = "0x400263E")]
	[FieldOffset(Offset = "0x80")]
	private int m_index;

	[Token(Token = "0x400263F")]
	[FieldOffset(Offset = "0x84")]
	private bool init;

	[Token(Token = "0x4002640")]
	[FieldOffset(Offset = "0x85")]
	private bool playedEndSFX;

	[Token(Token = "0x600214E")]
	[Address(RVA = "0x144BE20", Offset = "0x144BE20", VA = "0x144BE20")]
	private void Start()
	{
	}

	[Token(Token = "0x600214F")]
	[Address(RVA = "0x144BE24", Offset = "0x144BE24", VA = "0x144BE24")]
	private void Init()
	{
	}

	[Token(Token = "0x6002150")]
	[Address(RVA = "0x144BEDC", Offset = "0x144BEDC", VA = "0x144BEDC", Slot = "4")]
	public void Move()
	{
	}

	[Token(Token = "0x6002151")]
	[Address(RVA = "0x144C150", Offset = "0x144C150", VA = "0x144C150")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002152")]
	[Address(RVA = "0x144BF74", Offset = "0x144BF74", VA = "0x144BF74")]
	private void SetNextPoint()
	{
	}

	[Token(Token = "0x6002153")]
	[Address(RVA = "0x144C2E0", Offset = "0x144C2E0", VA = "0x144C2E0")]
	public EvilFlagJump()
	{
	}

	[Token(Token = "0x6002154")]
	[Address(RVA = "0x144C30C", Offset = "0x144C30C", VA = "0x144C30C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65BD0", Offset = "0x65BD0")]
	private float _003CSetNextPoint_003Eb__22_0(Transform t)
	{
		return default;
	}
}
