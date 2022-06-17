using UnityEngine;
using System.Collections;

public class Ghost00 : MonoBehaviour
{
    public Transform Player;
    public int MoveSpeed = 4;
    public int MinDist = 1;
    public int MaxDist = 2;
    public AudioClip scareSound;
    public bool played = false;

    void Update()
    {
        //Moves toward player
        transform.LookAt(Player);
        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            makeHimScream();

            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                Destroy(this.gameObject);

            }
        }
    }

    void makeHimScream()
    {
        if (!played)
        {
            played = true;
            GetComponent<AudioSource>().PlayOneShot(scareSound);
        }
    }
}
