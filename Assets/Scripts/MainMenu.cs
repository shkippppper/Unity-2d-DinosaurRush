using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI hiscoreText;
    public TextMeshProUGUI hihiscoreText;


    // Start is called before the first frame update
    private void Start()
    {
        UpdateHiscore();
        UpdateHiHiscore();
    }

    private void UpdateHiscore()
    {
        float hiscore = PlayerPrefs.GetFloat("hiscore", 0);

        hiscoreText.text = Mathf.FloorToInt(hiscore).ToString("D5");
    }

    private void UpdateHiHiscore()
    {
        float hiscore = PlayerPrefs.GetFloat("hihiscore", 0);

        hihiscoreText.text = Mathf.FloorToInt(hiscore).ToString("D5");
    }
}
