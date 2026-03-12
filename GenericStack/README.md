# 제네릭 스택 (GenericStack)

## 난이도

⭐⭐

## 선행 학습

- 제네릭 클래스 정의 및 사용
- 배열 기반 자료구조
- 속성 (Properties)
- `default(T)` 키워드

## 문제

고정 크기 배열을 기반으로 동작하는 제네릭 스택 클래스를 만드세요.

### 요구사항

**`SimpleStack<T>` 클래스**

- 생성자에서 용량(capacity)을 지정받아 고정 크기 배열 생성
- `Push(T item)`: 스택에 아이템 추가. 가득 차면 `"스택이 가득 찼습니다."` 출력 후 무시
- `Pop()`: 최상단 아이템을 제거하고 반환. 비어있으면 `"스택이 비어있습니다."` 출력 후 `default(T)` 반환
- `Peek()`: 최상단 아이템을 반환 (제거하지 않음). 비어있으면 `"스택이 비어있습니다."` 출력 후 `default(T)` 반환
- `Count` 속성: 현재 저장된 아이템 수 (읽기 전용)
- `IsFull` 속성: 스택이 가득 찼는지 여부 (읽기 전용)
- `IsEmpty` 속성: 스택이 비어있는지 여부 (읽기 전용)

**테스트**

1. 용량 3인 `SimpleStack<int>` 생성 후 Push/Pop/Peek 테스트 (오버플로우 포함)
2. 용량 2인 `SimpleStack<string>` 생성 후 Push/Pop 테스트 (언더플로우 포함)

## 예상 실행 결과

```
=== int 스택 (용량: 3) ===
Push: 10, 20, 30
Count: 3, IsFull: True
스택이 가득 찼습니다.
Peek: 30
Pop: 30
Pop: 20
Count: 1, IsEmpty: False

=== string 스택 (용량: 2) ===
Push: Hello, World
Pop: World
Pop: Hello
스택이 비어있습니다.
Pop:
IsEmpty: True
```

## 힌트

<details>
<summary>힌트 보기</summary>

- 내부 배열 `T[] _items`와 현재 인덱스 `int _count`를 필드로 사용
- `Push` 시 `_items[_count]`에 저장 후 `_count++`
- `Pop` 시 `_count--` 후 `_items[_count]` 반환
- `Peek` 시 `_items[_count - 1]` 반환 (제거 없음)

</details>
