using UnityEngine;

public class NoteSprite : MonoBehaviour
{
    public float speed = 5;
    public Sprite spriteBurst;
    public GameObject blood;

    private SpriteRenderer spRender;
    private bool burst = false;
    private float leftTime = 0;

    void Awake()
    {
        spRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (burst)
        {
            spRender.sprite = spriteBurst;
            leftTime++;
            if (leftTime >= 6)
                DestroyObject(this.gameObject);
        }
        else
            transform.Translate(0f, -1 * speed * Time.deltaTime, 0f);

        if (transform.position.y <= -13)
            DestroyObject(this.gameObject);
    }

    void OnMouseDown()
    {
        if (transform.position.y <= -2 && transform.position.y >= -3.3)
        {
            burst = true;
            Instantiate(blood).transform.position =
                new Vector3(this.transform.position.x, this.transform.position.y - 1.5f);
        }
    }
}