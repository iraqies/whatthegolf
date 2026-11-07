using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A8E")]
public class EnableAudioOnVisible : GolfBehaviour
{
	[Token(Token = "0x4003AAC")]
	[FieldOffset(Offset = "0x20")]
	public InvisibleCullingObject cullingObject;

	[Token(Token = "0x4003AAD")]
	[FieldOffset(Offset = "0x28")]
	public bool findFirstRendererInChildren;

	[Token(Token = "0x4003AAE")]
	[FieldOffset(Offset = "0x30")]
	public Renderer m_renderer;

	[Token(Token = "0x4003AAF")]
	[FieldOffset(Offset = "0x38")]
	private AudioSource[] m_audioSources;

	[Token(Token = "0x4003AB0")]
	[FieldOffset(Offset = "0x40")]
	private IAudioCullable[] cullables;

	[Token(Token = "0x4003AB1")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x505B8", Offset = "0x505B8")]
	private bool IsVisible__BackingField;

	[Token(Token = "0x17000533")]
	public bool IsVisible
	{
		[Token(Token = "0x6003267")]
		[Address(RVA = "0x14427E8", Offset = "0x14427E8", VA = "0x14427E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x69DD4", Offset = "0x69DD4")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003268")]
		[Address(RVA = "0x14427F0", Offset = "0x14427F0", VA = "0x14427F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x69DE4", Offset = "0x69DE4")]
		private set
		{
		}
	}

	[Token(Token = "0x6003269")]
	[Address(RVA = "0x14427F8", Offset = "0x14427F8", VA = "0x14427F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600326A")]
	[Address(RVA = "0x1442BC8", Offset = "0x1442BC8", VA = "0x1442BC8")]
	private void Update()
	{
	}

	[Token(Token = "0x600326B")]
	[Address(RVA = "0x1442A74", Offset = "0x1442A74", VA = "0x1442A74")]
	private void SetEnabledStatus(bool status)
	{
	}

	[Token(Token = "0x600326C")]
	[Address(RVA = "0x1442C98", Offset = "0x1442C98", VA = "0x1442C98")]
	public EnableAudioOnVisible()
	{
	}

	[Token(Token = "0x600326D")]
	[Address(RVA = "0x1442CA0", Offset = "0x1442CA0", VA = "0x1442CA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x69DF4", Offset = "0x69DF4")]
	private void _003CAwake_003Eb__9_0()
	{
	}

	[Token(Token = "0x600326E")]
	[Address(RVA = "0x1442CA8", Offset = "0x1442CA8", VA = "0x1442CA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x69E04", Offset = "0x69E04")]
	private void _003CAwake_003Eb__9_1()
	{
	}
}
