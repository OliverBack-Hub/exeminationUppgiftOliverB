using UnityEngine;
using UnityEngine.InputSystem;

public class Keybind : MonoBehaviour
{
    public InputActionAsset PlayerAction;
    public Animator PlayerAnimator;
    
    
    void Update()
    {
        if (PlayerAction.FindAction("Move").IsPressed())
        {
            PlayerAnimator.SetBool("Run", true);
        }
        else
            PlayerAnimator.SetBool("Run", false);
        
        if (PlayerAction.FindAction("Fire").IsPressed())
        {
            PlayerAnimator.SetBool("Jump", true);
        }
        else
        {
            PlayerAnimator.SetBool("Jump", false);
        }

    }
}
