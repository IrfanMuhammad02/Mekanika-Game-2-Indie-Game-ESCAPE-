using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    private NavMeshAgent Mons;
    
    public GameObject BodyPlayer;

    public float kejaranmonster = 4.0f;  

    // Start is called before the first frame update
    void Start()
    {
        Mons = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float jarak = Vector3.Distance(transform.position, BodyPlayer.transform.position);

        if (jarak < kejaranmonster)
        {
            Vector3 arahPlayer = transform.position - BodyPlayer.transform.position;

            Vector3 PosBar = transform.position - arahPlayer;

            Mons.SetDestination(PosBar);    
        }
    }

}
