using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed; // �Ѿ� �̵� �ӷ�
    public float damage = 30f;

    public Rigidbody bulletRigidbody; // �Ѿ˿� ����� ������ٵ� ������Ʈ


    // ���Ӱ� ���۰� ���ÿ� 1ȸ ȣ��
    void Start()
    {
        speed = 100f;

        // ������ٵ��� �ӵ� = �Ѿ� ���� ���� * �̵��ӷ�
        bulletRigidbody.velocity = transform.forward * speed;


        // 3�� �ڿ� �Ѿ� ������ �ڱ⸦ ������
        Destroy(gameObject, t: 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Enemy>() == null)
            return;

        other.GetComponent<Enemy>().TakeDamage(damage);
    }



}