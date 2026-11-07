using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Cinemachine
{
	[Token(Token = "0x200002F")]
	[ExecuteAlways]
	public class CinemachineStoryboard : CinemachineExtension
	{
		[Token(Token = "0x2000030")]
		public enum FillStrategy
		{
			[Token(Token = "0x4000100")]
			BestFit = 0,
			[Token(Token = "0x4000101")]
			CropImageToFit = 1,
			[Token(Token = "0x4000102")]
			StretchToFit = 2
		}

		[Token(Token = "0x2000031")]
		private class CanvasInfo
		{
			[Token(Token = "0x4000103")]
			[FieldOffset(Offset = "0x10")]
			public GameObject mCanvas;

			[Token(Token = "0x4000104")]
			[FieldOffset(Offset = "0x18")]
			public CinemachineBrain mCanvasParent;

			[Token(Token = "0x4000105")]
			[FieldOffset(Offset = "0x20")]
			public RectTransform mViewport;

			[Token(Token = "0x4000106")]
			[FieldOffset(Offset = "0x28")]
			public RawImage mRawImage;

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1911A64", Offset = "0x1911A64", VA = "0x1911A64")]
			public CanvasInfo()
			{
			}
		}

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x0")]
		public static bool s_StoryboardGlobalMute;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x28")]
		public bool m_ShowImage;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x30")]
		public Texture m_Image;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x38")]
		public FillStrategy m_Aspect;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x786E0", Offset = "0x786E0")]
		public float m_Alpha;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 m_Center;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 m_Rotation;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x54")]
		public Vector2 m_Scale;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x5C")]
		public bool m_SyncScale;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x5D")]
		public bool m_MuteCamera;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RangeAttribute", RVA = "0x786F8", Offset = "0x786F8")]
		public float m_SplitView;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x68")]
		private List<CanvasInfo> mCanvasInfo;

		[Token(Token = "0x1700003E")]
		private string CanvasName
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x19010DC", Offset = "0x19010DC", VA = "0x19010DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1900C34", Offset = "0x1900C34", VA = "0x1900C34", Slot = "7")]
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float wipeAmountTime)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1900D30", Offset = "0x1900D30", VA = "0x1900D30", Slot = "6")]
		protected override void ConnectToVcam(bool connect)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x190116C", Offset = "0x190116C", VA = "0x190116C")]
		private void CameraUpdatedCallback(CinemachineBrain brain)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1901370", Offset = "0x1901370", VA = "0x1901370")]
		private CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1901738", Offset = "0x1901738", VA = "0x1901738")]
		private void CreateCanvas(CanvasInfo ci)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1900ECC", Offset = "0x1900ECC", VA = "0x1900ECC")]
		private void DestroyCanvas()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1901B20", Offset = "0x1901B20", VA = "0x1901B20")]
		private void PlaceImage(CanvasInfo ci, float alpha)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x19020BC", Offset = "0x19020BC", VA = "0x19020BC")]
		private static void StaticBlendingHandler(CinemachineBrain brain)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1902300", Offset = "0x1902300", VA = "0x1902300")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x795C8", Offset = "0x795C8")]
		private static void InitializeModule()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1902444", Offset = "0x1902444", VA = "0x1902444")]
		public CinemachineStoryboard()
		{
		}
	}
}
