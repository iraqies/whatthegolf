using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D3D")]
public class WwiseAudioSources : MonoBehaviour
{
	[Token(Token = "0x2000D3E")]
	public class SourceInfo
	{
		[Token(Token = "0x400481D")]
		[FieldOffset(Offset = "0x10")]
		public MusicClip parent;

		[Token(Token = "0x400481E")]
		[FieldOffset(Offset = "0x18")]
		public AudioSource source;

		[Token(Token = "0x400481F")]
		[FieldOffset(Offset = "0x20")]
		public float lastStart;

		[Token(Token = "0x6003E77")]
		[Address(RVA = "0x187A14C", Offset = "0x187A14C", VA = "0x187A14C")]
		public SourceInfo()
		{
		}
	}

	[Token(Token = "0x4004818")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int count;

	[Token(Token = "0x4004819")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioSource audioSourcePrefab;

	[Token(Token = "0x400481A")]
	[FieldOffset(Offset = "0x28")]
	private SourceInfo[] audioSources;

	[Token(Token = "0x400481B")]
	[FieldOffset(Offset = "0x30")]
	private int index;

	[Token(Token = "0x400481C")]
	[FieldOffset(Offset = "0x34")]
	private bool didInit;

	[Token(Token = "0x6003E73")]
	[Address(RVA = "0x175CA08", Offset = "0x175CA08", VA = "0x175CA08")]
	public void Awake()
	{
	}

	[Token(Token = "0x6003E74")]
	[Address(RVA = "0x175CA18", Offset = "0x175CA18", VA = "0x175CA18")]
	private void Init()
	{
	}

	[Token(Token = "0x6003E75")]
	[Address(RVA = "0x175CC8C", Offset = "0x175CC8C", VA = "0x175CC8C")]
	public SourceInfo Get(MusicClip parent)
	{
		return null;
	}

	[Token(Token = "0x6003E76")]
	[Address(RVA = "0x175CE18", Offset = "0x175CE18", VA = "0x175CE18")]
	public WwiseAudioSources()
	{
	}
}
