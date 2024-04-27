using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBot : MonoBehaviour
{
    public float force = 10f;
    public float dis = 10f;
    public Transform object1;
    public Transform object2;

    public void Update()
    {
        Rigidbody2D rb2d = object2.GetComponent<Rigidbody2D>();
        float distance = Vector3.Distance(object1.position, object2.position);
        if (Vector3.Distance(object2.transform.position, transform.position) <= dis)
        {
            Debug.Log("dis");
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce((object2.transform.position - transform.position).normalized * force, ForceMode2D.Impulse); // отброс объекта вверх
        }
    }

}
