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

		public Action<bool> OnTrigger = delegate
		{
		};

		public bool Active { get; private set; }

		private void Awake()
		{
			if (sprite == null)
			{
				sprite = GetComponent<SpriteRenderer>();
			}
		}

		public void TriggerObjects(bool active)
		{
			Active = active;
			OnTrigger(active);
			if (sprite != null)
			{
				if (decorationSprite != null)
				{
					decorationSprite.enabled = !active;
				}
				if (offSprite != null && onSprite != null)
				{
					sprite.sprite = (active ? onSprite : offSprite);
				}
			}
			for (int i = 0; i < objects.Count; i++)
			{
				if (objects[i] != null)
				{
					objects[i].Trigger(active);
				}
			}
		}

		private void OnDrawGizmosSelected()
		{
			Gizmos.color = Color.red;
			for (int i = 0; i < objects.Count; i++)
			{
				if (objects[i] != null)
				{
					Gizmos.DrawLine(base.transform.position, objects[i].transform.position);
				}
			}
		}
	}
}
