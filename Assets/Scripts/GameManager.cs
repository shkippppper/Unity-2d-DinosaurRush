using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float initialGameSpeed = 5f;

    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed { get; private set; }

    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiscoreText;
    public TextMeshProUGUI hihiscoreText;
    public TextMeshProUGUI nameText;
    public Button retryButton;
    public GameObject SubmitButton;
    public GameObject Scorer;

    
    private Player player;
    private Spawner spawner;


    public float score;
    private void Awake()
    {

        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
        }


    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {
        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();

        NewGame();

    }

    public void NewGame()
    {
        Obstacle[] obstacles = FindObjectsOfType<Obstacle>();

        foreach (var obstacle in obstacles)
        {
            Destroy(obstacle.gameObject);
        }

        score = 0f;

        gameSpeed = initialGameSpeed;
        enabled = true;

        player.gameObject.SetActive(true);
        spawner.gameObject.SetActive(true);

        gameOverText.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);
        SubmitButton.gameObject.SetActive(true);
        UpdateHiscore();

    }

    private void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.deltaTime;
        score += gameSpeed * Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString("D5");

    }

    public void GameOver()
    {
        gameSpeed = 0f;
        enabled = false;

        player.gameObject.SetActive(false);
        spawner.gameObject.SetActive(false);

        gameOverText.gameObject.SetActive(true);
        retryButton.gameObject.SetActive(true);
        UpdateHiscore();

    }

    private void UpdateHiscore()
    {
        if (Scorer.activeSelf) {
            float hiscore = PlayerPrefs.GetFloat("hiscore", 0);

            if (score > hiscore)
            {
                hiscore = score;
                PlayerPrefs.SetFloat("hiscore", hiscore);
            }

            hiscoreText.text = Mathf.FloorToInt(hiscore).ToString("D5");
        }
        else
        {
            float hihiscore = PlayerPrefs.GetFloat("hihiscore", 0);

            if (score > hihiscore)
            {
                hihiscore = score;
                PlayerPrefs.SetFloat("hihiscore", hihiscore);
            }

            hihiscoreText.text = Mathf.FloorToInt(hihiscore).ToString("D5");
        }
        
    }

    public void SendHiScore()
    {
        HighScores.UploadScore(nameText.text, Mathf.FloorToInt(score));
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void DisableSecondPress()
    {
        SubmitButton.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        //Scene scene = SceneManager.GetActiveScene();
        //SceneManager.LoadScene(scene.buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
