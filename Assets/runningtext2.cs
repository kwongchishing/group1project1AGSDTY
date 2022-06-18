using UnityEngine;public class runningtext2:MonoBehaviour{
    public AudioSource lightsound;public GameObject lightSkillSound, lightskill; void Start(){Destroy(this.gameObject,6);
        lightsound.Stop(); lightSkillSound.SetActive(false); lightskill.SetActive(false);
    }
}