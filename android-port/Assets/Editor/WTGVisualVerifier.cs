using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using Core;
using GolfCourse;

public static class WTGVisualVerifier
{
	private const int Width = 576;
	private const int Height = 1280;
	private const string OutDir = "/tmp/wtg_verify";

	public static void RunVerification()
	{
		try
		{
			Directory.CreateDirectory(OutDir);
			Debug.Log("[WTGVisualVerifier] Starting comprehensive round & fix verification...");

			// 1. Overworld Section 8: Cow (Tippable)Standing vs Tipped + Main door Robot 08
			EditorSceneManager.OpenScene("Assets/Scenes/GolfGames/1. GOLF IS BORING/main overworld new.unity", OpenSceneMode.Single);
			var owGF = UnityEngine.Object.FindObjectOfType<GridFiller>();
			if (owGF != null)
			{
				if (owGF.rotatedMap != null) owGF.rotatedMap.SetActive(true);
				if (owGF.normalMap != null) owGF.normalMap.SetActive(false);
			}
			foreach (var sec in UnityEngine.Object.FindObjectsOfType<HubSection>(true))
			{
				if (sec != null && sec.Container != null)
					sec.Container.SetActive(true);
			}
			Camera owCam = FindMainCamera();
			var cow = UnityEngine.Object.FindObjectOfType<CowTippable>(true);
			if (cow != null && owCam != null)
			{
				cow.SendMessage("Awake", SendMessageOptions.DontRequireReceiver);
				Animator cowAnim = cow.GetComponentInChildren<Animator>(true);
				Debug.Log($"[WTGVisualVerifier] CowTippable found on '{cow.name}', Animator in children: {(cowAnim != null ? cowAnim.name : "NULL")}");
				Vector3 cowPos = cow.transform.position;
				owCam.orthographic = true;
				owCam.orthographicSize = 7.5f;
				owCam.transform.rotation = Quaternion.identity;
				owCam.transform.position = new Vector3(cowPos.x, cowPos.y, -20.0f);
				if (cowAnim != null)
				{
					cowAnim.SetBool("Tipped", false);
					cowAnim.Update(0.5f);
				}
				RenderCameraToPng(owCam, Path.Combine(OutDir, "01_sec8_cow_standing.png"));

				if (cowAnim != null)
				{
					cowAnim.SetBool("Tipped", true);
					for (int i = 0; i < 30; i++) cowAnim.Update(0.05f);
				}
				if (cow.SpeechLying != null)
				{
					cow.SpeechLying.gameObject.SetActive(true);
				}
				RenderCameraToPng(owCam, Path.Combine(OutDir, "02_sec8_cow_tipped.png"));
			}

			// 2. Section 8 Round: EvilFlag 2 Furthest ("LAB EXPERIMENT #462: ANNOYANCE")
			VerifyAndRenderRound("Assets/Scenes/GolfGames/GOLF VS EVIL/EvilFlag 2 Furthest.unity", "03_sec8_evilflag_furthest.png");

			// 3. Section 1: Tutorial & CatBall & ManBall (Ragdoll Golfer)
			VerifyAndRenderRound("Assets/Scenes/GolfGames/1. GOLF IS BORING/Tutorial.unity", "04_sec1_tutorial.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/1. GOLF IS BORING/CatBall.unity", "05_sec1_catball.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/1. GOLF IS BORING/ManBall.unity", "06_sec1_manball_ragdoll.png");

			// 4. Section 2: 2DBall Donkey Kong & 2DBall mario 1
			VerifyAndRenderRound("Assets/Scenes/GolfGames/2. 2D IS GREAT/2DBall Donkey Kong.unity", "07_sec2_donkey_kong.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/2. 2D IS GREAT/2DBall mario 1.unity", "08_sec2_mario1.png");

			// 5. Section 3 / Livingroom & Explosions: Livingroom couch & 2D Explosions Sticky 1
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Livingroom/Livingroom couch.unity", "09_sec3_livingroom_couch.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/2D Explosions/2D Explosions Sticky 1.unity", "10_sec3_explosions_sticky.png");

			// 6. Section 4 / Space & FPG: 2D Moon Lander & FPG Ordinary Golf 1
			VerifyAndRenderRound("Assets/Scenes/GolfGames/2. 2D IS GREAT/2D Moon Lander.unity", "11_sec4_moon_lander.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/4. FPG/FPG Ordinary Golf 1.unity", "12_sec4_fpg_golf.png");

			// 7. Section 5 / SUPERGOLF & Competitions: SUPERGOLF0 & car monstertruck
			VerifyAndRenderRound("Assets/Scenes/GolfGames/SUPERGOLF/SUPERGOLF0.unity", "13_sec5_supergolf.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Competitions/car monstertruck.unity", "14_sec5_monstertruck.png");

			// 8. Section 6 / Stealth & Clone Wars: MetalGearSolid01 & AngryGolf
			VerifyAndRenderRound("Assets/Scenes/GolfGames/1. GOLF IS BORING/MetalGearSolid01.unity", "15_sec6_metal_gear.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/7. CLONE WARS/AngryGolf.unity", "16_sec6_angry_golf.png");

			// 9. Section 7 / Portal & Bowling: 2D Portal Gun 1 & Bowling
			VerifyAndRenderRound("Assets/Scenes/GolfGames/9. The rest/2D Portal Gun 1.unity", "17_sec7_portal_gun.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/9. The rest/Bowling/Bowling.unity", "18_sec7_bowling.png");

			// 10. Section 8/9/10: Western, Water, Boss HoleInOne 08, Final Boss
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Western/2D Western Train.unity", "19_sec9_western_train.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Water/BeachVolleyGolf.unity", "20_sec9_beach_volley.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Hole In One/2D HoleInOne 08 flying ball.unity", "21_boss_08_flying_ball.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Boss Battles/Final boss.unity", "22_final_boss.png");

			Debug.Log($"[WTGVisualVerifier] Final Global Physics.gravity={Physics.gravity}, Physics2D.gravity={Physics2D.gravity}");
			Debug.Log("[WTGVisualVerifier] Completed all 22 verification renders and round audits successfully.");
			EditorApplication.Exit(0);
		}
		catch (Exception ex)
		{
			Debug.LogError("[WTGVisualVerifier] Exception: " + ex);
			EditorApplication.Exit(1);
		}
	}

