using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D95")]
[Attribute(Name = "RequireComponent", RVA = "0x44B18", Offset = "0x44B18")]
public class LaserTargetEvent : MonoBehaviour
{
	[Token(Token = "0x40049F1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UnityEvent _OnLasered;

	[Token(Token = "0x6003FDC")]
	[Address(RVA = "0x151E77C", Offset = "0x151E77C", VA = "0x151E77C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003FDD")]
	[Address(RVA = "0x151E8A0", Offset = "0x151E8A0", VA = "0x151E8A0")]
	private void OnLasered()
	{
	}

	[Token(Token = "0x6003FDE")]
	[Address(RVA = "0x151E964", Offset = "0x151E964", VA = "0x151E964")]
	public LaserTargetEvent()
	{
	}
}
