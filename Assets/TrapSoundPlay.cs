using UnityEngine;public class TrapSoundPlay:MonoBehaviour{
    public AudioSource spear,Blade2sound,Blade3sound,Blade1sound,axe360Sound,hammer360sound;
    public void Trap1(){
        spear.Play();
    }
    public void Blade2(){
        Blade2sound.Play();
    }
    public void Blade3(){
        Blade3sound.Play();
    }
    public void Blade1(){
        Blade1sound.Play();
    }
    public void axe360Trap(){
        axe360Sound.Play();
    }
    public void hammer360(){
        hammer360sound.Play();
    }
}