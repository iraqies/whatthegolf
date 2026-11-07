using System;

namespace Rewired
{
	public struct ControllerIdentifier
	{
		private int UceKlChkUHGjQaNwpAzeqaieFMpt;

		private ControllerType KHkewZTAeuvHVDDJaWvnQRRxxDiF;

		private Guid fMxZVPLmyEupjctdQIaGgbDJdlvHA;

		private string xBrcfixGFlRWLdALITGLqMbVvAXW;

		private Guid guGxXkQdSCnhDedSVaPzhraGphmHA;

		public int controllerId => 0;

		public ControllerType controllerType => ControllerType.Keyboard;

		public Guid hardwareTypeGuid => default;

		public string hardwareIdentifier => null;

		public Guid deviceInstanceGuid => default;

		internal ControllerIdentifier(Controller P_0)
		{
			UceKlChkUHGjQaNwpAzeqaieFMpt = 0;
			KHkewZTAeuvHVDDJaWvnQRRxxDiF = ControllerType.Keyboard;
			fMxZVPLmyEupjctdQIaGgbDJdlvHA = default;
			xBrcfixGFlRWLdALITGLqMbVvAXW = null;
			guGxXkQdSCnhDedSVaPzhraGphmHA = default;
		}
	}
}
