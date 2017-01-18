using UnityEngine;

public class SeatManager : MonoBehaviour
{
    public GameObject seat;
    public Sprite[] seatImage;

    void Awake()
    {
        Transform transform = this.gameObject.transform;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                GameObject seatDest = Instantiate(seat, transform);
                seatDest.GetComponent<SpriteRenderer>().sprite = seatImage[i * 4 + j];
                seatDest.transform.position = new Vector3(-3f + j * 2, 5.5f - i * 2, -1f);
            }
        }
    }
}