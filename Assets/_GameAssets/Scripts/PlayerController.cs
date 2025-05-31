using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform _orientationTransform;
    private Rigidbody _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
