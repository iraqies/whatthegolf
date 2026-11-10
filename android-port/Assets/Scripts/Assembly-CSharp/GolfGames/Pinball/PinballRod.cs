using UnityEngine;

namespace GolfGames.Pinball
{
	public class PinballRod : MonoBehaviour
	{
		public bool ModifyScaleWhenHit;

		private AudioSource source;

		[SerializeField]
		private float vel = 100f;

		private void Awake()
		{
			source = GetComponent<AudioSource>();
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision == null || collision.transform == null)
				return;

			if (collision.transform.CompareTag("Ground") || collision.transform.CompareTag("Player"))
			{
				Pinball pinball = collision.transform.GetComponent<Pinball>();
				ContactPoint2D[] contacts = collision.contacts;
				if (contacts != null && contacts.Length > 0 && pinball != null && pinball.Rigidbody != null)
				{
					pinball.Rigidbody.AddForce(contacts[0].normal * vel, ForceMode2D.Impulse);
				}
				if (source != null)
				{
					source.Play();
				}
				if (ModifyScaleWhenHit)
				{
					StartCoroutine(pTween.To(0.3f, delegate(float t)
					{
						base.transform.localScale = Vector3.one * (Cubic.Out(t) * -0.3f + 1.3f);
					}));
				}
			}
		}
	}
}
