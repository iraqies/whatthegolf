using Il2CppDummyDll;
using UnityEngine;
using VFX;

[Token(Token = "0x200014D")]
public class StraightLineProjector2D : TrajectoryProjector
{
	[Token(Token = "0x40005DA")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private LineRenderer line;

	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private LayerMask layers;

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x16E2EE0", Offset = "0x16E2EE0", VA = "0x16E2EE0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x16E2F3C", Offset = "0x16E2F3C", VA = "0x16E2F3C", Slot = "5")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x16E2F40", Offset = "0x16E2F40", VA = "0x16E2F40")]
	private void Update()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x16E31C8", Offset = "0x16E31C8", VA = "0x16E31C8", Slot = "6")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x16E31E8", Offset = "0x16E31E8", VA = "0x16E31E8")]
	public StraightLineProjector2D()
	{
	}
}
