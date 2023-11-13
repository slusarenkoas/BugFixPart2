using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody _wallPrefab;
    
    private void Start()
    {
        var rigidbody =Instantiate(_wallPrefab);
        rigidbody.isKinematic = false;
    }
}
