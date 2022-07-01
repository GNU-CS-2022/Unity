# Transform.position

Transform.position은 게임오브젝트의 좌표를 나타낸다.

다음과 같은 코드를 통해 게임오브젝트를 이동시킬 수 있다.

```c#
transform.position = new Vector3(x, y, z);
```

# Vector3.MoveTowards

```c#
public Transform Target;
public float Speed = 1f;
void Update()
{
    transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
}
```
