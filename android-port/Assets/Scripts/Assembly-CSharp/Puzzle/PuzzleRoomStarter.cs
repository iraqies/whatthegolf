using System.Collections.Generic;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x200103C")]
	[Attribute(Name = "RequireComponent", RVA = "0x4766C", Offset = "0x4766C")]
	public class PuzzleRoomStarter : GolfBehaviour
	{
		[Token(Token = "0x4005597")]
		[FieldOffset(Offset = "0x20")]
		private Collider2D col;

		[Token(Token = "0x4005598")]
		[FieldOffset(Offset = "0x28")]
		private List<ITimedPuzzleObject> timedObjectsInArea;

		[Token(Token = "0x4005599")]
		[FieldOffset(Offset = "0x30")]
		private List<PuzzleObjectBase> allPuzzleObjects;

		[Token(Token = "0x400559A")]
		[FieldOffset(Offset = "0x38")]
		private OverworldCamera cam;

		[Token(Token = "0x400559B")]
		[FieldOffset(Offset = "0x40")]
		private OverworldBall2D overworldBall;

		[Token(Token = "0x400559C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CBOverworldRoomStatic camBehavior;

		[Token(Token = "0x400559D")]
		[FieldOffset(Offset = "0x50")]
		private Vector2 lastPointOfEntry;

		[Token(Token = "0x400559E")]
		[FieldOffset(Offset = "0x58")]
		public Transform startPoint;

		[Token(Token = "0x400559F")]
		[FieldOffset(Offset = "0x60")]
		public PhysicsMaterial2D originalMaterial;

		[Token(Token = "0x40055A0")]
		[FieldOffset(Offset = "0x68")]
		public PhysicsMaterial2D ballMaterialInPuzzle;

		[Token(Token = "0x40055A1")]
		[FieldOffset(Offset = "0x70")]
		public bool useStaticCamera;

		[Token(Token = "0x40055A2")]
		[FieldOffset(Offset = "0x71")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x55590", Offset = "0x55590")]
		private bool HasInitialized__BackingField;

		[Token(Token = "0x40055A3")]
		[FieldOffset(Offset = "0x72")]
		public bool isActive;

		[Token(Token = "0x170007AF")]
		public Vector2 GetStartPoint
		{
			[Token(Token = "0x60048C5")]
			[Address(RVA = "0x16306B8", Offset = "0x16306B8", VA = "0x16306B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170007B0")]
		public bool HasInitialized
		{
			[Token(Token = "0x60048C6")]
			[Address(RVA = "0x1630758", Offset = "0x1630758", VA = "0x1630758")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F084", Offset = "0x6F084")]
			get
			{
				return default;
			}
			[Token(Token = "0x60048C7")]
			[Address(RVA = "0x1630760", Offset = "0x1630760", VA = "0x1630760")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F094", Offset = "0x6F094")]
			private set
			{
			}
		}

		[Token(Token = "0x60048C8")]
		[Address(RVA = "0x1630768", Offset = "0x1630768", VA = "0x1630768", Slot = "4")]
		public override void OnPrePlayOrPreCompile()
		{
		}

		[Token(Token = "0x60048C9")]
		[Address(RVA = "0x16307D0", Offset = "0x16307D0", VA = "0x16307D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60048CA")]
		[Address(RVA = "0x1630AAC", Offset = "0x1630AAC", VA = "0x1630AAC")]
		private void Update()
		{
		}

		[Token(Token = "0x60048CB")]
		[Address(RVA = "0x1630BC8", Offset = "0x1630BC8", VA = "0x1630BC8")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		[Token(Token = "0x60048CC")]
		[Address(RVA = "0x1630F5C", Offset = "0x1630F5C", VA = "0x1630F5C")]
		private void OnTriggerExit2D(Collider2D collision)
		{
		}

		[Token(Token = "0x60048CD")]
		[Address(RVA = "0x16310C8", Offset = "0x16310C8", VA = "0x16310C8")]
		public PuzzleRoomStarter()
		{
		}
	}
}
