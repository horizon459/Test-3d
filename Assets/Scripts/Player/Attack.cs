using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float force = 10f;
    public float dis = 10f;
    public Transform object1;
    public Transform object2;

    public void OnButtonClick()
    {
        Rigidbody2D rb2d = object2.GetComponent<Rigidbody2D>();
        float distance = Vector3.Distance(object1.position, object2.position);
        if (distance <= dis)
        {
            rb2d.AddForce((object2.transform.position - transform.position).normalized * force, ForceMode2D.Impulse); // отброс объекта вверх
        }
    }

}