using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public Rigidbody rigidBody;
    MeshRenderer mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<MeshRenderer>();
        var player = GameObject.FindGameObjectWithTag("Player");
        var currentColor = player.GetComponent<FunctionTest>().currentColor;
        mat.material.color = currentColor;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemy") && collision.GetComponent<Enemy>().meshRenderer.material.color.Equals(mat.material.color))
        {
            Destroy(collision.gameObject);

        }
        Destroy(gameObject);

    }

}
