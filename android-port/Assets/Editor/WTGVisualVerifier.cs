using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using CameraStack;
using Cinemachine;
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
			Debug.Log("[WTGVisualVerifier] Starting comprehensive runtime-initialized visual verification...");

			// 1. Overworld Section 8: Cow (Tippable) Standing vs Tipped + LAB EXPERIMENT #462
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
			foreach (var de in UnityEngine.Object.FindObjectsOfType<DemoEnabler>(true))
			{
				if (de != null) de.SendMessage("Awake", SendMessageOptions.DontRequireReceiver);
			}
			// Run TextMeshProLocalized.Awake so Western NotoSans font + material are applied!
			foreach (var tmpLoc in UnityEngine.Object.FindObjectsOfType<TextMeshProLocalized>(true))
			{
				if (tmpLoc != null && tmpLoc.gameObject.activeInHierarchy)
					tmpLoc.SendMessage("Awake", SendMessageOptions.DontRequireReceiver);
			}
			Camera owCam = FindMainCamera();
			var cow = UnityEngine.Object.FindObjectOfType<CowTippable>(true);
			if (cow != null && owCam != null)
			{
				cow.SendMessage("Awake", SendMessageOptions.DontRequireReceiver);
				Animator cowAnim = cow.GetComponentInChildren<Animator>(true);
				Vector3 cowPos = cow.transform.position;
				owCam.orthographic = true;
				owCam.orthographicSize = 7.5f;
				owCam.transform.rotation = Quaternion.identity;
				owCam.transform.position = new Vector3(cowPos.x, cowPos.y, -20.0f);

				var standingClip = AssetDatabase.LoadAssetAtPath<AnimationClip>("Assets/AnimationClip/CowStandingIdle.anim");
				var lyingClip = AssetDatabase.LoadAssetAtPath<AnimationClip>("Assets/AnimationClip/CowLyingIdle.anim");
				if (standingClip != null && cowAnim != null)
				{
					standingClip.SampleAnimation(cowAnim.gameObject, 0.2f);
				}
				RenderCameraToPng(owCam, Path.Combine(OutDir, "01_sec8_cow_standing.png"));

				if (lyingClip != null && cowAnim != null)
				{
					lyingClip.SampleAnimation(cowAnim.gameObject, 0.2f);
				}
				RenderCameraToPng(owCam, Path.Combine(OutDir, "02_sec8_cow_tipped.png"));
			}

			// 2. Render 20 representative rounds with full CameraManager & TextMeshProLocalized initialization
			VerifyAndRenderRound("Assets/Scenes/GolfGames/GOLF VS EVIL/EvilFlag 2 Furthest.unity", "03_sec8_evilflag_furthest.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/1. GOLF IS BORING/Tutorial.unity", "04_sec1_tutorial.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/1. GOLF IS BORING/CatBall.unity", "05_sec1_catball.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/1. GOLF IS BORING/ManBall.unity", "06_sec1_manball_ragdoll.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/2. 2D IS GREAT/2DBall Donkey Kong.unity", "07_sec2_donkey_kong.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/2. 2D IS GREAT/2DBall mario 1.unity", "08_sec2_mario1.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Livingroom/Livingroom couch.unity", "09_sec3_livingroom_couch.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/2D Explosions/2D Explosions Sticky 1.unity", "10_sec3_explosions_sticky.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/2. 2D IS GREAT/2D Moon Lander.unity", "11_sec4_moon_lander.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/4. FPG/FPG Ordinary Golf 1.unity", "12_sec4_fpg_golf.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/SUPERGOLF/SUPERGOLF0.unity", "13_sec5_supergolf.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Competitions/car monstertruck.unity", "14_sec5_monstertruck.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/1. GOLF IS BORING/MetalGearSolid01.unity", "15_sec6_metal_gear.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/7. CLONE WARS/AngryGolf.unity", "16_sec6_angry_golf.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/9. The rest/2D Portal Gun 1.unity", "17_sec7_portal_gun.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/9. The rest/Bowling/Bowling.unity", "18_sec7_bowling.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Western/2D Western Train.unity", "19_sec9_western_train.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Water/BeachVolleyGolf.unity", "20_sec9_beach_volley.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Hole In One/2D HoleInOne 08 flying ball.unity", "21_boss_08_flying_ball.png");
			VerifyAndRenderRound("Assets/Scenes/GolfGames/Boss Battles/Final boss.unity", "22_final_boss.png");

			// 3. Full Audit of ALL 194 .unity scenes in Assets/Scenes
			string[] allScenes = Directory.GetFiles("Assets/Scenes", "*.unity", SearchOption.AllDirectories);
			Array.Sort(allScenes);
			int totalScenes = 0;
			int zeroControllerRounds = 0;
			int zeroCameraRounds = 0;
			foreach (string sp in allScenes)
			{
				string sname = Path.GetFileNameWithoutExtension(sp);
				if (sname == "_Start" || sname == "Loading" || sname == "MissingLevel" || sname.Contains("overworld") || sname.Contains("transition"))
					continue;
				totalScenes++;
				EditorSceneManager.OpenScene(sp, OpenSceneMode.Single);
				var ctrls = UnityEngine.Object.FindObjectsOfType<GolfBallController>(true);
				var cams = UnityEngine.Object.FindObjectsOfType<Camera>(true);
				var goals = UnityEngine.Object.FindObjectsOfType<GolfGoal>(true);
				if (ctrls.Length == 0)
				{
					zeroControllerRounds++;
					Debug.LogWarning($"[SCENE AUDIT WARN] 0 GolfBallControllers in {sp}");
				}
				if (cams.Length == 0)
				{
					zeroCameraRounds++;
					Debug.LogWarning($"[SCENE AUDIT WARN] 0 Cameras in {sp}");
				}
			}
			Debug.Log($"[FULL 194-SCENE AUDIT SUMMARY] Audited {totalScenes} gameplay rounds: zeroControllerRounds={zeroControllerRounds}, zeroCameraRounds={zeroCameraRounds}");
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

		foreach (var tr in UnityEngine.Object.FindObjectsOfType<HoleInOneTransition>(true))
		{
			if (tr != null) tr.gameObject.SetActive(false);
		}
		foreach (var tmpLoc in UnityEngine.Object.FindObjectsOfType<TextMeshProLocalized>(true))
		{
			if (tmpLoc != null && tmpLoc.gameObject.activeInHierarchy)
				tmpLoc.SendMessage("Awake", SendMessageOptions.DontRequireReceiver);
		}

		// Disable CinemachineBrain in static editor preview so it doesn't snap Main Camera to (-7607, 7609, -6626)
		foreach (var brain in UnityEngine.Object.FindObjectsOfType<CinemachineBrain>(true))
		{
			if (brain != null)
			{
				brain.enabled = false;
				brain.transform.localPosition = Vector3.zero;
				brain.transform.localRotation = Quaternion.identity;
			}
		}
		if (scenePath.Contains("Final boss"))
		{
			foreach (var t in UnityEngine.Object.FindObjectsOfType<Transform>(true))
			{
				if (t != null && t.name == "Boss stages")
					t.gameObject.SetActive(true);
			}
		}

		var level = Level.Instance;
		var controllers = UnityEngine.Object.FindObjectsOfType<GolfBallController>(true);
		var goals = UnityEngine.Object.FindObjectsOfType<GolfGoal>(true);
		var oobs = UnityEngine.Object.FindObjectsOfType<OutOfBoundsTrigger>(true);
		var grav = UnityEngine.Object.FindObjectOfType<Gravity>(true);
		if (grav != null)
		{
			grav.UpdateGravity();
		}

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

		var cm = UnityEngine.Object.FindObjectOfType<CameraManager>(true);
		Camera cam = FindMainCamera();
		RenderTexture rt = new RenderTexture(Width, Height, 24, RenderTextureFormat.ARGB32);
		if (cam != null)
		{
			cam.targetTexture = rt;
		}
		if (cm != null)
		{
			foreach (var cb in cm.GetComponentsInChildren<CBOrthographicStatic>(true))
			{
				if (cb != null) cb.SendMessage("Awake", SendMessageOptions.DontRequireReceiver);
			}
			cm.SendMessage("Awake", SendMessageOptions.DontRequireReceiver);
			cm.SetCurrentBehaviour();
			cm.Reset();
			cam = cm.MainCamera ?? cam;
			if (cam != null) cam.targetTexture = rt;
			cm.Reset();
		}

		Debug.Log($"[ROUND AUDIT] {Path.GetFileNameWithoutExtension(scenePath)} | Level={(level != null ? level.name : "NULL")} | Controllers={controllers.Length} (Active={registeredCount}) | Goals={goals.Length} | OOB={oobs.Length} | Gravity3D={Physics.gravity.y:F1} | Cam={(cam != null ? cam.transform.eulerAngles.ToString() : "NULL")}");

		if (cam != null)
		{
			RenderCameraWithRtToPng(cam, rt, Path.Combine(OutDir, outFileName));
		}
		UnityEngine.Object.DestroyImmediate(rt);

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
		RenderCameraWithRtToPng(cam, rt, outPath);
		UnityEngine.Object.DestroyImmediate(rt);
	}

	private static void RenderCameraWithRtToPng(Camera cam, RenderTexture rt, string outPath)
	{
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

		byte[] png = tex.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(tex);
		File.WriteAllBytes(outPath, png);
		Debug.Log($"[WTGVisualVerifier] Saved {outPath} ({png.Length} bytes)");
	}
}
