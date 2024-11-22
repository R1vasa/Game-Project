using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float movespeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * movespeed * Time.deltaTime;
    }
}
