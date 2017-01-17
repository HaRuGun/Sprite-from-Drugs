using UnityEngine;

public class NoteBlood : MonoBehaviour
{
    public Sprite leftBlood;

    private float time = 0;
    private float leftTime = 0;
    private SpriteRenderer spRender;

    void Awake()
    {
        spRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        leftTime++;
        if (leftTime >= 3)
        {
            spRender.sprite = leftBlood;
            time++;
            if (time >= 3)
            {
                DestroyObject(this.gameObject);
            }
        }

    }
}
