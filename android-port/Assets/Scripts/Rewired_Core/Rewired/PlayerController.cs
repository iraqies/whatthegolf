using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	public class PlayerController : IPlayerController
	{
		public class Definition
		{
			public bool enabled;

			public int playerId;

			public ICollection<Element.Definition> elements;
		}

		public static class Factory
		{
			public static PlayerController Create(Definition definition)
			{
				return null;
			}
		}

		public class Axis : ElementWithSource
		{
			public new class Definition : ElementWithSource.Definition
			{
				public AxisCoordinateMode coordinateMode;

				public float absoluteToRelativeSensitivity;

				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			internal const float tKzWjAAqFxznILFKHvHDMeAnaEtx = 1f;

			internal const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Absolute;

			private float kGpcICdBcebufqmYNGRRSLHNkiOb;

			private AxisCoordinateMode IuVzvlfMSigqbjOqXgvDBwRIIUCO;

			public float absoluteToRelativeSensitivity => 0f;

			public AxisCoordinateMode coordinateMode => AxisCoordinateMode.Absolute;

			public virtual float value => 0f;

			public virtual float valueRaw => 0f;

			internal Axis(PlayerController P_0, Definition P_1)
				: base(null, null)
			{
			}
		}

		public class MouseAxis : Axis
		{
			public new class Definition : Axis.Definition
			{
				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			public override float value => 0f;

			internal MouseAxis(PlayerController P_0, Definition P_1)
				: base(null, null)
			{
			}
		}

		public class Axis2D : CompoundElement
		{
			public new class Definition : CompoundElement.Definition
			{
				private Axis.Definition mQTUIoqEkWTkreeIZmWyMwdawBgc;

				private Axis.Definition mrWOIvlMbZydDUixWVKOhCmTyEYh;

				public Axis.Definition xAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public Axis.Definition yAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			public virtual Vector2 value => default;

			internal Axis2D(PlayerController P_0, Definition P_1, Element.Definition[] P_2)
				: base(null, null, null)
			{
			}

			internal Axis2D(PlayerController P_0, Definition P_1)
				: base(null, null, null)
			{
			}
		}

		public sealed class MouseAxis2D : Axis2D
		{
			public new class Definition : Axis2D.Definition
			{
				public new MouseAxis.Definition xAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public new MouseAxis.Definition yAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			internal MouseAxis2D(PlayerController P_0, Definition P_1)
				: base(null, null, null)
			{
			}
		}

		public sealed class Button : ElementWithSource
		{
			public new class Definition : ElementWithSource.Definition
			{
				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			public bool value => false;

			public bool justPressed => false;

			public bool justReleased => false;

			internal Button(PlayerController P_0, Definition P_1)
				: base(null, null)
			{
			}
		}

		public abstract class CompoundElement : Element
		{
			public new abstract class Definition : Element.Definition
			{
				public Definition()
				{
				}
			}

			private readonly List<Element> hObmyuQkxgNXDiBtSEwFNgLuBsoZ;

			internal CompoundElement(PlayerController P_0, Definition P_1, Element.Definition[] P_2)
				: base(null, null)
			{
			}

			internal _0001 pAGcyUYRwJwYiiycWKSARieMOZIo<_0001>(int P_0) where _0001 : Element
			{
				return null;
			}

			internal void yfvUZvCErrubvkdbzulBqRmKnLaT(List<Element> P_0)
			{
			}

			internal void JymOYvJCaUZfrfNvqSliYMwhgCGz(Element P_0)
			{
			}
		}

		public abstract class Element
		{
			internal enum Type
			{
				Button = 0,
				Axis = 1,
				MouseAxis = 2,
				MouseWheelAxis = 3,
				Axis2D = 100,
				MouseAxis2D = 101,
				MouseWheel = 102
			}

			internal enum TypeWithSource
			{
				Button = 0,
				Axis = 1,
				MouseAxis = 2,
				MouseWheelAxis = 3
			}

			public abstract class Definition
			{
				public bool enabled;

				public string name;

				public Definition()
				{
				}

				internal abstract Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0);
			}

			internal struct znbsAbXzumooNTekBhsPkirgaxEt
			{
				public ControllerElementType MdjBbHAfEpOIyysKWtDJwilBqwCjA;

				public int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

				public float yYOUbwIbBcyPAQvjeAEXVsjzLAln;

				public znbsAbXzumooNTekBhsPkirgaxEt(ControllerElementType P_0, int P_1, float P_2)
				{
					MdjBbHAfEpOIyysKWtDJwilBqwCjA = ControllerElementType.Axis;
					PqXTkiKXdxRLgXpucsKUqWEJhHUQ = 0;
					yYOUbwIbBcyPAQvjeAEXVsjzLAln = 0f;
				}
			}

			internal const bool defaultEnabled = true;

			private readonly PlayerController afWhZEYTbMFjMUeulVkAPjICyxpP;

			private bool ZVriljhasPxEFvNaLvNOVyfTIDdb;

			private bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

			private string hEJFspqWqeBOdedbqHNRpPNEbfBG;

			private static int[] qGbdMURwQUZeXFRbaUvBlTnHrsNF;

			private static int[] wmvCHfufqZIquHLzLpGHJPmzGeky;

			protected Player XAbNzJSvSNjTFwhnJridEdiVWtEM => get_player();

			protected bool ctlEdDGNREqipIotFsdpXzilehZXA => get_selfAndParentEnabled();

			internal bool RJWetIMScbNkkayUbJoRDyHMCesM
			{
				get
				{
					return QdilGKxwKBKOqAtsKaqAxEYSaqTP();
				}
				set
				{
					QogGjtbarFqmkKesqDXoceThdxAEA(value);
				}
			}

			public bool enabled
			{
				set
				{
				}
			}

			internal Element(PlayerController P_0, Definition P_1)
			{
			}

			protected Player get_player()
			{
				return null;
			}

			protected bool get_selfAndParentEnabled()
			{
				return false;
			}

			internal bool QdilGKxwKBKOqAtsKaqAxEYSaqTP()
			{
				return false;
			}

			internal void QogGjtbarFqmkKesqDXoceThdxAEA(bool P_0)
			{
			}

			internal virtual void jRaYtHNVcykNMAbqOnSGaKIIGSEaA()
			{
			}

			protected virtual void EnabledStateChanged(bool state)
			{
			}

			internal static Definition CreateDefinition(Type type)
			{
				return null;
			}
		}

		public abstract class ElementWithSource : Element
		{
			public new abstract class Definition : Element.Definition
			{
				private int JwOchbdvhsvHVdSyYjtqEJdTZzYG;

				public int actionId
				{
					get
					{
						return 0;
					}
					set
					{
					}
				}

				public Definition()
				{
				}
			}

			internal const int defaultActionId = -1;

			private int JwOchbdvhsvHVdSyYjtqEJdTZzYG;

			public int actionId => 0;

			public string actionName
			{
				set
				{
				}
			}

			internal ElementWithSource(PlayerController P_0, Definition P_1)
				: base(null, null)
			{
			}
		}

		public sealed class MouseWheel : Axis2D
		{
			public new class Definition : Axis2D.Definition
			{
				public new MouseWheelAxis.Definition xAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public new MouseWheelAxis.Definition yAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			public MouseWheelAxis yAxis => null;

			internal MouseWheel(PlayerController P_0, Definition P_1)
				: base(null, null, null)
			{
			}
		}

		public sealed class MouseWheelAxis : Axis
		{
			public new class Definition : Axis.Definition
			{
				public float repeatRate;

				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			private float YSkaBBhJiFXPXTRPaOUbCTlETpio;

			private double cGHxdUbOJdeKDTJHxDXvymTAxcnE;

			private float ckUkzuSDJGuJonmPceZrDLTKWbwc;

			public float repeatRate
			{
				set
				{
				}
			}

			public override float value => 0f;

			internal MouseWheelAxis(PlayerController P_0, Definition P_1)
				: base(null, null)
			{
			}

			internal override void jRaYtHNVcykNMAbqOnSGaKIIGSEaA()
			{
			}

			protected override void EnabledStateChanged(bool state)
			{
			}

			private float cnPMTOtfmVCjsekZygybCvfqRwyMA()
			{
				return 0f;
			}

			private void SPGTRPyvIslcMdbPTItsewSLRPxx()
			{
			}
		}

		internal readonly int QajDFFaomlkLHzaostfWYpGUioys;

		private bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

		private int DCGJXzigEdTcwzFynDKUcORiHGSOA;

		private readonly AList<Element> hObmyuQkxgNXDiBtSEwFNgLuBsoZ;

		private readonly AList<Button> YXuCILbbSuGPNMGgRTZoPeQmcMPsA;

		private readonly AList<Axis> gmjcdmbtDXKatrtMKrVjuasYTyOh;

		private readonly ReadOnlyCollection<Element> VewvmtxDhBKjfOztXaGoFFLyxNDV;

		private readonly ReadOnlyCollection<Button> tnwAAWkpEQQDOblRgOpzbinWPPbqc;

		private readonly ReadOnlyCollection<Axis> cBSHMOCbWzIiiaZpZEDfrfjPCNNab;

		private readonly List<Element.znbsAbXzumooNTekBhsPkirgaxEt> FWgVsHaMpaDmKWXOXIqOajTcbGyhA;

		private Action<int, bool> fJujbQHHjdTObWpjlVIDpdfssDBK;

		private Action<int, float> QNrCqvatavEJcWTIgbPSkLjfyicxA;

		private Action<bool> eneVgSlIatJCOIDcAjGhRLwviGQy;

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int playerId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public IList<Button> buttons => null;

		public IList<Axis> axes => null;

		public IList<Element> elements => null;

		public int buttonCount => 0;

		public int axisCount => 0;

		public int elementCount => 0;

		internal Player XAbNzJSvSNjTFwhnJridEdiVWtEM => HlNvpalKJDTHNnTaGzpAQCpqBqkN();

		public event Action<int, bool> ButtonStateChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<int, float> AxisValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<bool> EnabledStateChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal PlayerController(Definition P_0)
		{
		}

		~PlayerController()
		{
		}

		public bool GetButton(int index)
		{
			return false;
		}

		public bool GetButtonDown(int index)
		{
			return false;
		}

		public bool GetButtonUp(int index)
		{
			return false;
		}

		public float GetAxis(int index)
		{
			return 0f;
		}

		public float GetAxisRaw(int index)
		{
			return 0f;
		}

		public Element GetElement(int index)
		{
			return null;
		}

		public T GetElement<T>(int index) where T : Element
		{
			return null;
		}

		internal Player HlNvpalKJDTHNnTaGzpAQCpqBqkN()
		{
			return null;
		}

		private void ZCGETbjMQZUkyflRtYAqwQNUBPQIb(UpdateLoopType P_0)
		{
		}

		protected virtual bool Update(UpdateLoopType updateLoop)
		{
			return false;
		}

		protected virtual void UpdateFinished()
		{
		}

		protected virtual void ClearVars()
		{
		}

		internal void JymOYvJCaUZfrfNvqSliYMwhgCGz(Element P_0)
		{
		}

		private void JymOYvJCaUZfrfNvqSliYMwhgCGz(Element P_0, List<Element> P_1, List<Element> P_2, List<Button> P_3, List<Axis> P_4)
		{
		}

		internal static int LmWghArlQXRYdjBGSILmEsYWzCwDA<_0001>(IList<_0001> P_0, Predicate<_0001> P_1, int P_2) where _0001 : Element
		{
			return 0;
		}
	}
}
