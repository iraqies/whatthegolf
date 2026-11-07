using System.Collections;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class DominoBehavior : MonoBehaviour
{
	public AudioClip dominoSound;

	public int dominosInFront;

	public bool followMe;

	public int dominoIndex;

	public DominoShooter shooter;

	private static float f;

	private bool collidedWith;

	private DrawDominos drawnDominos;

	private Rigidbody rb;

	private BoxCollider box;

	private AudioSource source;

	private float scaleAffectTargety;

	private float scale;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private IEnumerator LayDown()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	private static IEnumerator Stroke()
	{
		return null;
	}

	public void Reset()
	{
	}
}
