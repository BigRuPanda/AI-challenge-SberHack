using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroCounterForMusic : MonoBehaviour
{
    private Collider myCollider; // Ссылка на коллайдер объекта
    public ButtonCombinationForMusic buttonCombination; // Ссылка на скрипт счетчика
    public Collider n21;
    public Collider n22;
    public Collider n23;
    public Collider n24;
    public Collider n25;
    public Collider n26;
    public Material newMaterial;
    public Material originalMaterial21;
    public Renderer objectRenderer21;
    public Renderer objectRenderer22;
    public Material originalMaterial22;
    public Renderer objectRenderer23;
    public Material originalMaterial23;
    public Renderer objectRenderer24;
    public Material originalMaterial24;
    public Renderer objectRenderer25;
    public Material originalMaterial25;
    public Renderer objectRenderer26;
    public Material originalMaterial26;
    public GameObject n1;
    public GameObject n2;
    public GameObject n3;
    public GameObject n4;
    public GameObject n5;
    public GameObject n6;
    public GameObject n7;
    public GameObject n8;

    private void Start()
    {
        // Получаем компонент коллайдера
        myCollider = GetComponent<Collider>();

    }

    private void OnMouseDown()
    {
        // Обнуляем счетчик при клике на коллайдер
        buttonCombination.counter = 0;
        n1.SetActive(false);
        n2.SetActive(false);
        n3.SetActive(false);
        n4.SetActive(false);
        n5.SetActive(false);
        n6.SetActive(false);
        n7.SetActive(false);
        n8.SetActive(false);
        n21.enabled = true;
        n22.enabled = true;
        n23.enabled = true;
        n24.enabled = true;
        n25.enabled = true;
        n26.enabled = true;
        originalMaterial21 = objectRenderer21.material;
        objectRenderer21.material = newMaterial;
        originalMaterial22 = objectRenderer22.material;
        objectRenderer22.material = newMaterial;
        originalMaterial23 = objectRenderer23.material;
        objectRenderer23.material = newMaterial;
        originalMaterial24 = objectRenderer24.material;
        objectRenderer24.material = newMaterial;
        originalMaterial25 = objectRenderer25.material;
        objectRenderer25.material = newMaterial;
        originalMaterial26 = objectRenderer26.material;
        objectRenderer26.material = newMaterial;
    }

    // Другие методы и логика вашего скрипта
}

