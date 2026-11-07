using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E2D")]
public class ShapeRequired : MonoBehaviour
{
	[Token(Token = "0x4004CE2")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnUnlock;

	[Token(Token = "0x4004CE3")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent OnCorrectShape;

	[Token(Token = "0x4004CE4")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent OnWrongShape;

	[Token(Token = "0x4004CE5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool m_checkForShapeOnUpdate;

	[Token(Token = "0x4004CE6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ShapeShifterBehaviour m_shapeShifterToCheck;

	[Token(Token = "0x4004CE7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<GameObject> m_shapesAccepted;

	[Token(Token = "0x4004CE8")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_lastShapeEvaluated;

	[Token(Token = "0x600427B")]
	[Address(RVA = "0x169D6B8", Offset = "0x169D6B8", VA = "0x169D6B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600427C")]
	[Address(RVA = "0x169D810", Offset = "0x169D810", VA = "0x169D810")]
	public void EvaluateShape(GameObject playerShape)
	{
	}

	[Token(Token = "0x600427D")]
	[Address(RVA = "0x169D898", Offset = "0x169D898", VA = "0x169D898")]
	public ShapeRequired()
	{
	}
}
