using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<float> OnHorizontalArrow = new UnityEvent<float>();
    public UnityEvent<float> OnVerticalArrow = new UnityEvent<float>();
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            OnHorizontalArrow.Invoke(Input.GetAxis("Horizontal"));
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            OnVerticalArrow.Invoke(Input.GetAxis("Vertical"));
        }
    }
}
