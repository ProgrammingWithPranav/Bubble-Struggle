using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public GameObject deadMenuUI;

    public float speed = 4f;

    public Rigidbody2D rb;

    private float movement = 0f;

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal") * speed;
    }

	private void FixedUpdate()
	{
        rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime, 0f));
	}

    void OnCollisionEnter2D(Collision2D col)
	{
        if (col.collider.tag == "Ball")
		{
            deadMenuUI.SetActive(true);
            Time.timeScale = 0;
		}
	}
}
