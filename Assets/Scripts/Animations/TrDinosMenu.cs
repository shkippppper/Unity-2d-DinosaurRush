using UnityEngine;

public class TrDinosMenu : MonoBehaviour
{
    public Animator dinosMenuAnimator;
    // Start is called before the first frame update
    void Start()
    {
        dinosMenuAnimator = GetComponent<Animator>();
    }

    public void DinosMenuOn()
    {
        dinosMenuAnimator.SetTrigger("TrDinosMenuOn");
    }

    public void DinosMenuOff()
    {
        dinosMenuAnimator.SetTrigger("TrDinosMenuOff");
    }

}
