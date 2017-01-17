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
            if (noteCount > 0)
            {
                noteCount--;
                Transform transform = this.gameObject.transform;
                Instantiate(note, transform).transform.position =
                    new Vector3(Random.Range(-3f, 3f), 15f, -2f);

                runningTime = 0;
            }
            else if (runningTime >= 100)
            {
                GameManager.GetInstance.NewGame();
                DestroyObject(this.gameObject);
            }
        }
    }

    void FixedUpdate()
    {
        
    }
}