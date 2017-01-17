using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gNashi;
    public GameObject gFullCombo;

    private GameObject[] gameList;
    private int gameIndex;

    void Awake()
    {
        gameList = new GameObject[2]
        {
            gNashi, gFullCombo
        };
        instance = this;
        DontDestroyOnLoad(gameObject);

        NewGame();
    }

    public void NewGame()
    {
        gameIndex = Random.Range(0, 2);
        Instantiate(gameList[gameIndex]);
    }

    private static GameManager instance = null;
    public static GameManager GetInstance
    {
        get
        {
            if (instance == null)
                instance = (new GameObject("GameManager")).AddComponent<GameManager>();
            return instance;
        }
    }
}