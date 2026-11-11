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
			if (active && !openOrOpening)
			{
				OpenDoor();
			}
		}

		public void Init(Tilemap tilemap)
		{
			tileMap = tilemap;
			if (orientation == ButtonType.fromBelow)
			{
				door = HorizontalDoor;
			}
			else
			{
				door = VerticalDoor;
			}
			if (HorizontalDoor != null)
			{
				HorizontalDoor.gameObject.SetActive(door == HorizontalDoor);
			}
			if (VerticalDoor != null)
			{
				VerticalDoor.gameObject.SetActive(door == VerticalDoor);
			}
			isTilted = false;
		}

		public void OpenDoor()
		{
			openOrOpening = true;
			if (openParticles != null)
			{
				openParticles.transform.SetParent(null);
				openParticles.Play();
			}
			if (sfxOnOpen != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
			{
				AudioManager.Instance.shortEffects.Play(sfxOnOpen, s => s.volume = 0.6f, 0f, false);
			}
			if (sfxExplosion != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
			{
				AudioManager.Instance.shortEffects.Play(sfxExplosion, s => s.volume = 0.6f, 0f, false);
			}
			if (door != null)
			{
				door.OpenDoor(() =>
				{
					if (door != null)
					{
						door.transform.SetParent(transform.parent);
					}
					gameObject.SetActive(false);
				}, false);
			}
		}

		public bool IsOpenOrOpening()
		{
			return openOrOpening;
		}
	}
}
