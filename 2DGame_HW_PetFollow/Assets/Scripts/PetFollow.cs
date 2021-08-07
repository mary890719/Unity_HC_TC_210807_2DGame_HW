using UnityEngine;

public class PetFollow : MonoBehaviour
{
    [Header("³t«×"), Range(0, 1000)]
    public float speed = 7.5f;

    private Transform target;

    private void Start()
    {
        target = GameObject.Find("³¥ÆZ¤H¸òÀH").transform;
    }

    private void LateUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 posTarget = target.position;
        Vector3 posDragon = transform.position;

        transform.position = Vector3.Lerp(posDragon, posTarget, 0.5f * Time.deltaTime * speed);
        transform.rotation = target.rotation;
    }
}

