using System.Collections;
using UnityEngine;

public class SuperGolfCannonMuzzle : MonoBehaviour
{
	public Transform BulletOrigin;

	public Transform MuzzleObject;

	public ParticleSystem Particles;

	public bool MoveCannonOnShot;

	public IEnumerator PreFireAnimation()
	{
		return null;
	}
}
