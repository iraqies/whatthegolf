using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ghost
{
	[Serializable]
	[Token(Token = "0x20010F1")]
	public class GolfGhostDataPoint
	{
		[Token(Token = "0x400593A")]
		[FieldOffset(Offset = "0x10")]
		public float Time;

		[Token(Token = "0x400593B")]
		[FieldOffset(Offset = "0x14")]
		public Vector3Serializer _position;

		[Token(Token = "0x400593C")]
		[FieldOffset(Offset = "0x30")]
		public QuaternionSerializer _rotation;

		[Token(Token = "0x17000804")]
		public Vector3 Position
		{
			[Token(Token = "0x6004BCD")]
			[Address(RVA = "0x149F1EC", Offset = "0x149F1EC", VA = "0x149F1EC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000805")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6004BCE")]
			[Address(RVA = "0x149F1F8", Offset = "0x149F1F8", VA = "0x149F1F8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004BCF")]
		[Address(RVA = "0x149F204", Offset = "0x149F204", VA = "0x149F204")]
		public GolfGhostDataPoint(float time, Vector3 position, Quaternion rotation)
		{
		}
	}
}
