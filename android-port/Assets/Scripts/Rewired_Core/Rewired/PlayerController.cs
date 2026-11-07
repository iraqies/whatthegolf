using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x2000073")]
	public class PlayerController : IPlayerController
	{
		[Token(Token = "0x2000074")]
		public class Definition
		{
			[Token(Token = "0x40001E8")]
			[FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40001E9")]
			[FieldOffset(Offset = "0x14")]
			public int playerId;

			[Token(Token = "0x40001EA")]
			[FieldOffset(Offset = "0x18")]
			public ICollection<Element.Definition> elements;

			[Token(Token = "0x6000346")]
			[Address(RVA = "0x238C34C", Offset = "0x238C34C", VA = "0x238C34C")]
			public Definition()
			{
			}
		}

		[Token(Token = "0x2000075")]
		public static class Factory
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x238CA0C", Offset = "0x238CA0C", VA = "0x238CA0C")]
			public static PlayerController Create(Definition definition)
			{
				return null;
			}
		}

		[Token(Token = "0x2000076")]
		public class Axis : ElementWithSource
		{
			[Token(Token = "0x2000077")]
			public new class Definition : ElementWithSource.Definition
			{
				[Token(Token = "0x40001EF")]
				[FieldOffset(Offset = "0x24")]
				public AxisCoordinateMode coordinateMode;

				[Token(Token = "0x40001F0")]
				[FieldOffset(Offset = "0x28")]
				public float absoluteToRelativeSensitivity;

				[Token(Token = "0x600034D")]
				[Address(RVA = "0x23BF004", Offset = "0x23BF004", VA = "0x23BF004")]
				public Definition()
				{
				}

				[Token(Token = "0x600034E")]
				[Address(RVA = "0x23BF078", Offset = "0x23BF078", VA = "0x23BF078", Slot = "4")]
				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			[Token(Token = "0x40001EB")]
			internal const float tKzWjAAqFxznILFKHvHDMeAnaEtx = 1f;

			[Token(Token = "0x40001EC")]
			internal const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Absolute;

			[Token(Token = "0x40001ED")]
			[FieldOffset(Offset = "0x2C")]
			private float kGpcICdBcebufqmYNGRRSLHNkiOb;

			[Token(Token = "0x40001EE")]
			[FieldOffset(Offset = "0x30")]
			private AxisCoordinateMode IuVzvlfMSigqbjOqXgvDBwRIIUCO;

			[Token(Token = "0x17000159")]
			public float absoluteToRelativeSensitivity
			{
				[Token(Token = "0x6000349")]
				[Address(RVA = "0x2498784", Offset = "0x2498784", VA = "0x2498784")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700015A")]
			public AxisCoordinateMode coordinateMode
			{
				[Token(Token = "0x600034A")]
				[Address(RVA = "0x249878C", Offset = "0x249878C", VA = "0x249878C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700015B")]
			public virtual float value
			{
				[Token(Token = "0x600034B")]
				[Address(RVA = "0x2498794", Offset = "0x2498794", VA = "0x2498794", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700015C")]
			public virtual float valueRaw
			{
				[Token(Token = "0x600034C")]
				[Address(RVA = "0x24988A8", Offset = "0x24988A8", VA = "0x24988A8", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x249873C", Offset = "0x249873C", VA = "0x249873C")]
			internal Axis(PlayerController P_0, Definition P_1)
			{
			}
		}

		[Token(Token = "0x2000078")]
		public class MouseAxis : Axis
		{
			[Token(Token = "0x2000079")]
			public new class Definition : Axis.Definition
			{
				[Token(Token = "0x6000351")]
				[Address(RVA = "0x23BF2CC", Offset = "0x23BF2CC", VA = "0x23BF2CC")]
				public Definition()
				{
				}

				[Token(Token = "0x6000352")]
				[Address(RVA = "0x23BF308", Offset = "0x23BF308", VA = "0x23BF308", Slot = "4")]
				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			[Token(Token = "0x1700015D")]
			public override float value
			{
				[Token(Token = "0x6000350")]
				[Address(RVA = "0x238CA7C", Offset = "0x238CA7C", VA = "0x238CA7C", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x238CA74", Offset = "0x238CA74", VA = "0x238CA74")]
			internal MouseAxis(PlayerController P_0, Definition P_1)
			{
			}
		}

		[Token(Token = "0x200007A")]
		public class Axis2D : CompoundElement
		{
			[Token(Token = "0x200007B")]
			public new class Definition : CompoundElement.Definition
			{
				[Token(Token = "0x40001F1")]
				[FieldOffset(Offset = "0x20")]
				private Axis.Definition mQTUIoqEkWTkreeIZmWyMwdawBgc;

				[Token(Token = "0x40001F2")]
				[FieldOffset(Offset = "0x28")]
				private Axis.Definition mrWOIvlMbZydDUixWVKOhCmTyEYh;

				[Token(Token = "0x1700015F")]
				public Axis.Definition xAxis
				{
					[Token(Token = "0x6000357")]
					[Address(RVA = "0x23BF148", Offset = "0x23BF148", VA = "0x23BF148")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000358")]
					[Address(RVA = "0x23BF150", Offset = "0x23BF150", VA = "0x23BF150")]
					set
					{
					}
				}

				[Token(Token = "0x17000160")]
				public Axis.Definition yAxis
				{
					[Token(Token = "0x6000359")]
					[Address(RVA = "0x23BF158", Offset = "0x23BF158", VA = "0x23BF158")]
					get
					{
						return null;
					}
					[Token(Token = "0x600035A")]
					[Address(RVA = "0x23BF160", Offset = "0x23BF160", VA = "0x23BF160")]
					set
					{
					}
				}

				[Token(Token = "0x6000356")]
				[Address(RVA = "0x23BF0E8", Offset = "0x23BF0E8", VA = "0x23BF0E8")]
				public Definition()
				{
				}

				[Token(Token = "0x600035B")]
				[Address(RVA = "0x23BF168", Offset = "0x23BF168", VA = "0x23BF168", Slot = "4")]
				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			[Token(Token = "0x1700015E")]
			public virtual Vector2 value
			{
				[Token(Token = "0x6000355")]
				[Address(RVA = "0x2498BF0", Offset = "0x2498BF0", VA = "0x2498BF0", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x249890C", Offset = "0x249890C", VA = "0x249890C")]
			internal Axis2D(PlayerController P_0, Definition P_1, Element.Definition[] P_2)
			{
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x2498A24", Offset = "0x2498A24", VA = "0x2498A24")]
			internal Axis2D(PlayerController P_0, Definition P_1)
			{
			}
		}

		[Token(Token = "0x200007C")]
		public sealed class MouseAxis2D : Axis2D
		{
			[Token(Token = "0x200007D")]
			public new class Definition : Axis2D.Definition
			{
				[Token(Token = "0x17000161")]
				public new MouseAxis.Definition xAxis
				{
					[Token(Token = "0x600035E")]
					[Address(RVA = "0x23BF3A8", Offset = "0x23BF3A8", VA = "0x23BF3A8")]
					get
					{
						return null;
					}
					[Token(Token = "0x600035F")]
					[Address(RVA = "0x23BF428", Offset = "0x23BF428", VA = "0x23BF428")]
					set
					{
					}
				}

				[Token(Token = "0x17000162")]
				public new MouseAxis.Definition yAxis
				{
					[Token(Token = "0x6000360")]
					[Address(RVA = "0x23BF430", Offset = "0x23BF430", VA = "0x23BF430")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000361")]
					[Address(RVA = "0x23BF4B0", Offset = "0x23BF4B0", VA = "0x23BF4B0")]
					set
					{
					}
				}

				[Token(Token = "0x600035D")]
				[Address(RVA = "0x23BF378", Offset = "0x23BF378", VA = "0x23BF378")]
				public Definition()
				{
				}

				[Token(Token = "0x6000362")]
				[Address(RVA = "0x23BF4B8", Offset = "0x23BF4B8", VA = "0x23BF4B8", Slot = "4")]
				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x238CB34", Offset = "0x238CB34", VA = "0x238CB34")]
			internal MouseAxis2D(PlayerController P_0, Definition P_1)
			{
			}
		}

		[Token(Token = "0x200007E")]
		public sealed class Button : ElementWithSource
		{
			[Token(Token = "0x200007F")]
			public new class Definition : ElementWithSource.Definition
			{
				[Token(Token = "0x6000367")]
				[Address(RVA = "0x23BF1D8", Offset = "0x23BF1D8", VA = "0x23BF1D8")]
				public Definition()
				{
				}

				[Token(Token = "0x6000368")]
				[Address(RVA = "0x23BF210", Offset = "0x23BF210", VA = "0x23BF210", Slot = "4")]
				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			[Token(Token = "0x17000163")]
			public bool value
			{
				[Token(Token = "0x6000364")]
				[Address(RVA = "0x2498C9C", Offset = "0x2498C9C", VA = "0x2498C9C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000164")]
			public bool justPressed
			{
				[Token(Token = "0x6000365")]
				[Address(RVA = "0x2498D00", Offset = "0x2498D00", VA = "0x2498D00")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000165")]
			public bool justReleased
			{
				[Token(Token = "0x6000366")]
				[Address(RVA = "0x2498D64", Offset = "0x2498D64", VA = "0x2498D64")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000363")]
			[Address(RVA = "0x2498C94", Offset = "0x2498C94", VA = "0x2498C94")]
			internal Button(PlayerController P_0, Definition P_1)
			{
			}
		}

		[Token(Token = "0x2000080")]
		public abstract class CompoundElement : Element
		{
			[Token(Token = "0x2000081")]
			public new abstract class Definition : Element.Definition
			{
				[Token(Token = "0x600036D")]
				[Address(RVA = "0x23BF118", Offset = "0x23BF118", VA = "0x23BF118")]
				public Definition()
				{
				}
			}

			[Token(Token = "0x40001F3")]
			[FieldOffset(Offset = "0x28")]
			private readonly List<Element> hObmyuQkxgNXDiBtSEwFNgLuBsoZ;

			[Token(Token = "0x6000369")]
			[Address(RVA = "0x2498910", Offset = "0x2498910", VA = "0x2498910")]
			internal CompoundElement(PlayerController P_0, Definition P_1, Element.Definition[] P_2)
			{
			}

			[Token(Token = "0x600036A")]
			internal _0001 pAGcyUYRwJwYiiycWKSARieMOZIo<_0001>(int P_0) where _0001 : Element
			{
				return null;
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x2498E88", Offset = "0x2498E88", VA = "0x2498E88")]
			internal void yfvUZvCErrubvkdbzulBqRmKnLaT(List<Element> P_0)
			{
			}

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x2498DC8", Offset = "0x2498DC8", VA = "0x2498DC8")]
			internal void JymOYvJCaUZfrfNvqSliYMwhgCGz(Element P_0)
			{
			}
		}

		[Token(Token = "0x2000082")]
		public abstract class Element
		{
			[Token(Token = "0x2000083")]
			internal enum Type
			{
				[Token(Token = "0x40001FC")]
				Button = 0,
				[Token(Token = "0x40001FD")]
				Axis = 1,
				[Token(Token = "0x40001FE")]
				MouseAxis = 2,
				[Token(Token = "0x40001FF")]
				MouseWheelAxis = 3,
				[Token(Token = "0x4000200")]
				Axis2D = 100,
				[Token(Token = "0x4000201")]
				MouseAxis2D = 101,
				[Token(Token = "0x4000202")]
				MouseWheel = 102
			}

			[Token(Token = "0x2000084")]
			internal enum TypeWithSource
			{
				[Token(Token = "0x4000204")]
				Button = 0,
				[Token(Token = "0x4000205")]
				Axis = 1,
				[Token(Token = "0x4000206")]
				MouseAxis = 2,
				[Token(Token = "0x4000207")]
				MouseWheelAxis = 3
			}

			[Token(Token = "0x2000085")]
			public abstract class Definition
			{
				[Token(Token = "0x4000208")]
				[FieldOffset(Offset = "0x10")]
				public bool enabled;

				[Token(Token = "0x4000209")]
				[FieldOffset(Offset = "0x18")]
				public string name;

				[Token(Token = "0x6000377")]
				[Address(RVA = "0x23BF280", Offset = "0x23BF280", VA = "0x23BF280")]
				public Definition()
				{
				}

				[Token(Token = "0x6000378")]
				internal abstract Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0);
			}

			[Token(Token = "0x2000086")]
			internal struct znbsAbXzumooNTekBhsPkirgaxEt
			{
				[Token(Token = "0x400020A")]
				[FieldOffset(Offset = "0x0")]
				public ControllerElementType MdjBbHAfEpOIyysKWtDJwilBqwCjA;

				[Token(Token = "0x400020B")]
				[FieldOffset(Offset = "0x4")]
				public int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

				[Token(Token = "0x400020C")]
				[FieldOffset(Offset = "0x8")]
				public float yYOUbwIbBcyPAQvjeAEXVsjzLAln;

				[Token(Token = "0x6000379")]
				[Address(RVA = "0x23BF2B0", Offset = "0x23BF2B0", VA = "0x23BF2B0")]
				public znbsAbXzumooNTekBhsPkirgaxEt(ControllerElementType P_0, int P_1, float P_2)
				{
				}
			}

			[Token(Token = "0x40001F4")]
			internal const bool defaultEnabled = true;

			[Token(Token = "0x40001F5")]
			[FieldOffset(Offset = "0x10")]
			private readonly PlayerController afWhZEYTbMFjMUeulVkAPjICyxpP;

			[Token(Token = "0x40001F6")]
			[FieldOffset(Offset = "0x18")]
			private bool ZVriljhasPxEFvNaLvNOVyfTIDdb;

			[Token(Token = "0x40001F7")]
			[FieldOffset(Offset = "0x19")]
			private bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

			[Token(Token = "0x40001F8")]
			[FieldOffset(Offset = "0x20")]
			private string hEJFspqWqeBOdedbqHNRpPNEbfBG;

			[Token(Token = "0x40001F9")]
			[FieldOffset(Offset = "0x0")]
			private static int[] qGbdMURwQUZeXFRbaUvBlTnHrsNF;

			[Token(Token = "0x40001FA")]
			[FieldOffset(Offset = "0x8")]
			private static int[] wmvCHfufqZIquHLzLpGHJPmzGeky;

			[Token(Token = "0x17000166")]
			protected Player XAbNzJSvSNjTFwhnJridEdiVWtEM
			{
				[Token(Token = "0x600036F")]
				[Address(RVA = "0x238C41C", Offset = "0x238C41C", VA = "0x238C41C")]
				get
				{
					return get_player();
				}
			}

			[Token(Token = "0x17000167")]
			protected bool ctlEdDGNREqipIotFsdpXzilehZXA
			{
				[Token(Token = "0x6000370")]
				[Address(RVA = "0x238C5C8", Offset = "0x238C5C8", VA = "0x238C5C8")]
				get
				{
					return get_selfAndParentEnabled();
				}
			}

			[Token(Token = "0x17000168")]
			internal bool RJWetIMScbNkkayUbJoRDyHMCesM
			{
				[Token(Token = "0x6000371")]
				[Address(RVA = "0x238C5FC", Offset = "0x238C5FC", VA = "0x238C5FC")]
				get
				{
					return QdilGKxwKBKOqAtsKaqAxEYSaqTP();
				}
				[Token(Token = "0x6000372")]
				[Address(RVA = "0x238C604", Offset = "0x238C604", VA = "0x238C604")]
				set
				{
					QogGjtbarFqmkKesqDXoceThdxAEA(flag);
				}
			}

			[Token(Token = "0x17000169")]
			public bool enabled
			{
				[Token(Token = "0x6000373")]
				[Address(RVA = "0x238C610", Offset = "0x238C610", VA = "0x238C610")]
				set
				{
				}
			}

			[Token(Token = "0x600036E")]
			[Address(RVA = "0x238C364", Offset = "0x238C364", VA = "0x238C364")]
			internal Element(PlayerController P_0, Definition P_1)
			{
			}

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x238C41C", Offset = "0x238C41C", VA = "0x238C41C")]
			protected Player get_player()
			{
				return null;
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x238C5C8", Offset = "0x238C5C8", VA = "0x238C5C8")]
			protected bool get_selfAndParentEnabled()
			{
				return default;
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0x238C5FC", Offset = "0x238C5FC", VA = "0x238C5FC")]
			internal bool QdilGKxwKBKOqAtsKaqAxEYSaqTP()
			{
				return default;
			}

			[Token(Token = "0x6000372")]
			[Address(RVA = "0x238C604", Offset = "0x238C604", VA = "0x238C604")]
			internal void QogGjtbarFqmkKesqDXoceThdxAEA(bool P_0)
			{
			}

			[Token(Token = "0x6000374")]
			[Address(RVA = "0x238C630", Offset = "0x238C630", VA = "0x238C630", Slot = "4")]
			internal virtual void jRaYtHNVcykNMAbqOnSGaKIIGSEaA()
			{
			}

			[Token(Token = "0x6000375")]
			[Address(RVA = "0x238C634", Offset = "0x238C634", VA = "0x238C634", Slot = "5")]
			protected virtual void EnabledStateChanged(bool state)
			{
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x238C638", Offset = "0x238C638", VA = "0x238C638")]
			internal static Definition CreateDefinition(Type type)
			{
				return null;
			}
		}

		[Token(Token = "0x2000087")]
		public abstract class ElementWithSource : Element
		{
			[Token(Token = "0x2000088")]
			public new abstract class Definition : Element.Definition
			{
				[Token(Token = "0x400020F")]
				[FieldOffset(Offset = "0x20")]
				private int JwOchbdvhsvHVdSyYjtqEJdTZzYG;

				[Token(Token = "0x1700016C")]
				public int actionId
				{
					[Token(Token = "0x600037E")]
					[Address(RVA = "0x23BF2BC", Offset = "0x23BF2BC", VA = "0x23BF2BC")]
					get
					{
						return default;
					}
					[Token(Token = "0x600037F")]
					[Address(RVA = "0x23BF2C4", Offset = "0x23BF2C4", VA = "0x23BF2C4")]
					set
					{
					}
				}

				[Token(Token = "0x600037D")]
				[Address(RVA = "0x23BF040", Offset = "0x23BF040", VA = "0x23BF040")]
				public Definition()
				{
				}
			}

			[Token(Token = "0x400020D")]
			internal const int defaultActionId = -1;

			[Token(Token = "0x400020E")]
			[FieldOffset(Offset = "0x28")]
			private int JwOchbdvhsvHVdSyYjtqEJdTZzYG;

			[Token(Token = "0x1700016A")]
			public int actionId
			{
				[Token(Token = "0x600037B")]
				[Address(RVA = "0x238C858", Offset = "0x238C858", VA = "0x238C858")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700016B")]
			public string actionName
			{
				[Token(Token = "0x600037C")]
				[Address(RVA = "0x238C860", Offset = "0x238C860", VA = "0x238C860")]
				set
				{
				}
			}

			[Token(Token = "0x600037A")]
			[Address(RVA = "0x238C81C", Offset = "0x238C81C", VA = "0x238C81C")]
			internal ElementWithSource(PlayerController P_0, Definition P_1)
			{
			}
		}

		[Token(Token = "0x2000089")]
		public sealed class MouseWheel : Axis2D
		{
			[Token(Token = "0x200008A")]
			public new class Definition : Axis2D.Definition
			{
				[Token(Token = "0x1700016E")]
				public new MouseWheelAxis.Definition xAxis
				{
					[Token(Token = "0x6000383")]
					[Address(RVA = "0x23BF558", Offset = "0x23BF558", VA = "0x23BF558")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000384")]
					[Address(RVA = "0x23BF5D8", Offset = "0x23BF5D8", VA = "0x23BF5D8")]
					set
					{
					}
				}

				[Token(Token = "0x1700016F")]
				public new MouseWheelAxis.Definition yAxis
				{
					[Token(Token = "0x6000385")]
					[Address(RVA = "0x23BF5E0", Offset = "0x23BF5E0", VA = "0x23BF5E0")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000386")]
					[Address(RVA = "0x23BF660", Offset = "0x23BF660", VA = "0x23BF660")]
					set
					{
					}
				}

				[Token(Token = "0x6000382")]
				[Address(RVA = "0x23BF528", Offset = "0x23BF528", VA = "0x23BF528")]
				public Definition()
				{
				}

				[Token(Token = "0x6000387")]
				[Address(RVA = "0x23BF668", Offset = "0x23BF668", VA = "0x23BF668", Slot = "4")]
				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			[Token(Token = "0x1700016D")]
			public MouseWheelAxis yAxis
			{
				[Token(Token = "0x6000381")]
				[Address(RVA = "0x238CE84", Offset = "0x238CE84", VA = "0x238CE84")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x238CCDC", Offset = "0x238CCDC", VA = "0x238CCDC")]
			internal MouseWheel(PlayerController P_0, Definition P_1)
			{
			}
		}

		[Token(Token = "0x200008B")]
		public sealed class MouseWheelAxis : Axis
		{
			[Token(Token = "0x200008C")]
			public new class Definition : Axis.Definition
			{
				[Token(Token = "0x4000213")]
				[FieldOffset(Offset = "0x2C")]
				public float repeatRate;

				[Token(Token = "0x600038F")]
				[Address(RVA = "0x23BF6D8", Offset = "0x23BF6D8", VA = "0x23BF6D8")]
				public Definition()
				{
				}

				[Token(Token = "0x6000390")]
				[Address(RVA = "0x23BF724", Offset = "0x23BF724", VA = "0x23BF724", Slot = "4")]
				internal override Element FRGzoQGxlhWgnLpuxZPVeqiuvlgD(PlayerController P_0)
				{
					return null;
				}
			}

			[Token(Token = "0x4000210")]
			[FieldOffset(Offset = "0x34")]
			private float YSkaBBhJiFXPXTRPaOUbCTlETpio;

			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x38")]
			private double cGHxdUbOJdeKDTJHxDXvymTAxcnE;

			[Token(Token = "0x4000212")]
			[FieldOffset(Offset = "0x40")]
			private float ckUkzuSDJGuJonmPceZrDLTKWbwc;

			[Token(Token = "0x17000170")]
			public float repeatRate
			{
				[Token(Token = "0x6000389")]
				[Address(RVA = "0x238CF3C", Offset = "0x238CF3C", VA = "0x238CF3C")]
				set
				{
				}
			}

			[Token(Token = "0x17000171")]
			public override float value
			{
				[Token(Token = "0x600038A")]
				[Address(RVA = "0x238CF60", Offset = "0x238CF60", VA = "0x238CF60", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x238CEE0", Offset = "0x238CEE0", VA = "0x238CEE0")]
			internal MouseWheelAxis(PlayerController P_0, Definition P_1)
			{
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x238CF98", Offset = "0x238CF98", VA = "0x238CF98", Slot = "4")]
			internal override void jRaYtHNVcykNMAbqOnSGaKIIGSEaA()
			{
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x238D190", Offset = "0x238D190", VA = "0x238D190", Slot = "5")]
			protected override void EnabledStateChanged(bool state)
			{
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x238CFE0", Offset = "0x238CFE0", VA = "0x238CFE0")]
			private float cnPMTOtfmVCjsekZygybCvfqRwyMA()
			{
				return default;
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x238D1A0", Offset = "0x238D1A0", VA = "0x238D1A0")]
			private void SPGTRPyvIslcMdbPTItsewSLRPxx()
			{
			}
		}

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x10")]
		internal readonly int QajDFFaomlkLHzaostfWYpGUioys;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x14")]
		private bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x18")]
		private int DCGJXzigEdTcwzFynDKUcORiHGSOA;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x20")]
		private readonly AList<Element> hObmyuQkxgNXDiBtSEwFNgLuBsoZ;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x28")]
		private readonly AList<Button> YXuCILbbSuGPNMGgRTZoPeQmcMPsA;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x30")]
		private readonly AList<Axis> gmjcdmbtDXKatrtMKrVjuasYTyOh;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x38")]
		private readonly ReadOnlyCollection<Element> VewvmtxDhBKjfOztXaGoFFLyxNDV;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x40")]
		private readonly ReadOnlyCollection<Button> tnwAAWkpEQQDOblRgOpzbinWPPbqc;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x48")]
		private readonly ReadOnlyCollection<Axis> cBSHMOCbWzIiiaZpZEDfrfjPCNNab;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<Element.znbsAbXzumooNTekBhsPkirgaxEt> FWgVsHaMpaDmKWXOXIqOajTcbGyhA;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x58")]
		private Action<int, bool> fJujbQHHjdTObWpjlVIDpdfssDBK;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x60")]
		private Action<int, float> QNrCqvatavEJcWTIgbPSkLjfyicxA;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x68")]
		private Action<bool> eneVgSlIatJCOIDcAjGhRLwviGQy;

		[Token(Token = "0x17000150")]
		public bool enabled
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x23F4900", Offset = "0x23F4900", VA = "0x23F4900", Slot = "4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x23F49B4", Offset = "0x23F49B4", VA = "0x23F49B4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public int playerId
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x23F4C08", Offset = "0x23F4C08", VA = "0x23F4C08", Slot = "6")]
			get
			{
				return default;
			}
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x23F4CB8", Offset = "0x23F4CB8", VA = "0x23F4CB8", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public IList<Button> buttons
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x23F4D9C", Offset = "0x23F4D9C", VA = "0x23F4D9C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000153")]
		public IList<Axis> axes
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x23F4E4C", Offset = "0x23F4E4C", VA = "0x23F4E4C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		public IList<Element> elements
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x23F4EFC", Offset = "0x23F4EFC", VA = "0x23F4EFC", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000155")]
		public int buttonCount
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x23F4FAC", Offset = "0x23F4FAC", VA = "0x23F4FAC", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000156")]
		public int axisCount
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x23F5064", Offset = "0x23F5064", VA = "0x23F5064", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000157")]
		public int elementCount
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x23F511C", Offset = "0x23F511C", VA = "0x23F511C", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000158")]
		internal Player XAbNzJSvSNjTFwhnJridEdiVWtEM
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x23F5C40", Offset = "0x23F5C40", VA = "0x23F5C40")]
			get
			{
				return HlNvpalKJDTHNnTaGzpAQCpqBqkN();
			}
		}

		[Token(Token = "0x14000005")]
		public event Action<int, bool> ButtonStateChangedEvent
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x23F51D4", Offset = "0x23F51D4", VA = "0x23F51D4", Slot = "14")]
			add
			{
			}
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x23F52D0", Offset = "0x23F52D0", VA = "0x23F52D0", Slot = "15")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event Action<int, float> AxisValueChangedEvent
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x23F5354", Offset = "0x23F5354", VA = "0x23F5354", Slot = "16")]
			add
			{
			}
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x23F5450", Offset = "0x23F5450", VA = "0x23F5450", Slot = "17")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<bool> EnabledStateChangedEvent
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x23F54D4", Offset = "0x23F54D4", VA = "0x23F54D4", Slot = "18")]
			add
			{
			}
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x23F55D0", Offset = "0x23F55D0", VA = "0x23F55D0", Slot = "19")]
			remove
			{
			}
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x23F3BF0", Offset = "0x23F3BF0", VA = "0x23F3BF0")]
		internal PlayerController(Definition P_0)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x23F47BC", Offset = "0x23F47BC", VA = "0x23F47BC", Slot = "1")]
		~PlayerController()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x23F5654", Offset = "0x23F5654", VA = "0x23F5654", Slot = "20")]
		public bool GetButton(int index)
		{
			return default;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x23F5750", Offset = "0x23F5750", VA = "0x23F5750", Slot = "21")]
		public bool GetButtonDown(int index)
		{
			return default;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x23F584C", Offset = "0x23F584C", VA = "0x23F584C", Slot = "22")]
		public bool GetButtonUp(int index)
		{
			return default;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x23F5948", Offset = "0x23F5948", VA = "0x23F5948", Slot = "23")]
		public float GetAxis(int index)
		{
			return default;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x23F5A48", Offset = "0x23F5A48", VA = "0x23F5A48", Slot = "24")]
		public float GetAxisRaw(int index)
		{
			return default;
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x23F5B48", Offset = "0x23F5B48", VA = "0x23F5B48", Slot = "25")]
		public Element GetElement(int index)
		{
			return null;
		}

		[Token(Token = "0x600033D")]
		public T GetElement<T>(int index) where T : Element
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x23F5C40", Offset = "0x23F5C40", VA = "0x23F5C40")]
		internal Player HlNvpalKJDTHNnTaGzpAQCpqBqkN()
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x23F5D40", Offset = "0x23F5D40", VA = "0x23F5D40")]
		private void ZCGETbjMQZUkyflRtYAqwQNUBPQIb(UpdateLoopType P_0)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x23F5D7C", Offset = "0x23F5D7C", VA = "0x23F5D7C", Slot = "27")]
		protected virtual bool Update(UpdateLoopType updateLoop)
		{
			return default;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x23F60E8", Offset = "0x23F60E8", VA = "0x23F60E8", Slot = "28")]
		protected virtual void UpdateFinished()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x23F6488", Offset = "0x23F6488", VA = "0x23F6488", Slot = "29")]
		protected virtual void ClearVars()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x23F64DC", Offset = "0x23F64DC", VA = "0x23F64DC")]
		internal void JymOYvJCaUZfrfNvqSliYMwhgCGz(Element P_0)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x23F4348", Offset = "0x23F4348", VA = "0x23F4348")]
		private void JymOYvJCaUZfrfNvqSliYMwhgCGz(Element P_0, List<Element> P_1, List<Element> P_2, List<Button> P_3, List<Axis> P_4)
		{
		}

		[Token(Token = "0x6000345")]
		internal static int LmWghArlQXRYdjBGSILmEsYWzCwDA<_0001>(IList<_0001> P_0, Predicate<_0001> P_1, int P_2) where _0001 : Element
		{
			return default;
		}
	}
}
