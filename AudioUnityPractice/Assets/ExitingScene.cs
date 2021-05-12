using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ExitingScene : MonoBehaviour
{
    public AudioMixerSnapshot mainSnapshot;
    public AudioMixerSnapshot outOfSceneSnapshot;
    public AudioMixerSnapshot insideHouseSnapshot;
    public AudioMixerSnapshot nearHumanSnapshot;
    public AudioMixerSnapshot tensionSnapshot;
    public Collider sphereCollider;
    public Collider houseCollider;
    public Collider tableCollider;
    public Collider emptyHouseCollider;
    public Collider emptyHouseCollider2;
    private void OnTriggerExit(Collider collider)
    {
        if (collider == sphereCollider)
            outOfSceneSnapshot.TransitionTo(1f);
        if (collider == houseCollider)
            mainSnapshot.TransitionTo(0.3f);
        if (collider == emptyHouseCollider)
            mainSnapshot.TransitionTo(0.3f);
        if (collider == tableCollider)
            mainSnapshot.TransitionTo(0.1f);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider == sphereCollider)
            mainSnapshot.TransitionTo(0.5f);
        if (collider == houseCollider)
            insideHouseSnapshot.TransitionTo(0.1f);
        if (collider == emptyHouseCollider2)
            tensionSnapshot.TransitionTo(0.1f);
        if (collider == tableCollider)
            nearHumanSnapshot.TransitionTo(0.1f);
    }
}
