using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
        
    void Update()
    {
        MovementInputs();
    }

    private void MovementInputs()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(x:inputX, 0, inputY);
        
        Move(direction);
    }
    
    private void Move(Vector3 direction)
    {
        transform.position += direction * (moveSpeed * Time.deltaTime);
    }
    
    private void Rotate(float input)
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * input * rotateSpeed), Space.Self);
    }
}

