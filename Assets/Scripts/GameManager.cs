using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Transform collectiblesRoot;
    public TMP_Text counterText;
    public string nextSceneName = "Nivel2";
    int total;
    int got;

    void Start()
    {
        total = collectiblesRoot != null ? collectiblesRoot.childCount : 0;
        got = 0;
        UpdateUI();
    }

    public void OnCollected()
    {
        got++;
        UpdateUI();
        if (got >= total) SceneManager.LoadScene(nextSceneName);
    }

    void UpdateUI()
    {
        if (counterText != null) counterText.text = got + " / " + total;
    }
}

