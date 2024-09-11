using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20.0f;

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
