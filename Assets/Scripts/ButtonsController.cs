using UnityEngine;
using System.Collections;

public class ButtonsController : MonoBehaviour {
    public Sprite LeftBttn;
    public Sprite RightBttn;
    public Sprite JumpBttn;
    private Transform _parent;

    // Use this for initialization
    void Start()
    {
        _parent = GetComponent<Transform>();
        for (int i = 0; i < 3; i++)
        {
            int key = i;
            GameObject newObj = new GameObject();
            newObj.transform.parent = _parent;
            switch (key)
            {
                case 0:
                    newObj.transform.position = new Vector2(-6.5f, -4); // "х" и "у" твои позиции кнопки
                    newObj.AddComponent<SpriteRenderer>().sprite = LeftBttn;
                    newObj.AddComponent<CircleCollider2D>();
                    newObj.AddComponent<ForBut>(); // "YoureScript" твой скрипт, который обрабатывает нажатия кнопок
                    newObj.name = "Left Button";
                    break;
                case 1:
                    newObj.transform.position = new Vector2(-5.3f,-4); // "х" и "у" твои позиции кнопки
                    newObj.AddComponent<SpriteRenderer>().sprite = RightBttn;
                    newObj.AddComponent<CircleCollider2D>();
                    newObj.AddComponent<ForBut>(); // "YoureScript" твой скрипт, который обрабатывает нажатия кнопок
                    newObj.name = "Right Button";
                    break;
                case 2:
                    newObj.transform.position = new Vector2(-5.92f, -3.13f); // "х" и "у" твои позиции кнопки
                    newObj.AddComponent<SpriteRenderer>().sprite = JumpBttn;
                    newObj.AddComponent<CircleCollider2D>();
                    newObj.AddComponent<ForBut>(); // "YoureScript" твой скрипт, который обрабатывает нажатия кнопок
                    newObj.name = "Jump Button";
                    break;
            }
        }
    }
}
