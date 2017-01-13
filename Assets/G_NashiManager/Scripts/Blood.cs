using UnityEngine;

public class Blood : MonoBehaviour
{
    private int time = 0;

    void Awake()
    {
        transform.localScale = new Vector3(2f, Random.Range(-1f, -1.5f));
    }

    void Update()
    {
        time++;
        if (time >= 18)
            DestroyObject(this.gameObject);
    }
}