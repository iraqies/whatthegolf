using UnityEngine;
using UnityEngine.Tilemaps;

namespace Puzzle
{
	public class PuzzleCompletedGate : PuzzleObjectBase
	{
		public enum ButtonType
		{
			fromLeft = 0,
			fromRight = 1,
			fromBelow = 2
		}

		public int flagsRequiredOffset;

		public ParticleSystem openParticles;

		public ButtonType orientation;

		public AudioClip sfxOnOpen;

		public AudioClip sfxExplosion;

		public AudioClip sfxOnHint;

		public bool isTilted;

		public OverworldDoor HorizontalDoor;

		public OverworldDoor VerticalDoor;

		public TrailRenderer HintTemplate;

		private Tilemap tileMap;

		private OverworldDoor door;

		private bool openOrOpening;

		public override void ResetObject()
		{
		}

		public override void Trigger(bool active)
		{
		}

		public void Init(Tilemap tilemap)
		{
		}

		public void OpenDoor()
		{
		}

		public bool IsOpenOrOpening()
		{
			return false;
		}
	}
}
