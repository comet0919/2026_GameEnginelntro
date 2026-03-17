using UnityEngine;



public class aaa : MonoBehaviour
{       
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Human man = new Human();
        man.name = "신구";
        man.age = 20;
        man.height = 180;
        man.kg = 70.2f;

        Human man2 = new Human();
        man2.name = "대학생";
        man2.age = 23;
        man2.height = 170.5f;
        man2.kg = 68.2f;


        man2.lntroduce();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Human
{
    public string name;
    public float height;
    public float kg;
    public int age;

    void Walk()
    {
        Debug.Log("걷기");
    }

    void Eat()
    {
        Debug.Log("먹기");
    }

    void Sleep()
    {
        Debug.Log("잠");
    }

    public void lntroduce()
    {
        Debug.Log("안년하세요. 제 이름은 :" + name + "입니다");
    }
}