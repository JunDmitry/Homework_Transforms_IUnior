using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * Vector3.forward);
    }
}