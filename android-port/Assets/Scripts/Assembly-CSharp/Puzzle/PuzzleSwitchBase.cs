using System;
using System.Collections.Generic;
using UnityEngine;

namespace Puzzle
{
	public abstract class PuzzleSwitchBase : MonoBehaviour
	{
		public SpriteRenderer sprite;

		public Sprite onSprite;

		public Sprite offSprite;

		public SpriteRenderer decorationSprite;

		public List<PuzzleObjectBase> objects;

		public Action<bool> OnTrigger;

		public bool Active { get; private set; }

		private void Awake()
		{
		}

		public void TriggerObjects(bool active)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
