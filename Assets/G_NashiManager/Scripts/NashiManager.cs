using UnityEngine;

public class NashiManager : MonoBehaviour
{
    public GameObject NashiAct;

    void Awake()
    {
        Instantiate(NashiAct).transform.position =
            new Vector3(0.7f, 0.5f, -1f);
    }
}