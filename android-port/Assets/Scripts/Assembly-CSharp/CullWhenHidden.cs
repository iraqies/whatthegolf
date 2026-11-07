using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009A2")]
public class CullWhenHidden : GolfBehaviour
{
	[Serializable]
	[Token(Token = "0x20009A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42640", Offset = "0x42640")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003519")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400351A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MonoBehaviour, bool> _003C_003E9__17_0;

		[Token(Token = "0x400351B")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<AudioSource> _003C_003E9__17_1;

		[Token(Token = "0x400351C")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<Animator> _003C_003E9__17_2;

		[Token(Token = "0x6002D4F")]
		[Address(RVA = "0x17934BC", Offset = "0x17934BC", VA = "0x17934BC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002D50")]
		[Address(RVA = "0x17934C4", Offset = "0x17934C4", VA = "0x17934C4")]
		internal bool _003COnPrePlayOrPreCompile_003Eb__17_0(MonoBehaviour s)
		{
			return default;
		}

		[Token(Token = "0x6002D51")]
		[Address(RVA = "0x1793534", Offset = "0x1793534", VA = "0x1793534")]
		internal bool _003COnPrePlayOrPreCompile_003Eb__17_1(AudioSource s)
		{
			return default;
		}

		[Token(Token = "0x6002D52")]
		[Address(RVA = "0x1793550", Offset = "0x1793550", VA = "0x1793550")]
		internal bool _003COnPrePlayOrPreCompile_003Eb__17_2(Animator s)
		{
			return default;
		}
	}

	[Token(Token = "0x4003508")]
	[FieldOffset(Offset = "0x19")]
	public bool disableAllScriptsWhenCull;

	[Token(Token = "0x4003509")]
	[FieldOffset(Offset = "0x1A")]
	public bool isCullingRigids;

	[Token(Token = "0x400350A")]
	[FieldOffset(Offset = "0x20")]
	public MonoBehaviour[] disableSpecificScripts;

	[Token(Token = "0x400350B")]
	[FieldOffset(Offset = "0x28")]
	public List<MonoBehaviour> currentDisableSpecificScripts;

	[Token(Token = "0x400350C")]
	[FieldOffset(Offset = "0x30")]
	public bool disableAnimations;

	[Token(Token = "0x400350D")]
	[FieldOffset(Offset = "0x31")]
	public bool disablePaticles;

	[Token(Token = "0x400350E")]
	[FieldOffset(Offset = "0x32")]
	public bool disableAudioSources;

	[Token(Token = "0x400350F")]
	[FieldOffset(Offset = "0x33")]
	public bool disableSprites;

	[Token(Token = "0x4003510")]
	[FieldOffset(Offset = "0x34")]
	private bool isVisible;

	[Token(Token = "0x4003511")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Rigidbody2D[] rigids;

	[Token(Token = "0x4003512")]
	[FieldOffset(Offset = "0x40")]
	public InvisibleCullingObject cullingObject;

	[Token(Token = "0x4003513")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioSource[] audiosources;

	[Token(Token = "0x4003514")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Animator[] animators;

	[Token(Token = "0x4003515")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ParticleSystem[] particles;

	[Token(Token = "0x4003516")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private SortByY[] sorties;

	[Token(Token = "0x4003517")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private LineRenderer[] lineRenders;

	[Token(Token = "0x4003518")]
	[FieldOffset(Offset = "0x70")]
	private bool isSectionVisible;

	[Token(Token = "0x6002D45")]
	[Address(RVA = "0x18C2FCC", Offset = "0x18C2FCC", VA = "0x18C2FCC", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002D46")]
	[Address(RVA = "0x18C3648", Offset = "0x18C3648", VA = "0x18C3648")]
	public void Init()
	{
	}

	[Token(Token = "0x6002D47")]
	[Address(RVA = "0x18C3D94", Offset = "0x18C3D94", VA = "0x18C3D94")]
	public void OnVisible()
	{
	}

	[Token(Token = "0x6002D48")]
	[Address(RVA = "0x18C3DAC", Offset = "0x18C3DAC", VA = "0x18C3DAC")]
	public void OnInvisible()
	{
	}

	[Token(Token = "0x6002D49")]
	[Address(RVA = "0x18C3820", Offset = "0x18C3820", VA = "0x18C3820")]
	public void UpdateState()
	{
	}

	[Token(Token = "0x6002D4A")]
	[Address(RVA = "0x18C3DC4", Offset = "0x18C3DC4", VA = "0x18C3DC4")]
	public void OnSectionInvisible()
	{
	}

	[Token(Token = "0x6002D4B")]
	[Address(RVA = "0x18C3E64", Offset = "0x18C3E64", VA = "0x18C3E64")]
	public void OnSectionVisible()
	{
	}

	[Token(Token = "0x6002D4C")]
	[Address(RVA = "0x18C3F08", Offset = "0x18C3F08", VA = "0x18C3F08")]
	public CullWhenHidden()
	{
	}

	[Token(Token = "0x6002D4D")]
	[Address(RVA = "0x18C3F20", Offset = "0x18C3F20", VA = "0x18C3F20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68534", Offset = "0x68534")]
	private bool _003COnPrePlayOrPreCompile_003Eb__17_3(MonoBehaviour s)
	{
		return default;
	}
}
