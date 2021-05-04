using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    AudioSource audioSource;

    [Header("Walking Sounds")]
    public int terrainSound = 1;
    public List<AudioClip> woodSounds;
    public List<AudioClip> grassSounds;
    public List<AudioClip> sandSounds;

    [Header("Jump Sounds")]
    public AudioClip startJumpSound;
    public AudioClip finalJumpSound;
    public float magnitudeVelocity;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Play Sound walking with the current platform
    public void PlaySoundWalk()
    {
        if (magnitudeVelocity <= 0.1f)
            return;


        switch (terrainSound)
        {
            case (2):
                Debug.Log("AUDIO: Wood Walk audio played :)");
                int randomWood = Random.Range(0, woodSounds.Count);
                for(int i = 0; i < woodSounds.Count; i++)
                {
                    if(i== randomWood)
                    {
                        audioSource.PlayOneShot(woodSounds[i]);
                    }
                }
                break;
            case (3):
                Debug.Log("AUDIO: Sand Walk audio played :)");
                int randomSand = Random.Range(0, sandSounds.Count);
                for (int i = 0; i < sandSounds.Count; i++)
                {
                    if (i == randomSand)
                    {
                        audioSource.PlayOneShot(sandSounds[i]);
                    }
                }
                break;
            default:
                Debug.Log("AUDIO: Grass Walk audio played :)");
                int randomGrass = Random.Range(0, grassSounds.Count);
                for (int i = 0; i < grassSounds.Count; i++)
                {
                    if (i == randomGrass)
                    {
                        audioSource.PlayOneShot(grassSounds[i]);
                    }
                }
                break;
        }
    }

    // Play Sound jump
    void PlayJumpSound(int state)
    {
        switch (state)
        {
            case (1):
                Debug.Log("AUDIO: Final jump sound played :)");
                audioSource.clip = startJumpSound;
                audioSource.Play();
                break;
            default:
                Debug.Log("AUDIO: Initial jump sound played :)");
                audioSource.clip = finalJumpSound;
                audioSource.Play();
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(transform.position + new Vector3(0,1,0), transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        {
            if (hit.collider != null)
            {
                if(hit.collider.gameObject.tag == "Wood")
                {
                    terrainSound = 2;
                }
                else if (hit.collider.gameObject.tag == "Sand")
                {
                    terrainSound = 3;
                }
                else
                {
                    terrainSound = 1;
                }
            }
        }
    }
}
