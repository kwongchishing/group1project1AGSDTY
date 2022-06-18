﻿using UnityEngine;

namespace BitGamey
{
	public class EasySplitScreen : MonoBehaviour
	{
		public save2 save2;
		public GameObject Player1, Player2;
		public float Ydistance;
		private static bool EnableSplitscreen;                              // Store current splitscreen state.

		[Tooltip("Do you want the effect to be active when your game starts?")]
		[SerializeField] private bool EnableAtStart;                        // Set start-up status in the Inspector or script.

		[Header("Game Objects")]
		[Tooltip("Drag the Player1 object into this slot.")]
		[SerializeField] private Transform player1;                         // Store transform of the first player.

		[Tooltip("Drag the Player2 object into this slot.")]
		[SerializeField] private Transform player2;                         // Store transform of the second player.

		[Header("Camera Settings")]

		[Tooltip("Camera X position offset (from EasySplitScreen default camera position).")]
		[SerializeField] private float camXPos_offset;                      // Camera X-axis position offset.
		[Tooltip("Camera Y position offset (from EasySplitScreen default camera position).")]
		[SerializeField] public float camYPos_offset;                      // Camera Y-axis position offset.
		[Tooltip("Camera Z position offset (from EasySplitScreen default camera position).")]
		[SerializeField] private float camZPos_offset;                      // Camera Z-axis position offset.

		[Header("Splitscreen Settings")]
		[Tooltip("Distance between players when the splitscreen effect begins. Default is 5.")]
		[SerializeField] private float splitscreenDist = 5;                 // Distance between Player1 and Player2 when the splitscreen effect begins.

		[Tooltip("The color of the splitscreen line. Default is black.")]
		[SerializeField] private Color splitscreenLineColor = Color.black;  // The color of the dividing line.

		[Tooltip("The width of the dividing line. Default is 0.01.")]
		[Range(0.01f, 0.1f)]
		[SerializeField] private float staticLineWidth = 0.01f;             // The width of the dividing line.

		[Space(10)]

		[Tooltip("The maximum width of the dividing line. Default is 0. Set to 0 to use the Static Line Width.")]
		[Range(0f, 2f)]
		[SerializeField] private float dynamicMaxLineWidth = 0f;            // The maximum width of the dividing line if 'player distance' calculated.
		private float distanceZaxis;                                        // Distance between players (on z-axis) in distanceZaxis.
		private float distanceBetweenPlayers;                               // Distance between players in distanceBetweenPlayers.

		// Define camera variables.
		private GameObject GameCamera;                                      // Store the project Main Camera.
		private GameObject SplitscreenCamera;                               // Store the created splitscreen camera.

		// Define quad variables.
		private static GameObject SplitQuadA;                               // The first of 2 primitive quads drawn to show the second view.
		private static GameObject SplitQuadB;                               // The second of 2 primitive quads drawn to show the second view.
		Camera cam2;
		Camera cam1;
		void Start()
		{
			if (EnableAtStart)
			{
				EnableSplitscreen = true;
			}
			else
			{
				EnableSplitscreen = false;
			}
// Camera 1 config.
			GameCamera = Camera.main.gameObject;                                // Store Main Camera object.
			Camera cam1 = GameCamera.GetComponent<Camera>();                    // Store camera component of GameCamera (Main Camera) in cam1.

			// Camera 2 config.
			SplitscreenCamera = new GameObject("Main Camera 2 (splitcam)");     // Create new object in Hierarchy for second camera.
			Camera cam2 = SplitscreenCamera.AddComponent<Camera>();             // Add camera component to new object.

			cam2.depth = cam1.depth - 1;                                        // Set the second camera to render before the first camera.
			cam2.cullingMask = ~(1 << LayerMask.NameToLayer("TransparentFX"));
			cam2.nearClipPlane = 1.8f;
			cam2.farClipPlane = 110f;// Set culling mask of second camera to ignore layer "TransparentFX", to AVOID rendering new quads on BOTH cameras.
		
			//CameraConfig();                                                 // Call method to set up cameras.
			QuadsAndLayersConfig();                                         // Call method to set up quads and layers.			
		}

	/*	public void CameraConfig()
		{
			}*/

