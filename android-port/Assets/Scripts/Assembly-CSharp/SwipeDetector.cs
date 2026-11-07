using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20001BE")]
public class SwipeDetector : MonoBehaviour
{
	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x18")]
	public float swipeThreshold;

	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x1C")]
	public float timeThreshold;

	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x20")]
	public float degreesTreshold;

	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent onSwipeLeft;

	[Token(Token = "0x40007D0")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent onSwipeRight;

	[Token(Token = "0x40007D1")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent onSwipeUp;

	[Token(Token = "0x40007D2")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent onSwipeDown;

	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 _fingerDown;

	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x50")]
	private float _fingerDownTime;

	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0x54")]
	private Vector2 _fingerUp;

	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x5C")]
	private float _fingerUpTime;

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x16F4DBC", Offset = "0x16F4DBC", VA = "0x16F4DBC")]
	private void Update()
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x16F4E44", Offset = "0x16F4E44", VA = "0x16F4E44")]
	private void CheckSwipe()
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x16F52F8", Offset = "0x16F52F8", VA = "0x16F52F8")]
	public SwipeDetector()
	{
	}
}
