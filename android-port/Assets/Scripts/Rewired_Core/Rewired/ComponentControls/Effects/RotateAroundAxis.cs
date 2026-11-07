using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.ComponentControls.Effects
{
	[Token(Token = "0x200030A")]
	public class RotateAroundAxis : MonoBehaviour
	{
		[Token(Token = "0x200030B")]
		public enum Speed
		{
			[Token(Token = "0x4001000")]
			Stopped = 0,
			[Token(Token = "0x4001001")]
			Slow = 1,
			[Token(Token = "0x4001002")]
			Fast = 2
		}

		[Token(Token = "0x200030C")]
		public enum RotationAxis
		{
			[Token(Token = "0x4001004")]
			X = 0,
			[Token(Token = "0x4001005")]
			Y = 1,
			[Token(Token = "0x4001006")]
			Z = 2
		}

		[Token(Token = "0x4000FF9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Speed _speed;

		[Token(Token = "0x4000FFA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _slowRotationSpeed;

		[Token(Token = "0x4000FFB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fastRotationSpeed;

		[Token(Token = "0x4000FFC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RotationAxis _rotateAroundAxis;

		[Token(Token = "0x4000FFD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Space _relativeTo;

		[Token(Token = "0x4000FFE")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _reverse;

		[Token(Token = "0x1700062B")]
		public Speed speed
		{
			[Token(Token = "0x6001730")]
			[Address(RVA = "0x2408DE4", Offset = "0x2408DE4", VA = "0x2408DE4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001731")]
			[Address(RVA = "0x2408DEC", Offset = "0x2408DEC", VA = "0x2408DEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700062C")]
		public float slowRotationSpeed
		{
			[Token(Token = "0x6001732")]
			[Address(RVA = "0x2408DF4", Offset = "0x2408DF4", VA = "0x2408DF4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001733")]
			[Address(RVA = "0x2408DFC", Offset = "0x2408DFC", VA = "0x2408DFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700062D")]
		public float fastRotationSpeed
		{
			[Token(Token = "0x6001734")]
			[Address(RVA = "0x2408E04", Offset = "0x2408E04", VA = "0x2408E04")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001735")]
			[Address(RVA = "0x2408E0C", Offset = "0x2408E0C", VA = "0x2408E0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700062E")]
		public RotationAxis rotateAroundAxis
		{
			[Token(Token = "0x6001736")]
			[Address(RVA = "0x2408E14", Offset = "0x2408E14", VA = "0x2408E14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001737")]
			[Address(RVA = "0x2408E1C", Offset = "0x2408E1C", VA = "0x2408E1C")]
			set
			{
			}
		}

		[Token(Token = "0x1700062F")]
		public Space relativeTo
		{
			[Token(Token = "0x6001738")]
			[Address(RVA = "0x2408E24", Offset = "0x2408E24", VA = "0x2408E24")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001739")]
			[Address(RVA = "0x2408E2C", Offset = "0x2408E2C", VA = "0x2408E2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000630")]
		public bool reverse
		{
			[Token(Token = "0x600173A")]
			[Address(RVA = "0x2408E34", Offset = "0x2408E34", VA = "0x2408E34")]
			get
			{
				return default;
			}
			[Token(Token = "0x600173B")]
			[Address(RVA = "0x2408E3C", Offset = "0x2408E3C", VA = "0x2408E3C")]
			set
			{
			}
		}

		[Token(Token = "0x600173C")]
		[Address(RVA = "0x2408E44", Offset = "0x2408E44", VA = "0x2408E44")]
		private void Update()
		{
		}

		[Token(Token = "0x600173D")]
		[Address(RVA = "0x2408F08", Offset = "0x2408F08", VA = "0x2408F08")]
		private static Vector3 UBTdCMgMmDUkfQSXMUxOcULfkPYFA(RotationAxis P_0)
		{
			return default;
		}

		[Token(Token = "0x600173E")]
		[Address(RVA = "0x2408F98", Offset = "0x2408F98", VA = "0x2408F98")]
		public void SetSpeed(Speed speed)
		{
		}

		[Token(Token = "0x600173F")]
		[Address(RVA = "0x2408FA0", Offset = "0x2408FA0", VA = "0x2408FA0")]
		public void SetSpeed(int speed)
		{
		}

		[Token(Token = "0x6001740")]
		[Address(RVA = "0x24090B4", Offset = "0x24090B4", VA = "0x24090B4")]
		public RotateAroundAxis()
		{
		}
	}
}
