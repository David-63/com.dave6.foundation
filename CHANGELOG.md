## [0.0.4] - 2025.04.18

## [Refactor] State transition control via state-driven rules

### Changed
- IState에 전환 제어 메서드 추가
  - CanBeOverridden()
  - CanOverrideBy(IState next)
  - CanExit()
- 상태 수준 규칙을 준수하도록 StateMachine 전환 로직 수정

### Notes
- 전환 책임을 StateMachine에서 개별 State가 일부 구현하는 식으로 변경됨
- 재정의 기반으로 상태 제어 가능