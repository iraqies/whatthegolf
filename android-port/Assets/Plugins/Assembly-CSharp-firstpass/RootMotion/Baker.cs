using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace RootMotion
{
	[Token(Token = "0x20000D3")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D4")]
		public enum Mode
		{
			[Token(Token = "0x400046A")]
			AnimationClips = 0,
			[Token(Token = "0x400046B")]
			AnimationStates = 1,
			[Token(Token = "0x400046C")]
			PlayableDirector = 2,
			[Token(Token = "0x400046D")]
			Realtime = 3
		}

		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35360", Offset = "0x35360")]
		public int frameRate;

		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3537C", Offset = "0x3537C")]
		public float keyReductionError;

		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x20")]
		public Mode mode;

		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x28")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x30")]
		public string[] animationStates;

		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x38")]
		public bool loop;

		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x40")]
		public string saveToFolder;

		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x48")]
		public string appendName;

		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x50")]
		public string saveName;

		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3539C", Offset = "0x3539C")]
		private bool isBaking__BackingField;

		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x353AC", Offset = "0x353AC")]
		private float bakingProgress__BackingField;

		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public Animator animator;

		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public PlayableDirector director;

		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x353DC", Offset = "0x353DC")]
		private float clipLength__BackingField;

		[Token(Token = "0x170000CC")]
		public bool isBaking
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x12F55FC", Offset = "0x12F55FC", VA = "0x12F55FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38254", Offset = "0x38254")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x12F5604", Offset = "0x12F5604", VA = "0x12F5604")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38264", Offset = "0x38264")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public float bakingProgress
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x12F560C", Offset = "0x12F560C", VA = "0x12F560C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38274", Offset = "0x38274")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x12F5614", Offset = "0x12F5614", VA = "0x12F5614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38284", Offset = "0x38284")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		protected float clipLength
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x12F561C", Offset = "0x12F561C", VA = "0x12F561C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38294", Offset = "0x38294")]
			get
			{
				return default;
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x12F5624", Offset = "0x12F5624", VA = "0x12F5624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x382A4", Offset = "0x382A4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x12F54DC", Offset = "0x12F54DC", VA = "0x12F54DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38174", Offset = "0x38174")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x12F5524", Offset = "0x12F5524", VA = "0x12F5524")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x381AC", Offset = "0x381AC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x12F556C", Offset = "0x12F556C", VA = "0x12F556C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x381E4", Offset = "0x381E4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x12F55B4", Offset = "0x12F55B4", VA = "0x12F55B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3821C", Offset = "0x3821C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000558")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000559")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x600055A")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x600055B")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x600055C")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x12F562C", Offset = "0x12F562C", VA = "0x12F562C")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x12F5630", Offset = "0x12F5630", VA = "0x12F5630")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x12F5634", Offset = "0x12F5634", VA = "0x12F5634")]
		protected Baker()
		{
		}
	}
}
