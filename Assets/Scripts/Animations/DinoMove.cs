using UnityEngine;

public class DinoMove : MonoBehaviour
{
    public Animator DinoMoveAnimator;

    void Start()
    {
        DinoMoveAnimator = GetComponent<Animator>();

    }

    public void DinoMoveLeft()
    {
        DinoMoveAnimator.SetTrigger("TrDinoMoveLeft");
    }
    public void DinoMoveRight()
    {
        DinoMoveAnimator.SetTrigger("TrDinoMoveRight");
    }


}
