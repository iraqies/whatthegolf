using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002AB")]
public class PlayAgainOLNews : MonoBehaviour
{
	[Token(Token = "0x4000E3E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform container;

	[Token(Token = "0x4000E3F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform content;

	[Token(Token = "0x4000E40")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float scrollSpeed;

	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 originalPos;

	[Token(Token = "0x4000E42")]
	[FieldOffset(Offset = "0x38")]
	public float startX;

	[Token(Token = "0x4000E43")]
	[FieldOffset(Offset = "0x3C")]
	public float endX;

	[Token(Token = "0x4000E44")]
	[FieldOffset(Offset = "0x40")]
	public float enabledTime;

	[Token(Token = "0x4000E45")]
	[FieldOffset(Offset = "0x44")]
	public float t;

	[Token(Token = "0x4000E46")]
	[FieldOffset(Offset = "0x48")]
	private bool initialized;

	[Token(Token = "0x4000E47")]
	[FieldOffset(Offset = "0x4C")]
	public float randomOffset;

	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x15E8BF4", Offset = "0x15E8BF4", VA = "0x15E8BF4")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x15E8C34", Offset = "0x15E8C34", VA = "0x15E8C34")]
	private void CalculateScrollRange()
	{
	}

	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x15E8D28", Offset = "0x15E8D28", VA = "0x15E8D28")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000C43")]
	[Address(RVA = "0x15E8E50", Offset = "0x15E8E50", VA = "0x15E8E50")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x15E8DB0", Offset = "0x15E8DB0", VA = "0x15E8DB0")]
	private void CalculateScrollPosition()
	{
	}

	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x15E8E54", Offset = "0x15E8E54", VA = "0x15E8E54")]
	public PlayAgainOLNews()
	{
	}
}
