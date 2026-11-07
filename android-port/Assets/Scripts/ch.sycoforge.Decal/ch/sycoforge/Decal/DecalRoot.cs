using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x200000E")]
	[ExecuteInEditMode]
	public class DecalRoot : DecalBase
	{
		[Token(Token = "0x400004A")]
		private const string DIFFUSEBUFFER_RT0 = "_DiffuseAOBuffer";

		[Token(Token = "0x400004B")]
		private const string SPECSMOOTHBUFFER_RT1 = "_SpecSmoothBuffer";

		[Token(Token = "0x400004C")]
		private const string NORMALBUFFER_RT2 = "_NormalBuffer";

		[Token(Token = "0x400004D")]
		private const string LIGTHINGEMISSION_RT2 = "_LightingEmissionBuffer";

		[Token(Token = "0x400004E")]
		private const string SCENECAMERA = "SceneCamera";

		[Token(Token = "0x400004F")]
		private const FilterMode filterMode = FilterMode.Point;

		[Token(Token = "0x4000050")]
		private const string CMDBUFFER = "Easy Decals";

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x178")]
		private Dictionary<Camera, CommandBuffer> cameraBuffers;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x180")]
		private Dictionary<Camera, RenderCamera> cameras;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x188")]
		private readonly CameraEvent evt;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x18C")]
		private int diffuseBufferID;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x190")]
		private int specSmoothBufferID;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x194")]
		private int normalsBufferID;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x198")]
		private int ligthingEmissionBufferID;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x1A0")]
		private Camera SceneCamera;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B90C", Offset = "0x20B90C")]
		private static Predicate<CommandBuffer> CS_0024_003C_003E9__CachedAnonymousMethodDelegate2;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B91C", Offset = "0x20B91C")]
		private static Predicate<CommandBuffer> CS_0024_003C_003E9__CachedAnonymousMethodDelegate3;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2C5C1F8", Offset = "0x2C5C1F8", VA = "0x2C5C1F8", Slot = "10")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2C5C2D0", Offset = "0x2C5C2D0", VA = "0x2C5C2D0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2C5C408", Offset = "0x2C5C408", VA = "0x2C5C408", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2C5C444", Offset = "0x2C5C444", VA = "0x2C5C444", Slot = "6")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2C5C608", Offset = "0x2C5C608", VA = "0x2C5C608")]
		private void OnRenderCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2C5CF7C", Offset = "0x2C5CF7C", VA = "0x2C5CF7C")]
		private void OnRenderObject()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2C5CF80", Offset = "0x2C5CF80", VA = "0x2C5CF80")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2C5C7C0", Offset = "0x2C5C7C0", VA = "0x2C5C7C0")]
		private void RenderDecals(RenderCamera cam)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2C5D654", Offset = "0x2C5D654", VA = "0x2C5D654")]
		private bool IsSceneCamera(Camera camera)
		{
			return default;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2C5D774", Offset = "0x2C5D774", VA = "0x2C5D774", Slot = "15")]
		protected override void InitalizeProjector()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2C5CF84", Offset = "0x2C5CF84", VA = "0x2C5CF84")]
		private CommandBuffer GetBuffer(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2C5D778", Offset = "0x2C5D778", VA = "0x2C5D778")]
		public DecalRoot()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2C5D86C", Offset = "0x2C5D86C", VA = "0x2C5D86C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BD6C", Offset = "0x20BD6C")]
		private static bool _003CGetBuffer_003Eb__0(CommandBuffer p)
		{
			return default;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2C5D8D0", Offset = "0x2C5D8D0", VA = "0x2C5D8D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BD7C", Offset = "0x20BD7C")]
		private static bool _003CGetBuffer_003Eb__1(CommandBuffer p)
		{
			return default;
		}
	}
}
