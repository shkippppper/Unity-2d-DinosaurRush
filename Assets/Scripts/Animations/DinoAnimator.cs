using UnityEngine;

public class DinoAnimator : MonoBehaviour
{
    public Animator dinoAnimator;

    private void Start()
    {
        dinoAnimator = GetComponent<Animator>();
    }


    public void DinoLeft()
    {
        dinoAnimator.SetTrigger("TrDinoLeft");
    }

    public void DinoRight()
    {
        dinoAnimator.SetTrigger("TrDinoRight");
    }

    public void DinoRunRight()
    {
        dinoAnimator.SetTrigger("TrDinoRunRight");
    }

    public void DinoRunLeft()
    {
        dinoAnimator.SetTrigger("TrDinoRunLeft");
    }


    public void DinoScale()
    {
        dinoAnimator.SetTrigger("TrDinoScale");
    }

    public void DinoUnScale()
    {
        dinoAnimator.SetTrigger("TrDinoUnScale");
    }
}
