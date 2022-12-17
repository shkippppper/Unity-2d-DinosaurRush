using UnityEngine;

public class CreditsUI : MonoBehaviour
{


    private Animator textAnimator;



    private void Start()
    {
        textAnimator = GetComponent<Animator>();

    }
    public void CreditsON()
    {
        textAnimator.SetTrigger("TrHighOn");



    }

    public void CreditsOFF()
    {
        textAnimator.SetTrigger("TrHighOff");


    }


}
