using UnityEngine;

public class DisplaySet : MonoBehaviour
{
    private SpriteRenderer sprRend;

    void Start()
    {
        sprRend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (sprRend.enabled)
                sprRend.enabled = false;
            else
                sprRend.enabled = true;
        }
    }
}
