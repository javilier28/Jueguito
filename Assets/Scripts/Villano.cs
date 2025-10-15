using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyChase : MonoBehaviour
{
    public Transform target;            // arrastra aquí el Player
    public string level1Name = "Nivel1";
    NavMeshAgent agent;

    void Awake(){ agent = GetComponent<NavMeshAgent>(); }
    void Update(){ if (target) agent.destination = target.position; }

    void OnCollisionEnter(Collision c){
        if (c.collider.CompareTag("Player")) SceneManager.LoadScene(level1Name);
    }
    void OnTriggerEnter(Collider o){
        if (o.CompareTag("Player")) SceneManager.LoadScene(level1Name);
    }
}