		private void QuadsAndLayersConfig()
		{
			SplitQuadB = GameObject.CreatePrimitive(PrimitiveType.Quad);                    // Create a primitive quad referenced with SplitQuadB.
			SplitQuadB.name = "SplitQuadB";                                                 // Rename newly created object.
			SplitQuadB.transform.parent = gameObject.transform;                             // Set parent of SplitQuadB to main camera.
			SplitQuadB.transform.localPosition = Vector3.forward;                           // Set localPosition of SplitQuadB.
			SplitQuadB.transform.localScale = new Vector3(3f, staticLineWidth / 10, 1);     // Set localScale of SplitQuadB.
			SplitQuadB.transform.localEulerAngles = Vector3.zero;                           // Set rotation of SplitQuadB.
			SplitQuadB.SetActive(false);                                                    // Set SplitQuadB disabled.
			Destroy(SplitQuadB.GetComponent<MeshCollider>());
			SplitQuadB.GetComponent<Renderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
			SplitQuadB.GetComponent<Renderer>().receiveShadows = false;
			SplitQuadA = GameObject.CreatePrimitive(PrimitiveType.Quad);                    // Create a primitive quad referenced with SplitQuadA.
			SplitQuadA.name = "SplitQuadA";                                                 // Rename newly created object.
			SplitQuadA.transform.parent = SplitQuadB.transform;                             // Set parent of SplitQuadA to SplitQuadB.
			SplitQuadA.transform.localPosition =
				new Vector3(0, -(1 / (staticLineWidth / 10)), 0.0001f);                     // Add some distance on Z-axis to avoid clipping.
			SplitQuadA.transform.localScale =
				new Vector3(3f, 2 / (staticLineWidth / 10), 1);                             // Set localScale of SplitQuadA.
			SplitQuadA.transform.localEulerAngles = Vector3.zero;                           // Set rotation of SplitQuadA.
			Destroy(SplitQuadA.GetComponent<MeshCollider>());
			SplitQuadA.GetComponent<Renderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
			SplitQuadA.GetComponent<Renderer>().receiveShadows = false;
			Material tempMaterial1 = new Material(Shader.Find("Unlit/Color"));              // Create new material assigned to tempMaterial1.
			tempMaterial1.color = splitscreenLineColor;                                     // Set new material color to what was set in the Inspector (for SplitscreenLineColor).
			SplitQuadB.GetComponent<Renderer>().material = tempMaterial1;                   // Set SplitQuadB renderer material to newly created material.
			SplitQuadB.GetComponent<Renderer>().sortingOrder = 2;                           // Set SplitQuadB renderer sorting order.
			SplitQuadB.layer = LayerMask.NameToLayer("TransparentFX");                      // Set SplitQuadB layer mask.

			Material tempMaterial2 = new Material(Shader.Find("Mask/SplitScreen"));         // Create new material assigned to tempMaterial2.
			SplitQuadA.GetComponent<Renderer>().material = tempMaterial2;                   // Set SplitQuadA renderer material to newly created material.
			SplitQuadA.layer = LayerMask.NameToLayer("TransparentFX");                      // Set SplitQuadA layer mask.
		}

		private void UpdateLineSize()
		{
			if ((distanceBetweenPlayers - splitscreenDist) < dynamicMaxLineWidth)
			{
				SplitQuadB.transform.localScale =
					new Vector3(3f, (distanceBetweenPlayers - splitscreenDist) / 50, 1f);   // Set localScale of SplitQuadB.
			}
		}

		public static void ToggleEffect()
		{
			EnableSplitscreen = !EnableSplitscreen;     // Reverse current splitscreen state.

			SplitQuadA.SetActive(EnableSplitscreen);    // Set SplitQuadA visibility depending on splitscreen state.
			SplitQuadB.SetActive(EnableSplitscreen);    // Set SplitQuadB visibility depending on splitscreen state.
		}

