using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public GameObject note;
    public int noteCount = 4;

    private float runningTime = 0;

    void Update()
    {
        runningTime++;
        if (runningTime >= 40)
        {
            runningTime = 0;

            if (noteCount <= 0)
                return;
            noteCount--;

            Instantiate(note).transform.position =
                new Vector3(Random.Range(-3f, 3f), 15f, -2f);
        }
    }
}