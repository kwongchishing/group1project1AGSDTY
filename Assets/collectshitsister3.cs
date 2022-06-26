using UnityEngine;
public class collectshitsister3: MonoBehaviour
{
    public GameObject shit;
    public save2 save2;
    public petlove3 petlove;
    public AudioSource getitem;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            getitem.Play();
            shit.SetActive(false);
            save2.shitcount++;
            petlove.isshit = false;
            this.gameObject.SetActive(false);
        }
    }
}