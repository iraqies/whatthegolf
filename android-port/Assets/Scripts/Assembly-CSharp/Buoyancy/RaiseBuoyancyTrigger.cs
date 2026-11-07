using Il2CppDummyDll;
using UnityEngine;

namespace Buoyancy
{
	[Token(Token = "0x20011E4")]
	[Attribute(Name = "RequireComponent", RVA = "0x482AC", Offset = "0x482AC")]
	public class RaiseBuoyancyTrigger : MonoBehaviour
	{
		[Token(Token = "0x4006016")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float minPositionY;

		[Token(Token = "0x4006017")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float maxPositionY;

		[Token(Token = "0x4006018")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float maxAccumulatedMass;

		[Token(Token = "0x4006019")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float smoothTime;

		[Token(Token = "0x400601A")]
		[FieldOffset(Offset = "0x28")]
		private float targetSurfacePositionY;

		[Token(Token = "0x400601B")]
		[FieldOffset(Offset = "0x2C")]
		private float currentRaiseVelocityY;

		[Token(Token = "0x400601C")]
		[FieldOffset(Offset = "0x30")]
		private BuoyancyTrigger water;

		[Token(Token = "0x400601D")]
		[FieldOffset(Offset = "0x38")]
		private Transform _transform;

		[Token(Token = "0x60051D7")]
		[Address(RVA = "0x163EEE0", Offset = "0x163EEE0", VA = "0x163EEE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60051D8")]
		[Address(RVA = "0x163F07C", Offset = "0x163F07C", VA = "0x163F07C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60051D9")]
		[Address(RVA = "0x163F038", Offset = "0x163F038", VA = "0x163F038")]
		private void SetNewSurfacePosition()
		{
		}

		[Token(Token = "0x60051DA")]
		[Address(RVA = "0x163F10C", Offset = "0x163F10C", VA = "0x163F10C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60051DB")]
		[Address(RVA = "0x163F208", Offset = "0x163F208", VA = "0x163F208")]
		public RaiseBuoyancyTrigger()
		{
		}

		[Token(Token = "0x60051DC")]
		[Address(RVA = "0x163F224", Offset = "0x163F224", VA = "0x163F224")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70638", Offset = "0x70638")]
		private void _003CAwake_003Eb__8_0(IBuoyant v)
		{
		}

		[Token(Token = "0x60051DD")]
		[Address(RVA = "0x163F268", Offset = "0x163F268", VA = "0x163F268")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70648", Offset = "0x70648")]
		private void _003CAwake_003Eb__8_1(IBuoyant v)
		{
		}
	}
}
