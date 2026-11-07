using System;

namespace Rewired
{
	internal struct HardwareControllerMapIdentifier
	{
		public readonly Guid guid;

		public readonly InputSource inputSource;

		public readonly InputPlatform actualInputPlatform;

		public readonly int variantIndex;

		public HardwareControllerMapIdentifier(Guid P_0, InputSource P_1, InputPlatform P_2, int P_3)
		{
			guid = default;
			inputSource = InputSource.None;
			actualInputPlatform = InputPlatform.Unknown;
			variantIndex = 0;
		}
	}
}
