using UnityEngine;

public class NashiAct : MonoBehaviour
{
    public GameObject nashiHead;
    public GameObject nashiBlood;
    public Sprite nashiAct;

    private int score = 0;
    private bool onAni = false;
    private float aniTime = 0;

    private BoxCollider2D bc2d;
    private Animator ani;

    void Awake()
    {
        ani = GetComponent<Animator>();
        bc2d = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (score >= 3)
        {
            Transform transform = this.gameObject.transform;
            Instantiate(nashiHead, transform).transform.position =
                new Vector3(0.2f, 5.5f, -4f);
            score = 0;
        }

        if (aniTime >= 6 && ani)
        {
            onAni = false;
            aniTime = 0;
        }
        else
            aniTime++;
        
        ani.enabled = onAni;
        if (!onAni)
            GetComponent<SpriteRenderer>().sprite = nashiAct;
    }

    void OnMouseDown()
    {
        onAni = true;
        aniTime = 0;

        if (bc2d.offset.x > 0)
            bc2d.offset = new Vector2(-3.4f, -0.7f);
        else
            bc2d.offset = new Vector2(2.4f, -0.7f);
        score++;
    }
}
