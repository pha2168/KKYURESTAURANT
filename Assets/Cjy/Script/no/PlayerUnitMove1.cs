using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitMove1 : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D playerRigidbody;

    public GameObject playerbulletprefab;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerRigidbody.velocity = new Vector2(speed, 0);

        Destroy(gameObject, 20f);

    }


    // Update is called once per frame
    void Update()
    {

    }
}