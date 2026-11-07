using System;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EA8")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x451B8", Offset = "0x451B8")]
[ExecuteInEditMode]
public class SetCinemachinePathFromPoints : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000EA9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45230", Offset = "0x45230")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004F2E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004F2F")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Vector3, CinemachineSmoothPath.Waypoint> _003C_003E9__3_0;

		[Token(Token = "0x6004472")]
		[Address(RVA = "0x1842C08", Offset = "0x1842C08", VA = "0x1842C08")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6004473")]
		[Address(RVA = "0x1842C10", Offset = "0x1842C10", VA = "0x1842C10")]
		internal CinemachineSmoothPath.Waypoint _003CUpdate_003Eb__3_0(Vector3 p)
		{
			return default;
		}
	}

	[Token(Token = "0x4004F2C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform PointContainer;

	[Token(Token = "0x4004F2D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool UpdatePath;

	[Token(Token = "0x600446F")]
	[Address(RVA = "0x168C7B8", Offset = "0x168C7B8", VA = "0x168C7B8")]
	private void Update()
	{
	}

	[Token(Token = "0x6004470")]
	[Address(RVA = "0x168C97C", Offset = "0x168C97C", VA = "0x168C97C")]
	public SetCinemachinePathFromPoints()
	{
	}
}
