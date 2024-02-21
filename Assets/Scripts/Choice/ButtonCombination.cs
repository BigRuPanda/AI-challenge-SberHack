using UnityEngine;
using UnityEngine.UI;

public class ButtonCombination : MonoBehaviour
{
public int counter = 0; // Счетчик
public GameObject n1;
public GameObject n2;
public GameObject n3;
public GameObject n4;
public GameObject n5;
public GameObject n6;
public GameObject n7;
public GameObject n8;
public GameObject n9;
public Collider n21;
public Collider n22;
public Collider n23;
public Collider n24;
public Collider n25;
public Collider n26;



    public void Function1()
    {
        counter += 1;
        CheckCounter();
        n21.enabled = false;
        n22.enabled = false;
        n23.enabled = false;
    }

    public void Function2()
    {
        counter -= 50;
        CheckCounter();
        n21.enabled = false;
        n22.enabled = false;
        n23.enabled = false;
    }

    public void Function3()
    {
        counter -= 15;
        CheckCounter();
        n21.enabled = false;
        n22.enabled = false;
        n23.enabled = false;
    }

    public void Function4()
    {
        counter += 4;
        CheckCounter();
        n24.enabled = false;
        n25.enabled = false;
        n26.enabled = false;

    }

    public void Function5()
    {
        counter += 6;
        CheckCounter();
        n24.enabled = false;
        n25.enabled = false;
        n26.enabled = false;
    }

    public void Function6()
    {
        counter += 8;
        CheckCounter();
        n24.enabled = false;
        n25.enabled = false;
        n26.enabled = false;
    }

    public void CheckCounter()
    {
        if (counter == 5)
        {
            n1.SetActive(true);
            n21.enabled = false;
            n22.enabled = false;
            n23.enabled = false;
            n24.enabled = false;
            n25.enabled = false;
            n26.enabled = false;
       
        }
        else if (counter == 7)
        {
            n2.SetActive(true);
            n21.enabled = false;
            n22.enabled = false;
            n23.enabled = false;
            n24.enabled = false;
            n25.enabled = false;
            n26.enabled = false;
         
        }
        else if (counter == 9)
        {
            n3.SetActive(true);
            n21.enabled = false;
            n22.enabled = false;
            n23.enabled = false;
            n24.enabled = false;
            n25.enabled = false;
            n26.enabled = false;
         
        }
        else if (counter == -46)
        {
           n4.SetActive(true);
           n21.enabled = false;
            n22.enabled = false;
            n23.enabled = false;
            n24.enabled = false;
            n25.enabled = false;
            n26.enabled = false;
           
        }
        else if (counter == -44)
        {
            n5.SetActive(true);
            n21.enabled = false;
            n22.enabled = false;
            n23.enabled = false;
            n24.enabled = false;
            n25.enabled = false;
            n26.enabled = false;
      
        }
        else if (counter == -42)
        {
            n6.SetActive(true);
            n21.enabled = false;
            n22.enabled = false;
            n23.enabled = false;
            n24.enabled = false;
            n25.enabled = false;
            n26.enabled = false;
           
        }

        else if (counter == -11)
        {
            n7.SetActive(true);
            n21.enabled = false;
            n22.enabled = false;
            n23.enabled = false;
            n24.enabled = false;
            n25.enabled = false;
            n26.enabled = false;
            
        }
        else if (counter == -9)
        {
            n8.SetActive(true);
            n21.enabled = false;
            n22.enabled = false;
            n23.enabled = false;
            n24.enabled = false;
            n25.enabled = false;
            n26.enabled = false;
            
        }
        else if (counter == -7)
        {
            n9.SetActive(true);
            n21.enabled = false;
            n22.enabled = false;
            n23.enabled = false;
            n24.enabled = false;
            n25.enabled = false;
            n26.enabled = false;
        }
    }

}