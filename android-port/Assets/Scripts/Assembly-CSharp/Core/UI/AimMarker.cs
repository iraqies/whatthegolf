using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Core.UI
{
	[Token(Token = "0x2001471")]
	public class AimMarker : MonoBehaviour
	{
		[Token(Token = "0x4007032")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 Up;

		[Token(Token = "0x4007033")]
		[FieldOffset(Offset = "0x28")]
		public Image Arrow;

		[Token(Token = "0x4007034")]
		[FieldOffset(Offset = "0x30")]
		public Image Circle;

		[Token(Token = "0x4007035")]
		[FieldOffset(Offset = "0x38")]
		public OverworldManager2d manager;

		[Token(Token = "0x4007036")]
		[FieldOffset(Offset = "0x40")]
		public OverworldBallManager ballManager;

		[Token(Token = "0x4007037")]
		[FieldOffset(Offset = "0x48")]
		private float DistanceToBallThreshold;

		[Token(Token = "0x4007038")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine routine;

		[Token(Token = "0x4007039")]
		[FieldOffset(Offset = "0x58")]
		private GolfBallController controller;

		[Token(Token = "0x6006058")]
		[Address(RVA = "0x140BC30", Offset = "0x140BC30", VA = "0x140BC30")]
		private void Start()
		{
		}

		[Token(Token = "0x6006059")]
		[Address(RVA = "0x140C2E4", Offset = "0x140C2E4", VA = "0x140C2E4")]
		private void OnLevelStarting(List<LevelData> levelDatas)
		{
		}

		[Token(Token = "0x600605A")]
		[Address(RVA = "0x140C334", Offset = "0x140C334", VA = "0x140C334")]
		public void OnGameStart(LevelData level)
		{
		}

		[Token(Token = "0x600605B")]
		[Address(RVA = "0x140C428", Offset = "0x140C428", VA = "0x140C428")]
		private void OnComplete(Level.CompletedState completedState)
		{
		}

		[Token(Token = "0x600605C")]
		[Address(RVA = "0x140C450", Offset = "0x140C450", VA = "0x140C450")]
		public void OnGameStop()
		{
		}

		[Token(Token = "0x600605D")]
		[Address(RVA = "0x140BF8C", Offset = "0x140BF8C", VA = "0x140BF8C")]
		public void SubscribeToController(GolfBallController newController)
		{
		}

		[Token(Token = "0x600605E")]
		[Address(RVA = "0x140C52C", Offset = "0x140C52C", VA = "0x140C52C")]
		public void UnsubscribeToController()
		{
		}

		[Token(Token = "0x600605F")]
		[Address(RVA = "0x140C7D0", Offset = "0x140C7D0", VA = "0x140C7D0")]
		private void OnAimUpdate(Vector3 boost, bool isCancelled)
		{
		}

		[Token(Token = "0x6006060")]
		[Address(RVA = "0x140CAE4", Offset = "0x140CAE4", VA = "0x140CAE4")]
		private void Show()
		{
		}

		[Token(Token = "0x6006061")]
		[Address(RVA = "0x140C30C", Offset = "0x140C30C", VA = "0x140C30C")]
		public void Hide()
		{
		}

		[Token(Token = "0x6006062")]
		[Address(RVA = "0x140CC38", Offset = "0x140CC38", VA = "0x140CC38")]
		private void Hide(Vector3 v)
		{
		}

		[Token(Token = "0x6006063")]
		[Address(RVA = "0x140CC60", Offset = "0x140CC60", VA = "0x140CC60")]
		private void Hide(string s)
		{
		}

		[Token(Token = "0x6006064")]
		[Address(RVA = "0x140CC88", Offset = "0x140CC88", VA = "0x140CC88")]
		public AimMarker()
		{
		}

		[Token(Token = "0x6006065")]
		[Address(RVA = "0x140CC9C", Offset = "0x140CC9C", VA = "0x140CC9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72F64", Offset = "0x72F64")]
		private void _003CStart_003Eb__8_0(Transmogrif.BALLSHAPES shape)
		{
		}

		[Token(Token = "0x6006066")]
		[Address(RVA = "0x140CD04", Offset = "0x140CD04", VA = "0x140CD04")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72F74", Offset = "0x72F74")]
		private void _003CShow_003Eb__16_0(float t)
		{
		}
	}
}
