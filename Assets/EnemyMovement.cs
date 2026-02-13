using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Animator Eanimator;
    public float speed = 2f;
    void start()
    {
        Eanimator = this.GetComponent<Animator>();
    }
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

