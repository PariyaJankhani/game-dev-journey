using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
  [SerializeField] float speed = 0.1f;
  [SerializeField] float rotate = 2f;

    void Update()
    {
       float  move = 0f; float arrow=0f;
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
            

        }
        if (Keyboard.current.aKey.isPressed)
        {
            arrow = 1f;
           

        }
        if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
           

        }
        if (Keyboard.current.dKey.isPressed)
        {
            arrow = -1f;
            

        }

        float steerSpeed = arrow * rotate * Time.deltaTime, 
            moveAmount = move * speed * Time.deltaTime;
        
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0,moveAmount, 0);

    }
}
