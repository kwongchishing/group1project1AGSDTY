using UnityEngine;public class mainmissionScript : MonoBehaviour
{
    public save2 save2; public GameObject mainmission1descript;
    void Update()
    {
        if (save2.mainmission1finish < 1)
        {
            mainmission1descript.SetActive(true);
        }
    }
}