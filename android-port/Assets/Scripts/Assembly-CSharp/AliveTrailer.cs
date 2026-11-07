using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D5D")]
public class AliveTrailer : MonoBehaviour
{
	[Token(Token = "0x2000D5E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x44908", Offset = "0x44908")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x40048AA")]
		[FieldOffset(Offset = "0x10")]
		public GolfBallController c;

		[Token(Token = "0x40048AB")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startP;

		[Token(Token = "0x40048AC")]
		[FieldOffset(Offset = "0x28")]
		public AliveTrailer _003C_003E4__this;

		[Token(Token = "0x40048AD")]
		[FieldOffset(Offset = "0x30")]
		public Quaternion startR;

		[Token(Token = "0x40048AE")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 startS;

		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0x1769030", Offset = "0x1769030", VA = "0x1769030")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6003EDE")]
		[Address(RVA = "0x1769038", Offset = "0x1769038", VA = "0x1769038")]
		internal void _003CSuckIntoPipe_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x40048A3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _inHole;

	[Token(Token = "0x40048A4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _duration;

	[Token(Token = "0x40048A5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationCurve _scale;

	[Token(Token = "0x40048A6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve _rotation;

	[Token(Token = "0x40048A7")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve _position;

	[Token(Token = "0x40048A8")]
	[FieldOffset(Offset = "0x40")]
	private bool done;

	[Token(Token = "0x40048A9")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ParticleSystem _particle;

	[Token(Token = "0x6003EDA")]
	[Address(RVA = "0x140D3A4", Offset = "0x140D3A4", VA = "0x140D3A4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003EDB")]
	[Address(RVA = "0x140D478", Offset = "0x140D478", VA = "0x140D478")]
	private void SuckIntoPipe(GolfBallController c)
	{
	}

	[Token(Token = "0x6003EDC")]
	[Address(RVA = "0x140D628", Offset = "0x140D628", VA = "0x140D628")]
	public AliveTrailer()
	{
	}
}
