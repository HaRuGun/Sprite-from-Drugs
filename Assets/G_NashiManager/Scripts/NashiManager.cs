using UnityEngine;

public class NashiManager : MonoBehaviour
{
    public GameObject NashiAct;

    private float runningTime = 0;

    void Awake()
    {
        Transform transform = this.gameObject.transform;
        Instantiate(NashiAct, transform).transform.position =
            new Vector3(0.7f, 0.5f, -1.0f);
    }

    void Update()
    {
        runningTime++;
        if (runningTime >= 100)
        {
            GameManager.GetInstance.NewGame();
            DestroyObject(this.gameObject);
        }
    }
}