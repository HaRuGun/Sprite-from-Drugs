using UnityEngine;

[System.Serializable]
public class PowerRange
{
    public float xMin, xMax, yMin, yMax;
    public float gPower;
}

public class NashiHead : MonoBehaviour
{
    public PowerRange powerRange;
    public GameObject blood;

    private Vector2 power;
    private Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        power.x = Random.Range(powerRange.xMin * powerRange.gPower, powerRange.xMax * powerRange.gPower);
        power.y = Random.Range(powerRange.yMin * powerRange.gPower, powerRange.yMax * powerRange.gPower);

        rb2d.AddForce(power);
    }

    void Update()
    {
        if (transform.position.y <= -6.9)
        {
            Instantiate(blood).transform.position = transform.position + new Vector3(0f, 2f);
            DestroyObject(this.gameObject);
        }
    }
}