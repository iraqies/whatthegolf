using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GolfCourse
{
	[Token(Token = "0x2001208")]
	public class GolfCourse2DPinGoal : MonoBehaviour
	{
		[Token(Token = "0x400614C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string winMessage;

		[Token(Token = "0x400614D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float delay;

		[Token(Token = "0x400614E")]
		[FieldOffset(Offset = "0x24")]
		public int RequiredBallsInGoal;

		[Token(Token = "0x400614F")]
		[FieldOffset(Offset = "0x28")]
		public bool DontAcceptController;

		[Token(Token = "0x4006150")]
		[FieldOffset(Offset = "0x30")]
		private List<Transform> golfBallsInGoal;

		[Token(Token = "0x4006151")]
		[FieldOffset(Offset = "0x38")]
		private List<int> playersInGoal;

		[Token(Token = "0x4006152")]
		[FieldOffset(Offset = "0x40")]
		private int ballsInGoal;

		[Token(Token = "0x4006153")]
		[FieldOffset(Offset = "0x48")]
		private GolfGoal golfgoal;

		[Token(Token = "0x60052EB")]
		[Address(RVA = "0x149DD4C", Offset = "0x149DD4C", VA = "0x149DD4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60052EC")]
		[Address(RVA = "0x149DE38", Offset = "0x149DE38", VA = "0x149DE38")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60052ED")]
		[Address(RVA = "0x149E27C", Offset = "0x149E27C", VA = "0x149E27C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60052EE")]
		[Address(RVA = "0x149E2B4", Offset = "0x149E2B4", VA = "0x149E2B4")]
		public void AddBall()
		{
		}

		[Token(Token = "0x60052EF")]
		[Address(RVA = "0x149DE70", Offset = "0x149DE70", VA = "0x149DE70")]
		public void CheckObject(Transform trans)
		{
		}

		[Token(Token = "0x60052F0")]
		[Address(RVA = "0x149E3EC", Offset = "0x149E3EC", VA = "0x149E3EC")]
		public GolfCourse2DPinGoal()
		{
		}
	}
}
