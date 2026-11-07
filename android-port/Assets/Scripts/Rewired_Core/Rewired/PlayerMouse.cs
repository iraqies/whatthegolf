using System;
using Rewired.UI;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	public sealed class PlayerMouse : PlayerController, IPlayerController, IMouseInputSource
	{
		public new sealed class Definition : PlayerController.Definition
		{
			public bool defaultToCenter;

			public bool clampToMovementArea;

			public ScreenRect movementArea;

			public MovementAreaUnit movementAreaUnit;

			public float pointerSpeed;

			public bool useHardwarePointerPosition;

			internal Definition()
			{
			}
		}

		public new static class Factory
		{
			public static PlayerMouse Create()
			{
				return null;
			}

			private static PlayerMouse lOzmglNwrCkddSvkHTjSvLufiURJ(int P_0, int P_1)
			{
				return null;
			}

			public static PlayerMouse Create(Definition definition)
			{
				return null;
			}
		}

		public enum MovementAreaUnit
		{
			Screen = 0,
			Pixel = 1
		}

		[Serializable]
		private sealed class OSlalNkQgdyCxwlOJLXPaRyIfeNGb
		{
			public static readonly OSlalNkQgdyCxwlOJLXPaRyIfeNGb _003C_003E9;

			public static Predicate<Axis> _003C_003E9__18_0;

			public static Predicate<Axis> _003C_003E9__18_1;

			internal bool puHFbMbZKRgRrEHnPuZHpJpqxAWQ(Axis P_0)
			{
				return false;
			}

			internal bool REKreJAUTcsuDTPasfcxGOWTYUPN(Axis P_0)
			{
				return false;
			}
		}

		internal const bool crtgmFtaoxGkFJALkMneypaJfbiyA = true;

		internal const float MMQMoBURzBdZBfOjtcIkfEfkHrEOb = 1f;

		internal const bool LzflEobrLLpTJphRiJMslgKKQqtW = true;

		internal const bool UaubgkjmjCUdjbSqoBxQcCBeFCzaA = true;

		internal const MovementAreaUnit fWjLMXkdMrbVvorEgceTaczTnnaCA = MovementAreaUnit.Screen;

		internal static readonly ScreenRect fIHmOZwdmcjhhxjckEtHRKVcffPV;

		private const int SJoqyEGVJCuGrikQRqLOaiOnfzEy = 3;

		private const int GUNBIxEurJSTmnKyGWDLWunVbhacb = 3;

		internal const string UBEwMPhRyWhgjZfJODajRYTkhJxs = "Movement";

		internal const string lVzfbDHjIdsxijlEtVFXCigxqwNcA = "Horizontal";

		internal const string UCSlGWzkwqjaLupizGIniUHJEIdaA = "Vertical";

		internal const string YLFBHELRKskAimMMrrXAfAyFFpmKA = "Wheel";

		internal const string dDrOhokZbajufyoDftYgXqwWJoVn = "Wheel Horizontal";

		internal const string afSeorwduFlbtHKKNjdxQHAhqnTD = "Wheel Vertical";

		internal const string nhUJEDdiQsIbcGpOsANfefKxnMRT = "Left Button";

		internal const string qWQgTKqBQhGnlAHZJvMzvUPiGZsRA = "Right Button";

		internal const string MwHiTwfJjckLcVTHAoDvFCfriYBE = "Middle Button";

		private readonly int hxwwgxFnUtCslUpZOgPZCzFqFiqTA;

		private readonly int DfEbwMtWVLWsSBqreuwzeVrQSwSl;

		private readonly int vNbVHcuTotuEFGaawHzjVdfyCmuy;

		private readonly int fDcRizljsZXtisTJjJvDCnfVRvUD;

		private readonly int TxNNxPSzkkcdkUCsYUxErSslcylE;

		private readonly int CLpkKlcRLHDYaVHsUTnEbULSfghR;

		private bool fyHlDWcNNzDNgJlSyUKoyrsWGWGe;

		private Vector2 oxrDIMticzxeKaxrOYeUhCepuoyF;

		private Vector2 pplLsqMoYgzVgPCIqghiiSHWqzGt;

		private Vector2 JHlQdvIDknwhbpDkONoyRzgqysDj;

		private Vector2 NNeHrvYGutiOIXhlhFaJfwMWTlqw;

		private Vector2 QBcPXjdeXZuzabhNCsEDWKxPBdte;

		private float GDHSElRvsGdWdBmtMLHmEKBiKTpC;

		private bool HdRGQgJBdNkpNiMbgdWNiHTQRrDaB;

		private Action<Vector2> rnnZqqYfwFdqnJnqPRsOnSOuchohb;

		private bool mBgpERXzEyTjbWeGHFvSbaUoJveW;

		private ScreenRect jJwbONnbKvXKWbnpYndOAguJcFwjA;

		private bool plrzNanNFfWnyYQasrBNsxGHRJzg;

		private MovementAreaUnit GmCwmKihHCIrRGKDcEPfvjNWacpx;

		public bool defaultToCenter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool clampToMovementArea
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ScreenRect movementArea
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public MovementAreaUnit movementAreaUnit
		{
			get
			{
				return MovementAreaUnit.Screen;
			}
			set
			{
			}
		}

		public Vector2 screenPosition
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector2 screenPositionPrev => default;

		public Vector2 screenPositionDelta => default;

		public MouseAxis xAxis => null;

		public MouseAxis yAxis => null;

		public MouseWheel wheel => null;

		public Button leftButton => null;

		public Button rightButton => null;

		public Button middleButton => null;

		public float pointerSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useHardwarePointerPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool IMouseInputSource.enabled => false;

		Vector2 IMouseInputSource.screenPosition => default;

		Vector2 IMouseInputSource.screenPositionDelta => default;

		Vector2 IMouseInputSource.wheelDelta => default;

		bool IMouseInputSource.locked => false;

		public event Action<Vector2> ScreenPositionChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private PlayerMouse(Definition P_0)
			: base(null)
		{
		}

		protected override bool Update(UpdateLoopType updateLoop)
		{
			return false;
		}

		protected override void UpdateFinished()
		{
		}

		protected override void ClearVars()
		{
		}

		private void vtzxdsmrfDcFGyGcdkIRsgZqTqgO(Vector2 P_0)
		{
		}

		private ScreenRect NPAuUJFLGVUbDGIXwfwBXFKraBmJ()
		{
			return default;
		}

		private void PBiXClCdYpXIpnoPsGXhDsFMbZNGb()
		{
		}

		private static float kRkyQqefvvPbnHhOJTSOYsKxiTXc(Axis P_0, float P_1, float P_2)
		{
			return 0f;
		}

		bool IMouseInputSource.GetButtonDown(int button)
		{
			return false;
		}

		bool IMouseInputSource.GetButtonUp(int button)
		{
			return false;
		}

		bool IMouseInputSource.GetButton(int button)
		{
			return false;
		}
	}
}
