using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public float minSpeed = 1f;
    public float maxSpeed = 4;
    public AudioClip deathAudio;
    public Transform target;
    private NavMeshAgent agent;
    private Rigidbody[] ragdolls;

    // Start is called before the first frame update
    void Start()
    {
        ragdolls = GetComponentsInChildren<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        target = FindObjectOfType<UnityEngine.XR.Interaction.Toolkit.XRRig>().transform;

        GetComponent<Animator>().speed = Random.Range(minSpeed, maxSpeed);

        DisactivateRagdoll();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);

        if (Vector3.Distance(target.position, transform.position) < 1.5f)
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void Death()
    {
        ActivateRagdoll();
        agent.enabled = false;
        GetComponent<Animator>().enabled = false;
        GetComponent<AudioSource>().PlayOneShot(deathAudio);
        Destroy(gameObject, 5);
        Destroy(this);
    }

    void ActivateRagdoll()
    {
        foreach (var item in ragdolls)
        {
            item.isKinematic = false;
        }
    }

    void DisactivateRagdoll()
    {
        foreach (var item in ragdolls)
        {
            item.isKinematic = true;
        }
    }
}