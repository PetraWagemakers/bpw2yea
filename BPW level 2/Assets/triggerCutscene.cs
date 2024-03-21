
using UnityEngine;
using UnityEngine.Playables;

public class trigger_cutscene : MonoBehaviour
{
    public PlayableDirector afspelen;

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("trigger");
        if (collision.tag == "Player")
        {
            afspelen.Play();
        }
    }
}

