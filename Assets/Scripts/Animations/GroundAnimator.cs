using UnityEngine;

public class GroundAnimator : MonoBehaviour
{
    public Animator groundAnimator;
    void Start()
    {
        groundAnimator = GetComponent<Animator>();
    }

    public void GroundLeft()
    {
        groundAnimator.SetTrigger("TrGroundL");
    }

    public void GroundRight()
    {
        groundAnimator.SetTrigger("TrGroundR");
    }

    public void GroundScale()
    {
        groundAnimator.SetTrigger("TrGroundScale");
    }

    public void GroundUnScale()
    {
        groundAnimator.SetTrigger("TrGroundUnScale");
    }
}
