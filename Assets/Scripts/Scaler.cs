using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        Vector3 scale = transform.localScale;
        float scaleStep = _scaleSpeed * Time.deltaTime;

        transform.localScale = new(scale.x + scaleStep, scale.y + scaleStep, scale.z + scaleStep);
    }
}