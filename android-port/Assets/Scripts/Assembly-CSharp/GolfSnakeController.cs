using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D7D")]
public class GolfSnakeController : MonoBehaviour
{
	[Token(Token = "0x2000D7E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A68", Offset = "0x44A68")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4004964")]
		[FieldOffset(Offset = "0x10")]
		public GameObject clone;

		[Token(Token = "0x4004965")]
		[FieldOffset(Offset = "0x18")]
		public GolfSnakeController _003C_003E4__this;

		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x17B5E90", Offset = "0x17B5E90", VA = "0x17B5E90")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6003F72")]
		[Address(RVA = "0x17B5E98", Offset = "0x17B5E98", VA = "0x17B5E98")]
		internal void _003CAddMember_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x400495C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject prefab;

	[Token(Token = "0x400495D")]
	[FieldOffset(Offset = "0x20")]
	public float childAppearSpeed;

	[Token(Token = "0x400495E")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve curveSpawnChildren;

	[Token(Token = "0x400495F")]
	[FieldOffset(Offset = "0x30")]
	public int maxChildren;

	[Token(Token = "0x4004960")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent OnMaxChildren;

	[Token(Token = "0x4004961")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent OnChildSpawned;

	[Token(Token = "0x4004962")]
	[FieldOffset(Offset = "0x48")]
	private FollowTransformUtility followTransformUtility;

	[Token(Token = "0x4004963")]
	[FieldOffset(Offset = "0x50")]
	private bool maxedOut;

	[Token(Token = "0x6003F6E")]
	[Address(RVA = "0x14A4034", Offset = "0x14A4034", VA = "0x14A4034")]
	public void Update()
	{
	}

	[Token(Token = "0x6003F6F")]
	[Address(RVA = "0x14A4094", Offset = "0x14A4094", VA = "0x14A4094")]
	public void AddMember(float numberOfChildren)
	{
	}

	[Token(Token = "0x6003F70")]
	[Address(RVA = "0x14A432C", Offset = "0x14A432C", VA = "0x14A432C")]
	public GolfSnakeController()
	{
	}
}
