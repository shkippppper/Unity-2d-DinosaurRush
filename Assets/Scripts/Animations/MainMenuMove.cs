using UnityEngine;

public class MainMenuMove : MonoBehaviour
{
    public Animator MainMenuAnimator;

    void Start()
    {
        MainMenuAnimator = GetComponent<Animator>();
    }

    public void MainMenuMoveLeft()
    {
        MainMenuAnimator.SetTrigger("TrMainMoveLeft");
    }

    public void MainMenuMoveRight()
    {
        MainMenuAnimator.SetTrigger("TrMainMoveRight");
    }


    public void MainMenuCrMoveLeft()
    {
        MainMenuAnimator.SetTrigger("TrMainMenuCrLeft");
    }

    public void MainMenuCrMoveRight()
    {
        MainMenuAnimator.SetTrigger("TrMainMenuCrRight");
    }
}
