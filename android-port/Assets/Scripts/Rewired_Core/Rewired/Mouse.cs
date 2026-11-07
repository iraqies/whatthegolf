using System;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

namespace Rewired
{
	public sealed class Mouse : ControllerWithAxes
	{
		private TimerAbs fLCCypuZqCpPtgbCnJCjRCIOLhzo;

		private float[] RppfAfhTSdIchQLnZNhktEnYcfuq;

		private Vector2 JHlQdvIDknwhbpDkONoyRzgqysDj;

		private Vector2 NNeHrvYGutiOIXhlhFaJfwMWTlqw;

		private int bwNXkWpZUjObQdsLBTnYRgEGhqar;

		private readonly IUnifiedMouseSource eyyVWBZaxsCJCQMmwhCWcagfYfzWA;

		private static Guid prVaMvCMokqAbWLeJcbpooSHlNBE;

		public Vector2 screenPosition => default;

		public Vector2 screenPositionPrev => default;

		public Vector2 screenPositionDelta => default;

		public override Guid deviceInstanceGuid => default;

		internal Mouse(string P_0, IUnifiedMouseSource P_1)
			: base(0, InputSource.None, null, null, null, ControllerType.Keyboard, default, 0, 0, null, null, null, null)
		{
		}

		private Mouse(int P_0, InputSource P_1, string P_2, string P_3, int P_4, int P_5, HardwareControllerMap_Game P_6, Extension P_7, ControllerDataUpdater P_8)
			: base(0, InputSource.None, null, null, null, ControllerType.Keyboard, default, 0, 0, null, null, null, null)
		{
		}

		internal override void PwSVyxiNOmkyuuXUHWyuymUyabog(UpdateLoopType P_0)
		{
		}

		protected override bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId)
		{
			pole = default;
			elementIdentifierId = default;
			return false;
		}

		internal override void SPGTRPyvIslcMdbPTItsewSLRPxx()
		{
		}

		internal override bool RQRRqZiAdoXIQMUtzTIWsndPGdwX(bool P_0)
		{
			return false;
		}

		private void iKTboufbDeOsBaqAaWXIhLIsMqxu()
		{
		}
	}
}
