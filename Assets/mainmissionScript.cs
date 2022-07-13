using UnityEngine;public class mainmissionScript : MonoBehaviour
{
    public save2 save2; public GameObject mainmission2descript,mainmission1descript;
    void Update()
    {
        if (save2.bull_kingisdead <1 && save2.bull_kingisdead1<1&& save2.bull_kingisdead2<1&& save2.bull_kingisdead3<1)
        {
            mainmission1descript.SetActive(true);
        }
        if (save2.bull_kingisdead > 0 && save2.bull_kingisdead1 > 0 && save2.bull_kingisdead2 > 0 && save2.bull_kingisdead3 > 0)
        {
            mainmission1descript.SetActive(false);
            mainmission2descript.SetActive(true);
        }
    }
}