using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullPickUp : MonoBehaviour
{
    public Rigidbody rb;
    public CapsuleCollider cc;
    public Transform player, skullcontainer;
    public AudioSource skullaudio;
    public AudioSource evilinside;

    public float pickuprange;

    public bool carrying;

    private void Update()
    {
        Vector3 distanceToPlayer = player.position - transform.position;
        if (!carrying && distanceToPlayer.magnitude <= pickuprange && Input.GetKeyDown(KeyCode.E)) PickUp();
    }
    private void PickUp()
    {
        carrying = true;

        transform.SetParent(skullcontainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = new Vector3(35, 35, 35);


        skullaudio.Stop();
        evilinside.Play();

    }
}
