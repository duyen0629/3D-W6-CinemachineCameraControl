using UnityEngine;

public class Winning : MonoBehaviour // This script attached with the TriggerCube
{
    Animator anim;

    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            anim = player.GetComponent<Animator>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter Collision");
        anim.SetBool("win", true);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit Collision");
        anim.SetBool("win", false);
    }


    void Update()
    {

    }
}
