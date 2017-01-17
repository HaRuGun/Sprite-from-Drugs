using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gNashi;
    public GameObject gFullCombo;

    private int gameIndex;

    void Awake()
    {
        gameIndex = Random.Range(0, 1);

        
    }
}