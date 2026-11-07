using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Moments;
using UnityEngine;

[Token(Token = "0x2000BF0")]
public class BaseSaveGif : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000BF1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43EA8", Offset = "0x43EA8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400422A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400422B")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__13_0;

		[Token(Token = "0x400422C")]
		[FieldOffset(Offset = "0x10")]
		public static Action<float> _003C_003E9__14_0;

		[Token(Token = "0x600394F")]
		[Address(RVA = "0x17717B8", Offset = "0x17717B8", VA = "0x17717B8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003950")]
		[Address(RVA = "0x17717C0", Offset = "0x17717C0", VA = "0x17717C0")]
		internal void _003CSave_003Eb__13_0(float t)
		{
		}

		[Token(Token = "0x6003951")]
		[Address(RVA = "0x17717C4", Offset = "0x17717C4", VA = "0x17717C4")]
		internal void _003CSaveInterval_003Eb__14_0(float t)
		{
		}
	}

	[Token(Token = "0x4004224")]
	[FieldOffset(Offset = "0x18")]
	public float GifDuration;

	[Token(Token = "0x4004225")]
	[FieldOffset(Offset = "0x1C")]
	public float SaveDelay;

	[Token(Token = "0x4004226")]
	[FieldOffset(Offset = "0x20")]
	public Action<string, List<RenderTexture>> OnFramesRetrieved;

	[Token(Token = "0x4004227")]
	[FieldOffset(Offset = "0x28")]
	protected Moments.Recorder recorder;

	[Token(Token = "0x4004228")]
	[FieldOffset(Offset = "0x30")]
	private bool isSaving;

	[Token(Token = "0x4004229")]
	[FieldOffset(Offset = "0x31")]
	private bool destroyNextFrame;

	[Token(Token = "0x6003942")]
	[Address(RVA = "0x16082EC", Offset = "0x16082EC", VA = "0x16082EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003943")]
	[Address(RVA = "0x1608440", Offset = "0x1608440", VA = "0x1608440", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6003944")]
	[Address(RVA = "0x1608670", Offset = "0x1608670", VA = "0x1608670")]
	private void Update()
	{
	}

	[Token(Token = "0x6003945")]
	[Address(RVA = "0x1608704", Offset = "0x1608704", VA = "0x1608704")]
	private void Instance_OnLevelWillUnload()
	{
	}

	[Token(Token = "0x6003946")]
	[Address(RVA = "0x1608814", Offset = "0x1608814", VA = "0x1608814")]
	private void OnProcessingDone()
	{
	}

	[Token(Token = "0x6003947")]
	[Address(RVA = "0x1608820", Offset = "0x1608820", VA = "0x1608820")]
	private void OnFileSaveProgress(int id, float percent)
	{
	}

	[Token(Token = "0x6003948")]
	[Address(RVA = "0x1608824", Offset = "0x1608824", VA = "0x1608824")]
	private void OnFileSaved(int id, string filepath)
	{
	}

	[Token(Token = "0x6003949")]
	[Address(RVA = "0x1608830", Offset = "0x1608830", VA = "0x1608830")]
	protected void Save()
	{
	}

	[Token(Token = "0x600394A")]
	[Address(RVA = "0x16089F0", Offset = "0x16089F0", VA = "0x16089F0")]
	protected void SaveInterval(float duration)
	{
	}

	[Token(Token = "0x600394B")]
	[Address(RVA = "0x1608BBC", Offset = "0x1608BBC", VA = "0x1608BBC")]
	public BaseSaveGif()
	{
	}

	[Token(Token = "0x600394C")]
	[Address(RVA = "0x1608BCC", Offset = "0x1608BCC", VA = "0x1608BCC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B2BC", Offset = "0x6B2BC")]
	private void _003CSave_003Eb__13_1()
	{
	}

	[Token(Token = "0x600394D")]
	[Address(RVA = "0x1608D0C", Offset = "0x1608D0C", VA = "0x1608D0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B2CC", Offset = "0x6B2CC")]
	private void _003CSaveInterval_003Eb__14_1()
	{
	}
}