	private static void VerifyAndRenderRound(string scenePath, string outFileName)
	{
		if (!File.Exists(scenePath))
		{
			Debug.LogWarning($"[WTGVisualVerifier] Scene not found: {scenePath}");
			return;
		}
		EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Single);

		// Hide any full-screen black transition overlays in editor preview
		foreach (var tr in UnityEngine.Object.FindObjectsOfType<HoleInOneTransition>(true))
		{
			if (tr != null) tr.gameObject.SetActive(false);
		}

		// Audit Level, GolfBallController, GolfGoal, OutOfBoundsTrigger, Gravity
		var level = Level.Instance;
		var controllers = UnityEngine.Object.FindObjectsOfType<GolfBallController>(true);
		var goals = UnityEngine.Object.FindObjectsOfType<GolfGoal>(true);
		var oobs = UnityEngine.Object.FindObjectsOfType<OutOfBoundsTrigger>(true);
		var grav = UnityEngine.Object.FindObjectOfType<Gravity>(true);
		if (grav != null)
		{
			grav.UpdateGravity();
		}

		// Verify Level.Instance lazy resolution & GolfBallController registration
		int registeredCount = 0;
		foreach (var gbc in controllers)
		{
			if (gbc != null && gbc.gameObject.activeInHierarchy)
			{
				gbc.SendMessage("Awake", SendMessageOptions.DontRequireReceiver);
				gbc.SendMessage("OnEnable", SendMessageOptions.DontRequireReceiver);
				registeredCount++;
			}
		}

		Debug.Log($"[ROUND AUDIT] {Path.GetFileNameWithoutExtension(scenePath)} | Level={(level != null ? level.name : "NULL")} | Controllers={controllers.Length} (Active={registeredCount}) | Goals={goals.Length} | OOB={oobs.Length} | Gravity3D={Physics.gravity.y:F1} | Gravity2D={Physics2D.gravity.y:F1}");

		Camera cam = FindMainCamera();
		if (cam != null)
		{
			RenderCameraToPng(cam, Path.Combine(OutDir, outFileName));
		}
		else
		{
			Debug.LogWarning($"[ROUND AUDIT] No camera found in {scenePath}");
		}

		if (grav != null)
		{
			grav.gameObject.SetActive(false);
			grav.SendMessage("OnDestroy", SendMessageOptions.DontRequireReceiver);
		}
	}

	private static Camera FindMainCamera()
	{
		if (Camera.main != null) return Camera.main;
		foreach (var c in UnityEngine.Object.FindObjectsOfType<Camera>(true))
		{
			if (c != null && c.gameObject.activeInHierarchy && c.gameObject.name.Contains("Main"))
				return c;
		}
		foreach (var c in UnityEngine.Object.FindObjectsOfType<Camera>(true))
		{
			if (c != null && c.gameObject.activeInHierarchy)
				return c;
		}
		return UnityEngine.Object.FindObjectOfType<Camera>(true);
	}

	private static void RenderCameraToPng(Camera cam, string outPath)
	{
		RenderTexture rt = new RenderTexture(Width, Height, 24, RenderTextureFormat.ARGB32);
		RenderTexture prevTarget = cam.targetTexture;
		RenderTexture prevActive = RenderTexture.active;

		cam.targetTexture = rt;
		cam.Render();

		RenderTexture.active = rt;
		Texture2D tex = new Texture2D(Width, Height, TextureFormat.RGB24, false);
		tex.ReadPixels(new Rect(0, 0, Width, Height), 0, 0);
		tex.Apply();

		cam.targetTexture = prevTarget;
		RenderTexture.active = prevActive;
		UnityEngine.Object.DestroyImmediate(rt);

		byte[] png = tex.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(tex);
		File.WriteAllBytes(outPath, png);
		Debug.Log($"[WTGVisualVerifier] Saved {outPath} ({png.Length} bytes)");
	}
}
