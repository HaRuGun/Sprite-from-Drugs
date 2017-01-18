using UnityEngine;

public class Seat : MonoBehaviour
{
    private SpriteRenderer spRender;
    private float startTime;
    private int delay;

    private int aICount;
    private int playerCount;

    void Awake()
    {
        spRender = GetComponent<SpriteRenderer>();
        startTime = Random.Range(1f, 1.5f);
    }

    void Update()
    {
        if (Time.time >= startTime)
        {
            delay++;
            if (delay >= 3)
            {
                spRender.color = new Color(
                    spRender.color.r - 0.2f,
                    spRender.color.g - 0.2f,
                    spRender.color.b - 0.2f
                    );

                aICount++;
                delay = 0;
            }
        }
    }

    void LateUpdate()
    {
        if (playerCount >= 5)
            delay = 0;
        if (aICount >= 5)
            DestroyObject(this.gameObject);
    }

    void OnMouseDown()
    {
        spRender.color = new Color(
            spRender.color.r - 0.2f,
            spRender.color.g - 0.2f,
            spRender.color.b - 0.2f
            );
        playerCount++;
    }
}