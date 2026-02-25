# com.dave6.foundation
여러 프로젝트에서 재사용하기 위한
추상적 범용 로직 프레임워크.


## 목표

- 순수 C# 로직 기능
- Unity 의존성 최소화
- 단순한 구조 유지
- 공용으로 사용 가능

## 포함 기능

### StateMachine
- 인터페이스 기반 상태
- 게임플레이 로직에 사용 가능

```csharp
m_LocomotionStateMachine = new();
var freeLook = new FreeLookState(this);
var strafeMove = new StrafeMoveState(this);
m_LocomotionStateMachine.At(freeLook, strafeMove, new FuncPredicate(() => aimInput));
m_LocomotionStateMachine.At(strafeMove, freeLook, new FuncPredicate(() => !aimInput));
```


### Grid
- 엔진 독립적인 2D Grid 구조
- 제네릭 기반 셀 타입 지원

```csharp
grid = new Grid2D<ItemInstance>(columns, rows);

var found = grid.TryGetCell(coord, out var value) ? value : null;

public void Occupy(GridCoord origin, ItemInstance item)
{
    var rect = new GridRect(origin, new GridCoord(item.definition.width, item.definition.height));
    grid.SetCellRect(rect, item);
    RefreshDebug();
}
public void ReleaseItem(GridCoord origin, ItemInstance item)
{
    var rect = new GridRect(origin, new GridCoord(item.definition.width, item.definition.height));
    grid.ClearCellRect(rect);
    RefreshDebug();
}
```