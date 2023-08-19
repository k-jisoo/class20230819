using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed; // 총알 이동 속력
    public float damage = 30f;

    public Rigidbody bulletRigidbody; // 총알에 사용할 리지드바디 컴포넌트


    // 게임과 시작과 동시에 1회 호출
    void Start()
    {
        speed = 100f;

        // 리지드바디의 속도 = 총알 앞쪽 방향 * 이동속력
        bulletRigidbody.velocity = transform.forward * speed;


        // 3초 뒤에 총알 스스로 자기를 삭제함
        Destroy(gameObject, t: 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Enemy>() == null)
            return;

        other.GetComponent<Enemy>().TakeDamage(damage);
    }



}