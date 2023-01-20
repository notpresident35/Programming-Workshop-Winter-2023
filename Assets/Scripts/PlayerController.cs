using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject BulletPrefab;
    public AnimationCurve SpawnCooldownOverTime;
    public float MoveSpeed;
    public float MinX;
    public float MaxX;

    private float spawnCooldown = 0;

    void Update()
    {
        HandleMovement();
        

        HandleShooting();


        spawnCooldown -= Time.deltaTime;
    }

    void HandleMovement()
    {
        Vector3 moveDir = Vector3.zero;

        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > MinX)
        {
            moveDir = Vector3.left;
        }

        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < MaxX)
        {
            moveDir = Vector3.right;
        }

        transform.Translate(moveDir * MoveSpeed * Time.deltaTime);
    }

    void HandleShooting()
    {
        Vector3 moveDir = Vector3.zero;
        if ((Input.GetKey(KeyCode.W)))
        {
            Instantiate(BulletPrefab, Vector3.zero,
                Quaternion.identity, null);
            moveDir = Vector3.down;

        }

    }
}
