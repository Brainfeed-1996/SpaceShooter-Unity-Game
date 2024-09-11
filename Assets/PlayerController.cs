using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject projectilePrefab;
    public Transform firePoint;
    private bool isShieldActive = false;
    private int extraLives = 3;
    private Animator animator;

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
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }

    public IEnumerator SpeedBoost()
    {
        speed *= 2;
        yield return new WaitForSeconds(5);
        speed /= 2;
    }

    public void ActivateShield()
    {
        isShieldActive = true;
        // Ajouter des effets visuels pour le bouclier
    }

    public void GainExtraLife()
    {
        extraLives++;
    }
}
