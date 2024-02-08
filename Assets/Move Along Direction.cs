using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlongDirection : MonoBehaviour
{
    [SerializeField] Vector3 direction;
  [SerializeField] float speed = 1f;

  private void Update()
  {
    transform.Translate(direction.normalized * speed * Time.deltaTime);
  }
}
