using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject projectilePrefab;
    public Transform firePoint;
    private Animator animator;
    private bool isShieldActive = false;
    private int extraLives = 3;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        animator.SetBool("isShooting", Input.GetButton("Fire1"));
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
