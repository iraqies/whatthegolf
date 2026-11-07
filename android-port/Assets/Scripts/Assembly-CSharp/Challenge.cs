using System;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20003FF")]
public abstract class Challenge : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000400")]
	public struct ChallengeUnityEvents
	{
		[Token(Token = "0x40015E5")]
		[FieldOffset(Offset = "0x0")]
		public UnityEvent OnChallengeActivated;

		[Token(Token = "0x40015E6")]
		[FieldOffset(Offset = "0x8")]
		public UnityEvent OnChallengeStart;

		[Token(Token = "0x40015E7")]
		[FieldOffset(Offset = "0x10")]
		public UnityEvent OnChallengeComplete;
	}

	[Serializable]
	[Token(Token = "0x2000401")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F9AC", Offset = "0x3F9AC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40015E8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40015E9")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__26_0;

		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x1782BB8", Offset = "0x1782BB8", VA = "0x1782BB8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x1782BC0", Offset = "0x1782BC0", VA = "0x1782BC0")]
		internal void _003CFailAfterTime_003Eb__26_0(float v)
		{
		}
	}

	[Token(Token = "0x40015D4")]
	[FieldOffset(Offset = "0x18")]
	public string ID;

	[Token(Token = "0x40015D5")]
	[FieldOffset(Offset = "0x20")]
	public string TitleLocalizationId;

	[Token(Token = "0x40015D6")]
	[FieldOffset(Offset = "0x28")]
	public string DescriptionLocalizationId;

	[Token(Token = "0x40015D7")]
	[FieldOffset(Offset = "0x30")]
	public ChallengeInfoIconSet IconDescription;

	[Token(Token = "0x40015D8")]
	[FieldOffset(Offset = "0x38")]
	public string WinMessageLocalizationId;

	[Token(Token = "0x40015D9")]
	[FieldOffset(Offset = "0x40")]
	public ChallengeUnityEvents UnityEvents;

	[Token(Token = "0x40015DA")]
	[FieldOffset(Offset = "0x58")]
	public bool ExitLevelOnComplete;

	[Token(Token = "0x40015DB")]
	[FieldOffset(Offset = "0x59")]
	public bool SetCameraTarget;

	[Token(Token = "0x40015DC")]
	[FieldOffset(Offset = "0x60")]
	public Sprite Icon;

	[Token(Token = "0x40015DD")]
	[FieldOffset(Offset = "0x68")]
	private Action<Challenge> onComplete;

	[Token(Token = "0x40015DE")]
	[FieldOffset(Offset = "0x70")]
	private Action<Challenge> onFailed;

	[Token(Token = "0x40015DF")]
	[FieldOffset(Offset = "0x78")]
	private bool hasBeenCompleted;

	[Token(Token = "0x40015E0")]
	[FieldOffset(Offset = "0x80")]
	public GameObject[] objectsToDeActivate;

	[Token(Token = "0x40015E1")]
	[FieldOffset(Offset = "0x88")]
	public CameraManager cameraManager;

	[Token(Token = "0x40015E2")]
	[FieldOffset(Offset = "0x90")]
	public CameraBehavior CustomCameraBehaviour;

	[Token(Token = "0x40015E3")]
	[FieldOffset(Offset = "0x98")]
	public CameraBehavior CustomDesktopOverrideBehaviour;

	[Token(Token = "0x40015E4")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D59C", Offset = "0x4D59C")]
	private bool hasBeenActivated__BackingField;

	[Token(Token = "0x17000226")]
	public bool hasBeenActivated
	{
		[Token(Token = "0x60012C7")]
		[Address(RVA = "0x18917B0", Offset = "0x18917B0", VA = "0x18917B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D6C", Offset = "0x61D6C")]
		get
		{
			return default;
		}
		[Token(Token = "0x60012C8")]
		[Address(RVA = "0x18917B8", Offset = "0x18917B8", VA = "0x18917B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D7C", Offset = "0x61D7C")]
		private set
		{
		}
	}

	[Token(Token = "0x60012C9")]
	[Address(RVA = "0x18917C0", Offset = "0x18917C0", VA = "0x18917C0", Slot = "4")]
	public virtual void Disable()
	{
	}

	[Token(Token = "0x60012CA")]
	[Address(RVA = "0x18917E8", Offset = "0x18917E8", VA = "0x18917E8", Slot = "5")]
	public virtual string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x60012CB")]
	[Address(RVA = "0x18918B0", Offset = "0x18918B0", VA = "0x18918B0", Slot = "6")]
	public virtual string GetWinMessageID()
	{
		return null;
	}

	[Token(Token = "0x60012CC")]
	[Address(RVA = "0x1891914", Offset = "0x1891914", VA = "0x1891914")]
	public void Activate(Action<Challenge> onComplete, Action<Challenge> onFailed)
	{
	}

	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x1891FF4", Offset = "0x1891FF4", VA = "0x1891FF4", Slot = "7")]
	public virtual void OnLevelFail(GolfBallController arg1, string arg2, Level.State arg3)
	{
	}

	[Token(Token = "0x60012CE")]
	[Address(RVA = "0x18920F4", Offset = "0x18920F4", VA = "0x18920F4")]
	public void FailAfterTime(float time)
	{
	}

	[Token(Token = "0x60012CF")]
	protected abstract void Activate();

	[Token(Token = "0x60012D0")]
	[Address(RVA = "0x18922A0", Offset = "0x18922A0", VA = "0x18922A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60012D1")]
	[Address(RVA = "0x18922BC", Offset = "0x18922BC", VA = "0x18922BC", Slot = "9")]
	protected virtual void ChallengeUpdate()
	{
	}

	[Token(Token = "0x60012D2")]
	[Address(RVA = "0x18922C0", Offset = "0x18922C0", VA = "0x18922C0")]
	public void Complete(float delay)
	{
	}

	[Token(Token = "0x60012D3")]
	[Address(RVA = "0x1892330", Offset = "0x1892330", VA = "0x1892330")]
	public void Complete()
	{
	}

	[Token(Token = "0x60012D4")]
	[Address(RVA = "0x1892424", Offset = "0x1892424", VA = "0x1892424", Slot = "10")]
	public virtual void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x60012D5")]
	[Address(RVA = "0x1892074", Offset = "0x1892074", VA = "0x1892074")]
	public void Fail()
	{
	}

	[Token(Token = "0x60012D6")]
	[Address(RVA = "0x18924A4", Offset = "0x18924A4", VA = "0x18924A4", Slot = "11")]
	public virtual void OnFail()
	{
	}

	[Token(Token = "0x60012D7")]
	[Address(RVA = "0x18924A8", Offset = "0x18924A8", VA = "0x18924A8")]
	protected Challenge()
	{
	}

	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x18924B8", Offset = "0x18924B8", VA = "0x18924B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D8C", Offset = "0x61D8C")]
	private void _003CFailAfterTime_003Eb__26_1()
	{
	}
}
