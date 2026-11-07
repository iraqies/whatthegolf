using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008E6")]
public class StatisticsWordOrder : MonoBehaviour
{
	[Token(Token = "0x40030BC")]
	[FieldOffset(Offset = "0x18")]
	private bool isRightToLeft;

	[Token(Token = "0x40030BD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Complete;

	[Token(Token = "0x40030BE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Playtime;

	[Token(Token = "0x40030BF")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Strokes;

	[Token(Token = "0x6002931")]
	[Address(RVA = "0x16DDAB8", Offset = "0x16DDAB8", VA = "0x16DDAB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6002932")]
	[Address(RVA = "0x16DDBE0", Offset = "0x16DDBE0", VA = "0x16DDBE0")]
	public void UpdateOrder(string language)
	{
	}

	[Token(Token = "0x6002933")]
	[Address(RVA = "0x16DDD20", Offset = "0x16DDD20", VA = "0x16DDD20")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6002934")]
	[Address(RVA = "0x16DDE34", Offset = "0x16DDE34", VA = "0x16DDE34")]
	public StatisticsWordOrder()
	{
	}
}
