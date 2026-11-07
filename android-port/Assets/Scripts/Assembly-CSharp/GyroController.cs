using Il2CppDummyDll;
using Rewired.Platforms.Switch;
using UnityEngine;

[Token(Token = "0x20003F4")]
public class GyroController : MonoBehaviour
{
	[Token(Token = "0x400158D")]
	[FieldOffset(Offset = "0x18")]
	public bool isUpdatingGyro;

	[Token(Token = "0x400158E")]
	[FieldOffset(Offset = "0x20")]
	private Transform gyroTransform;

	[Token(Token = "0x400158F")]
	[FieldOffset(Offset = "0x28")]
	private Transform gyroLateTransform;

	[Token(Token = "0x4001590")]
	[FieldOffset(Offset = "0x30")]
	private Quaternion startOffset;

	[Token(Token = "0x4001591")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 lastForwrd;

	[Token(Token = "0x4001592")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 offset;

	[Token(Token = "0x4001593")]
	[FieldOffset(Offset = "0x58")]
	private bool didInit;

	[Token(Token = "0x4001594")]
	[FieldOffset(Offset = "0x0")]
	private static GyroController instance;

	[Token(Token = "0x4001595")]
	[FieldOffset(Offset = "0x5C")]
	private Quaternion lastAttitude;

	[Token(Token = "0x4001596")]
	[FieldOffset(Offset = "0x6C")]
	private float lastUpdate;

	[Token(Token = "0x4001597")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 tmpVel;

	[Token(Token = "0x4001598")]
	[FieldOffset(Offset = "0x8")]
	private static NintendoSwitchInputManager nintendoSwitchInputManager;

	[Token(Token = "0x1700021F")]
	public static GyroController Instance
	{
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x14BF5C8", Offset = "0x14BF5C8", VA = "0x14BF5C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001286")]
	[Address(RVA = "0x14BF5A4", Offset = "0x14BF5A4", VA = "0x14BF5A4")]
	public bool IsGyroEnabled()
	{
		return default;
	}

	[Token(Token = "0x6001288")]
	[Address(RVA = "0x14BF914", Offset = "0x14BF914", VA = "0x14BF914")]
	public bool IsGyroUsable()
	{
		return default;
	}

	[Token(Token = "0x6001289")]
	[Address(RVA = "0x14BF91C", Offset = "0x14BF91C", VA = "0x14BF91C")]
	public Vector3 GetOffset()
	{
		return default;
	}

	[Token(Token = "0x600128A")]
	[Address(RVA = "0x14BF9B0", Offset = "0x14BF9B0", VA = "0x14BF9B0")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600128B")]
	[Address(RVA = "0x14BF708", Offset = "0x14BF708", VA = "0x14BF708")]
	private void Init()
	{
	}

	[Token(Token = "0x600128C")]
	[Address(RVA = "0x14BFE0C", Offset = "0x14BFE0C", VA = "0x14BFE0C")]
	public Transform GetGyroTransform()
	{
		return null;
	}

	[Token(Token = "0x600128D")]
	[Address(RVA = "0x14BFE14", Offset = "0x14BFE14", VA = "0x14BFE14")]
	public Quaternion GetGyroAttitude()
	{
		return default;
	}

	[Token(Token = "0x600128E")]
	[Address(RVA = "0x14BFE38", Offset = "0x14BFE38", VA = "0x14BFE38")]
	private Quaternion GetSwitchGyro()
	{
		return default;
	}

	[Token(Token = "0x600128F")]
	[Address(RVA = "0x14BFA1C", Offset = "0x14BFA1C", VA = "0x14BFA1C")]
	private bool UpdateGyro()
	{
		return default;
	}

	[Token(Token = "0x6001290")]
	[Address(RVA = "0x14C00D4", Offset = "0x14C00D4", VA = "0x14C00D4")]
	public void Update()
	{
	}

	[Token(Token = "0x6001291")]
	[Address(RVA = "0x14C01B8", Offset = "0x14C01B8", VA = "0x14C01B8")]
	public GyroController()
	{
	}
}
