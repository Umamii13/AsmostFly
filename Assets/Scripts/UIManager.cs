using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    [SerializeField] TextMeshProUGUI ScoreText;
    [SerializeField] TextMeshProUGUI LifeText;
    [SerializeField] GameObject Gameoverpanel;
    [SerializeField] GameObject Pausepanel;
    [SerializeField] TextMeshProUGUI ScoreTextInGameover;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score : " + GameManager.Instance.score.ToString("D6");
    }

    public void UpdateLife()
    {
        LifeText.text = "Life : " + GameManager.Instance.playerlife.ToString();
    }

    public void ShowGameOver()
    {
        Gameoverpanel.SetActive(true);
        ScoreTextInGameover.text = GameManager.Instance.score.ToString();
    }

    public void ShowPausePanel()
    {
        Pausepanel.SetActive(true);
    }

    public void HidePausepanel()
    {
        Pausepanel.SetActive(false);
    }
}
