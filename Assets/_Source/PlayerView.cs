using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PlayerView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _hpText;
    [SerializeField] Material _material;
    private const string OBSTACLE_TAG = "Obstacle";
    public UnityEvent onCollision = new UnityEvent();

    private void Start()
    {
        _material.SetColor("_Color", Color.green);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(OBSTACLE_TAG))
        {
            Debug.Log("Collision!");
            onCollision.Invoke();
        }
    }

    public void MoveHorizontally(float speed)
    {
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
    }

    public void MoveVertically(float speed)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
    }

    public void DrawPlayerDamaged()
    {
        StopCoroutine(DrawDamagedPlayerCor());
        StartCoroutine(DrawDamagedPlayerCor());
    }

    private IEnumerator DrawDamagedPlayerCor()
    {
        _material.SetColor("_Color", Color.red);
        yield return new WaitForSeconds(0.5f);
        _material.SetColor("_Color", Color.green);

    }

    public void RefreshHpText(int hp)
    {
        _hpText.text = hp.ToString();
    }
}
