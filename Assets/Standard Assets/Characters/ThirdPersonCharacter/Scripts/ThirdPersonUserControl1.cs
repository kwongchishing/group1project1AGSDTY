using System;
using UnityEngine;using UnityStandardAssets.CrossPlatformInput;namespace UnityStandardAssets.Characters.ThirdPerson{[RequireComponent(typeof (ThirdPersonCharacter))]public class ThirdPersonUserControl1:MonoBehaviour{
        public GameObject runsound,turnsound,turnsound2;private ThirdPersonCharacter m_Character;private Transform m_Cam;private Vector3 m_CamForward,m_Move;private bool m_Jump;Animator anim;public GameObject lightHand,HeavyHand,player;private void Start(){anim=GetComponent<Animator>();
            if(Camera.main!=null){m_Cam = Camera.main.transform;}
            m_Character = GetComponent<ThirdPersonCharacter>();}private void Update(){if(!m_Jump){m_Jump = Input.GetKeyDown(KeyCode.Keypad0);}
            }private void FixedUpdate(){float h=Input.GetAxis("Horizontal2");float v = Input.GetAxis("Vertical2");bool crouch = Input.GetKey(KeyCode.M);if(m_Cam!=null){m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;m_Move = v*m_CamForward + h*m_Cam.right;}else{m_Move = v*Vector3.forward + h*Vector3.right;}
           /* if(Input.GetKey(KeyCode.Keypad8) &&this.anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")&&!Input.GetKey(KeyCode.RightShift)){
                runsound.SetActive(true);
            }
            else{
                runsound.SetActive(false);
            }           
            if(Input.GetKey(KeyCode.RightShift)&&(Input.GetKey(KeyCode.Keypad4) |Input.GetKey(KeyCode.Keypad6) |Input.GetKey(KeyCode.Keypad8) |Input.GetKey(KeyCode.Keypad5))&&this.anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")){
                turnsound.SetActive(true);
            }
            else{
                turnsound.SetActive(false);
            }
            if(!Input.GetKey(KeyCode.RightShift)&&(Input.GetKey(KeyCode.Keypad4)|Input.GetKey(KeyCode.Keypad6)|Input.GetKey(KeyCode.Keypad5))&&this.anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")){
                turnsound2.SetActive(true);
            }
            else{
                turnsound2.SetActive(false);
            }*/
#if !MOBILE_INPUT
          //  if(Input.GetKey(KeyCode.RightShift)) m_Move*=0.5f;
#endif
            m_Character.Move(m_Move,crouch,m_Jump);m_Jump=false;}}}