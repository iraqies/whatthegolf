using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class PropDemo : MonoBehaviour
	{
		public PuppetMasterProp prop;

		public PropMuscle propMuscleLeft;

		public PropMuscle propMuscleRight;

		public bool pickUpOnAwake;

		private bool right;

		private PropMuscle connectTo => null;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
