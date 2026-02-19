using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Animator Eanimator;
    public float speed = 0.01f;
    void Start()
    {
        Eanimator = this.GetComponent<Animator>();
    }
    void Update()
    {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

