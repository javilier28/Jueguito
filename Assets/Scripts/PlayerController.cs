using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    public string level1Name = "Level1";
    Rigidbody rb;
    Vector2 move;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 dir = new Vector3(move.x, 0f, move.y);
        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);
        if (transform.position.y < -10f) SceneManager.LoadScene(level1Name);
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }
}
