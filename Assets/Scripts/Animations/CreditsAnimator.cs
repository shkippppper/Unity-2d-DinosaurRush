using UnityEngine;

public class CreditsAnimator : MonoBehaviour
{
    public Animator creditsAnimator;
    void Start()
    {
        creditsAnimator = GetComponent<Animator>();
    }

    public void CreditsLeft()
    {
        creditsAnimator.SetTrigger("TrCreditsLeft");
    }

    public void CreditsRight()
    {
        creditsAnimator.SetTrigger("TrCreditsRight");
    }
}
