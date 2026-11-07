using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EBB")]
public class ValentinesPrizeVase : MonoBehaviour
{
	[Token(Token = "0x2000EBC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x452B0", Offset = "0x452B0")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x4004FAA")]
		[FieldOffset(Offset = "0x10")]
		public GameObject b;

		[Token(Token = "0x4004FAB")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 start;

		[Token(Token = "0x60044C9")]
		[Address(RVA = "0x1874688", Offset = "0x1874688", VA = "0x1874688")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x60044CA")]
		[Address(RVA = "0x1874690", Offset = "0x1874690", VA = "0x1874690")]
		internal void _003CNewBalloon_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4004FA6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject BalloonPrefab;

	[Token(Token = "0x4004FA7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Material> materials;

	[Token(Token = "0x4004FA8")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigid;

	[Token(Token = "0x4004FA9")]
	[FieldOffset(Offset = "0x30")]
	private List<Balloon> balloons;

	[Token(Token = "0x60044C4")]
	[Address(RVA = "0x1748440", Offset = "0x1748440", VA = "0x1748440")]
	private void Start()
	{
	}

	[Token(Token = "0x60044C5")]
	[Address(RVA = "0x1748578", Offset = "0x1748578", VA = "0x1748578")]
	private void OnBalloonPopped(Balloon b)
	{
	}

	[Token(Token = "0x60044C6")]
	[Address(RVA = "0x17485E4", Offset = "0x17485E4", VA = "0x17485E4")]
	public void NewBalloon()
	{
	}

	[Token(Token = "0x60044C7")]
	[Address(RVA = "0x1748964", Offset = "0x1748964", VA = "0x1748964")]
	public ValentinesPrizeVase()
	{
	}

	[Token(Token = "0x60044C8")]
	[Address(RVA = "0x174896C", Offset = "0x174896C", VA = "0x174896C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E264", Offset = "0x6E264")]
	private void _003CStart_003Eb__4_0(Balloon b)
	{
	}
}
