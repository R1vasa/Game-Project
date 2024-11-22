using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public CharacterController controller;
    public Transform bulletOut;
    public GameObject bullet;
    public float movespeed;
    public float max = 4f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputAD = Input.GetAxisRaw("Horizontal");
        Vector3 inputWASD = new Vector3();
        inputWASD.z = -inputAD;

        Vector3 directionOutput = transform.position+(movespeed*inputWASD*Time.deltaTime);
        directionOutput.z=Mathf.Clamp(directionOutput.z, -max, max);
        transform.position = directionOutput;

        

        if (Input.GetMouseButtonDown(0))
        {
            GameObject NewBullet = Instantiate(bullet, bulletOut.position, Quaternion.identity);
            Destroy(NewBullet, 1.8f);
        }
    }
}
