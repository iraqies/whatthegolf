using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000C5")]
public class LobbySpawnPoint : MonoBehaviour
{
	[Token(Token = "0x20000C6")]
	public enum SpawnPointPositions
	{
		[Token(Token = "0x4000329")]
		Left = 0,
		[Token(Token = "0x400032A")]
		Right = 1
	}

	[Token(Token = "0x20000C7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D870", Offset = "0x3D870")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x10")]
		public int i1;

		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x18")]
		public LobbySpawnPoint _003C_003E4__this;

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x17ECA7C", Offset = "0x17ECA7C", VA = "0x17ECA7C")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x17ECA84", Offset = "0x17ECA84", VA = "0x17ECA84")]
		internal void _003CSpawnpointPickedBy_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20000C8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D880", Offset = "0x3D880")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x10")]
		public LobbySpawnPoint _003C_003E4__this;

		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x18")]
		public float s;

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x17ECB44", Offset = "0x17ECB44", VA = "0x17ECB44")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x17ECB4C", Offset = "0x17ECB4C", VA = "0x17ECB4C")]
		internal void _003CSpawnpointDeactivated_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x18")]
	public SpawnPointPositions Position;

	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ReadySilhouette;

	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x28")]
	public Animator PressToJoinAnimator;

	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x30")]
	public Animator PipeAnimator;

	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem Particles;

	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x40")]
	public MeshRenderer Pillow;

	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x48")]
	public Transform CrownSpawnPosition;

	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x50")]
	public Transform PlayerSpawnPosition;

	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x58")]
	public Animator PillowAnimator;

	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x60")]
	public LobbySpawnAudio spawnAudioBehaviour;

	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x68")]
	public Sprite defaultButtonSprite;

	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x70")]
	public Sprite playstationButtonSprite;

	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x78")]
	public SVGImage buttonImage;

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x153AAAC", Offset = "0x153AAAC", VA = "0x153AAAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x153AB04", Offset = "0x153AB04", VA = "0x153AB04")]
	public void SpawnpointPickedBy(PlayerColors.AvatarData avatar)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x153AD54", Offset = "0x153AD54", VA = "0x153AD54")]
	public void SpawnpointDeactivated()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x153AF24", Offset = "0x153AF24", VA = "0x153AF24")]
	public void SpawnpointGettingActivated(float time)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x153B01C", Offset = "0x153B01C", VA = "0x153B01C")]
	public LobbySpawnPoint()
	{
	}
}
