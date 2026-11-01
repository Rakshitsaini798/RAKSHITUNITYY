
// using UnityEngine;
// using UnityEngine.InputSystem;

// public class Catcher : MonoBehaviour
// {
//     public float speed = 10f;
//     public float limit = 7.8f;

//     void Start()
//     {
//     }

//     void Update()
//     {
//         float input = 0f;

//         if (Keyboard.current.leftArrowKey.isPressed)
//             input = -1f;

//         if (Keyboard.current.rightArrowKey.isPressed)
//             input = 1f;

//         transform.Translate(
//             speed * input * Vector3.right * Time.deltaTime
//         );

//         Vector3 pos = transform.position;

//         pos.x = Mathf.Clamp(pos.x, -limit, limit);

//         transform.position = pos;
//     }
// }



using UnityEngine;
using UnityEngine.InputSystem;

public class Catcher : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float input = 0f;

        if (Keyboard.current.leftArrowKey.isPressed)
            input = -1f;

        if (Keyboard.current.rightArrowKey.isPressed)
            input = 1f;

        transform.Translate(
            speed * input * Vector3.right * Time.deltaTime
        );

        Vector3 pos = transform.position;

        float leftEdge = Camera.main.ViewportToWorldPoint(
            new Vector3(0, 0.5f, -Camera.main.transform.position.z)
        ).x;

        float rightEdge = Camera.main.ViewportToWorldPoint(
            new Vector3(1, 0.5f, -Camera.main.transform.position.z)
        ).x;

        float width = GetComponent<SpriteRenderer>().bounds.extents.x;

        pos.x = Mathf.Clamp(
            pos.x,
            leftEdge + width,
            rightEdge - width
        );

        transform.position = pos;
    }
}
