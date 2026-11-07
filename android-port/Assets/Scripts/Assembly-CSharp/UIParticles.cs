using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200035F")]
[Attribute(Name = "RequireComponent", RVA = "0x3F220", Offset = "0x3F220")]
[Attribute(Name = "RequireComponent", RVA = "0x3F220", Offset = "0x3F220")]
[ExecuteInEditMode]
public class UIParticles : MaskableGraphic
{
	[Token(Token = "0x4001288")]
	[FieldOffset(Offset = "0xD0")]
	public Texture particleTexture;

	[Token(Token = "0x4001289")]
	[FieldOffset(Offset = "0xD8")]
	public Sprite particleSprite;

	[Token(Token = "0x400128A")]
	[FieldOffset(Offset = "0xE0")]
	private Transform _transform;

	[Token(Token = "0x400128B")]
	[FieldOffset(Offset = "0xE8")]
	private ParticleSystem _particleSystem;

	[Token(Token = "0x400128C")]
	[FieldOffset(Offset = "0xF0")]
	private ParticleSystem.Particle[] _particles;

	[Token(Token = "0x400128D")]
	[FieldOffset(Offset = "0xF8")]
	private UIVertex[] _quad;

	[Token(Token = "0x400128E")]
	[FieldOffset(Offset = "0x100")]
	private Vector4 _uv;

	[Token(Token = "0x400128F")]
	[FieldOffset(Offset = "0x110")]
	private ParticleSystem.TextureSheetAnimationModule _textureSheetAnimation;

	[Token(Token = "0x4001290")]
	[FieldOffset(Offset = "0x118")]
	private int _textureSheetAnimationFrames;

	[Token(Token = "0x4001291")]
	[FieldOffset(Offset = "0x11C")]
	private Vector2 _textureSheedAnimationFrameSize;

	[Token(Token = "0x170001D4")]
	public override Texture mainTexture
	{
		[Token(Token = "0x6000FA3")]
		[Address(RVA = "0x1737184", Offset = "0x1737184", VA = "0x1737184", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000FA4")]
	[Address(RVA = "0x1737268", Offset = "0x1737268", VA = "0x1737268")]
	protected bool Initialize()
	{
		return default;
	}

	[Token(Token = "0x6000FA5")]
	[Address(RVA = "0x17376B0", Offset = "0x17376B0", VA = "0x17376B0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x17376F8", Offset = "0x17376F8", VA = "0x17376F8", Slot = "43")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x1737E1C", Offset = "0x1737E1C", VA = "0x1737E1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x1737E88", Offset = "0x1737E88", VA = "0x1737E88")]
	public UIParticles()
	{
	}
}
