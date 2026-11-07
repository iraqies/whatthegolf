using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001F5")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000D33")]
		[FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000D35")]
		[FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000D36")]
		[FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000D37")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000D38")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x1368668", Offset = "0x1368668", VA = "0x1368668")]
		private void Start()
		{
		}

		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x136870C", Offset = "0x136870C", VA = "0x136870C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x1368A7C", Offset = "0x1368A7C", VA = "0x1368A7C")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x1368B28", Offset = "0x1368B28", VA = "0x1368B28")]
		public ExplosionDemo()
		{
		}
	}
}
