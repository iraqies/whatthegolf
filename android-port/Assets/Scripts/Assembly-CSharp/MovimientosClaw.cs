using System.Collections;
using UnityEngine;

public class MovimientosClaw : MonoBehaviour
{
	public bool MovingForward;

	public bool MovingBack;

	public bool MovingLeft;

	public bool MovingRight;

	public bool Grabbing;

	public float alturaMaxima = 5f;

	public float alturaMinima = 1f;

	public float correctorSeparacionTubos = 0.5f;

	public Animator animatorClaw;

	public float speed = 4f;

	public float speed_Claw = 3f;

	public Transform AlturaGancho;

	public Transform limitadorLeft;

	public Transform limitadorRight;

	public Transform limitadorFront;

	public Transform limitadorBack;

	public bool PuedeControlarse = true;

	private bool SoltarPremio;

	public bool[] LlegadoALaCesta;

	private bool dentroDeLaCesda;

	private bool bajarGanchoYSoltarPremio;

	private bool subirGanchoDeLaCesta;

	private void Start()
	{
		PuedeControlarse = true;
		if (LlegadoALaCesta == null || LlegadoALaCesta.Length < 2)
		{
			LlegadoALaCesta = new bool[2];
		}
	}

	private void FixedUpdate()
	{
		if (PuedeControlarse && !Grabbing)
		{
			Vector3 pos = transform.position;
			if (MovingForward && (limitadorFront == null || pos.z < limitadorFront.position.z))
			{
				pos.z += speed * Time.fixedDeltaTime;
			}
			if (MovingBack && (limitadorBack == null || pos.z > limitadorBack.position.z))
			{
				pos.z -= speed * Time.fixedDeltaTime;
			}
			if (MovingRight && (limitadorRight == null || pos.x < limitadorRight.position.x))
			{
				pos.x += speed * Time.fixedDeltaTime;
			}
			if (MovingLeft && (limitadorLeft == null || pos.x > limitadorLeft.position.x))
			{
				pos.x -= speed * Time.fixedDeltaTime;
			}
			transform.position = pos;
		}
		else if (Grabbing && AlturaGancho != null)
		{
			Vector3 localPos = AlturaGancho.localPosition;
			if (!SoltarPremio)
			{
				localPos.y = Mathf.MoveTowards(localPos.y, alturaMinima, speed_Claw * Time.fixedDeltaTime);
				AlturaGancho.localPosition = localPos;
				if (Mathf.Abs(localPos.y - alturaMinima) < 0.05f)
				{
					CerrarClaw();
					SoltarPremio = true;
				}
			}
			else
			{
				localPos.y = Mathf.MoveTowards(localPos.y, alturaMaxima, speed_Claw * Time.fixedDeltaTime);
				AlturaGancho.localPosition = localPos;
				if (Mathf.Abs(localPos.y - alturaMaxima) < 0.05f)
				{
					Grabbing = false;
					SoltarPremio = false;
					PuedeControlarse = true;
				}
			}
		}
	}

	public void MoveForward(bool move)
	{
		MovingForward = move;
	}

	public void MoveBack(bool move)
	{
		MovingBack = move;
	}

	public void MoveLeft(bool move)
	{
		MovingLeft = move;
	}

	public void MoveRight(bool move)
	{
		MovingRight = move;
	}

	public void Grab(bool grab)
	{
		if (grab && PuedeControlarse && !Grabbing)
		{
			Grabbing = true;
			PuedeControlarse = false;
			SoltarPremio = false;
			AbrirClaw();
		}
	}

	private IEnumerator CerrarClaw(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		CerrarClaw();
	}

	private IEnumerator SoltarPremioEnLaCesta(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		AbrirClaw();
	}

	private IEnumerator AbrirClawEnlaCesta(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		AbrirClaw();
	}

	public void AbrirClaw()
	{
		if (animatorClaw != null)
		{
			animatorClaw.SetBool("Cerrar", false);
			animatorClaw.SetBool("Abrir", true);
		}
	}

	public void CerrarClaw()
	{
		if (animatorClaw != null)
		{
			animatorClaw.SetBool("Abrir", false);
			animatorClaw.SetBool("Cerrar", true);
		}
	}
}
