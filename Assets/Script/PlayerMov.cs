using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float movespeed = 5f;
    public GameObject bullet;
    public Transform bulletOut;
    public float max = 4f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputAD = Input.GetAxis("Horizontal");
        Vector3 PlayerMovement = new Vector3(0, 0, -inputAD);
        Vector3 movement = transform.position += PlayerMovement * movespeed * Time.deltaTime;

        movement.z= Mathf.Clamp(movement.z, -max, max);
        transform.position = movement;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject NewBullet = Instantiate(bullet, bulletOut.position, Quaternion.identity);
            Destroy(NewBullet, 1.8f);
        }
    }
}