		void LateUpdate()
		{
			
			if (dynamicMaxLineWidth > 0) { UpdateLineSize(); }                                          // If a dynamic line width was selected in the Inspector, vary the line length.

			float lerpTime = 5f;                                                                        // Store value of time taken for Linear intERPolation.

			distanceZaxis = player1.position.z - player2.transform.position.z;                          // Store distance between players (on z-axis) in distanceZaxis.
			distanceBetweenPlayers = Vector3.Distance(player1.position, player2.transform.position);    // Store distance between players in distanceBetweenPlayers.

			// Rotate the view based on player positions.
			float rotAngle;
			if (player1.transform.position.x <= player2.transform.position.x)
			{
				rotAngle = Mathf.Rad2Deg * Mathf.Acos(distanceZaxis / distanceBetweenPlayers);
			}
			else
			{
				rotAngle = Mathf.Rad2Deg * Mathf.Asin(distanceZaxis / distanceBetweenPlayers) - 90;
			}
			SplitQuadB.transform.localEulerAngles = new Vector3(0, 0, rotAngle);

			Vector3 midPoint = new Vector3(
				(player1.position.x + player2.position.x) / 2,
				(player1.position.y + player2.position.y) / 2,
				(player1.position.z + player2.position.z) / 2);                                             // Determine midpoint between the players.

			// If it's time to split, calculate the new midpoint.
			if (distanceBetweenPlayers > splitscreenDist)
			{
				Vector3 offset = midPoint - player1.position;
				offset.x = Mathf.Clamp(offset.x, -splitscreenDist / 2, splitscreenDist / 2);
				offset.y = Mathf.Clamp(offset.y, -splitscreenDist / 2, splitscreenDist / 2);
				offset.z = Mathf.Clamp(offset.z, -splitscreenDist / 2, splitscreenDist / 2);
				midPoint = player1.position + offset;

				Vector3 offset2 = midPoint - player2.position;
				offset2.x = Mathf.Clamp(offset.x, -splitscreenDist / 2, splitscreenDist / 2);
				offset2.y = Mathf.Clamp(offset.y, -splitscreenDist / 2, splitscreenDist / 2);
				offset2.z = Mathf.Clamp(offset.z, -splitscreenDist / 2, splitscreenDist / 2);
				Vector3 midPoint2 = player2.position - offset;

				// Enable second quad and camera, then set second camera position.
				if (SplitQuadB.activeSelf == false)
				{

					if (EnableSplitscreen)
					{
						SplitQuadB.SetActive(true);
						SplitscreenCamera.SetActive(true);
					}

					SplitscreenCamera.transform.position = GameCamera.transform.position;
					SplitscreenCamera.transform.rotation = GameCamera.transform.rotation;

				}
				else
				{
					// Lerp second camera position/rotation to the second midpoint.
					SplitscreenCamera.transform.position = Vector3.Lerp(SplitscreenCamera.transform.position, midPoint2 + new Vector3(0f + camXPos_offset, 6f + camYPos_offset, -5f + camZPos_offset), Time.deltaTime * lerpTime);

					Quaternion newRot2 = Quaternion.LookRotation(midPoint2 - SplitscreenCamera.transform.position);
					SplitscreenCamera.transform.rotation = Quaternion.Lerp(SplitscreenCamera.transform.rotation, newRot2, Time.deltaTime * lerpTime);
				}
			}
			else
			{
				// If it's NOT time to split, disable second quad and camera once distanceBetweenPlayers < SplitscreenDist.
				if (SplitQuadB.activeSelf)
					SplitQuadB.SetActive(false);
				SplitscreenCamera.SetActive(false);
			}

			// Lerp first camera position/rotation to the second midpoint (or when both players in view, lerp camera to their midpoint).
			GameCamera.transform.position = Vector3.Lerp(GameCamera.transform.position, midPoint + new Vector3(0f + camXPos_offset, 6f + camYPos_offset, -5f + camZPos_offset), Time.deltaTime * lerpTime);

			Quaternion newRot = Quaternion.LookRotation(midPoint - GameCamera.transform.position);
			GameCamera.transform.rotation = Quaternion.Lerp(GameCamera.transform.rotation, newRot, Time.deltaTime * lerpTime);
			Ydistance = Mathf.Abs(Player1.transform.position.y - Player2.transform.position.y);
			if (Ydistance >= 0f && Ydistance <= 0.4f && save2.isinshop == false)
			{
				camYPos_offset = 0.7f;
				SplitscreenCamera.GetComponent<Camera>().nearClipPlane = 1.8f;
				splitscreenDist = 5.8f;
			}
			else if (Ydistance >0.4f && Ydistance <= 4f && save2.isinshop == false)
			{
				camYPos_offset = 2f;
				SplitscreenCamera.GetComponent<Camera>().nearClipPlane = 2.3f;
				splitscreenDist = 5.8f;
			}
			else if (Ydistance > 4f && Ydistance <= 10f && save2.isinshop == false)
			{
				camYPos_offset = 4f;
				SplitscreenCamera.GetComponent<Camera>().nearClipPlane = 3f;
				splitscreenDist = 5.8f;
			}
			else if (Ydistance > 10f && save2.isinshop == false)
			{
				camYPos_offset = 7f;
				SplitscreenCamera.GetComponent<Camera>().nearClipPlane = 6f;
				splitscreenDist = 5.8f;
			}
			else if (save2.isinshop == true &&Ydistance>=20)
			{
				camYPos_offset = 1.5f;
				SplitscreenCamera.GetComponent<Camera>().nearClipPlane = 1.8f;
				splitscreenDist = 2f;
			}
			else if (save2.isinshop == true && Ydistance<20)
			{
				camYPos_offset = 5f;
				SplitscreenCamera.GetComponent<Camera>().nearClipPlane = 6f;
				splitscreenDist = 6f;
			}
		}
	}
}