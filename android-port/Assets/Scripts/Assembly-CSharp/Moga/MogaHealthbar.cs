using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Moga
{
	[Token(Token = "0x20010D1")]
	public class MogaHealthbar : MonoBehaviour
	{
		[Token(Token = "0x4005899")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform healthBarContainer;

		[Token(Token = "0x400589A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image healthBar;

		[Token(Token = "0x400589B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float healthBarSizeMod;

		[Token(Token = "0x400589C")]
		[FieldOffset(Offset = "0x30")]
		private MogaEntity entity;

		[Token(Token = "0x6004B53")]
		[Address(RVA = "0x156C6E0", Offset = "0x156C6E0", VA = "0x156C6E0")]
		public void SetEntityInfo(MogaEntity entity)
		{
		}

		[Token(Token = "0x6004B54")]
		[Address(RVA = "0x156C574", Offset = "0x156C574", VA = "0x156C574")]
		public void UpdateHealthbar()
		{
		}

		[Token(Token = "0x6004B55")]
		[Address(RVA = "0x156C754", Offset = "0x156C754", VA = "0x156C754")]
		public MogaHealthbar()
		{
		}
	}
}
