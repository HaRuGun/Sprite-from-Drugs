using UnityEngine;

public class Fire : MonoBehaviour
{
    public Sprite fire0;
    public Sprite fire1;

    private SpriteRenderer spRender;
    private float time;

    void Awake()
    {
        spRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (spRender.sprite == fire0)
            spRender.sprite = fire1;
        else
            spRender.sprite = fire0;
    }
}