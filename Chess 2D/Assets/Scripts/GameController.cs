using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject chessPiece;

    void Start()
    {
        Instantiate(chessPiece, new Vector3(-1, 0, 0), Quaternion.identity);
    }
}
