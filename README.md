# 🌱 Evo Farm

> **농작물 성장 · 인벤토리 · 상점 · NPC 상호작용을 구현한 2D Unity Farming 프로젝트**

<p>
  <img src="https://img.shields.io/badge/Unity-2022.3.7f1-000000?logo=unity&logoColor=white" />
  <img src="https://img.shields.io/badge/C%23-512BD4?logo=csharp&logoColor=white" />
  <img src="https://img.shields.io/badge/Genre-Farming%20%2F%20Simulation-69b34c" />
</p>

## 🌾 About

여러 종류의 작물을 키우고 수확하며, NPC·상점·인벤토리와 상호작용하는 **2D 농장 게임 시스템**을 구현한 프로젝트입니다.

## ✨ Features

- 🌱 작물 종류 및 성장 상태 관리
- 🎒 아이템 / 인벤토리 시스템
- 🛒 판매 버튼과 상점 시스템
- 🧑‍🌾 NPC 상호작용 구조
- 💬 대화 시스템 및 타이핑 효과
- 🏷 닉네임 설정
- 🔊 사운드 관리
- 🧭 Scene 전환 및 UI 관리
- 📋 퀘스트 확장을 위한 기본 구조

### 구현된 작물 타입

`Bamboo` · `Weed` · `Potato` · `Rose` · `Cistus` · `Sweet Potato` · `Wild Ginseng` · `Corn` · `Apple` · `Peach`

## 🛠 Tech Stack

| Category | Technology |
| --- | --- |
| Engine | Unity 2022.3.7f1 |
| Language | C# |
| Game Type | 2D |
| Version Control | Git / GitHub |

## 📂 Main Scripts

```text
Assets/Scripts/
├─ FarmSystem.cs          # 작물 종류 / 성장 관리
├─ Inventory.cs           # 인벤토리
├─ Item.cs                # 아이템 데이터
├─ ShopSystem.cs          # 상점
├─ SellButton.cs          # 판매 처리
├─ NPCSystem.cs           # NPC 상호작용
├─ TalkManager.cs         # 대화 관리
├─ TypeEffect.cs          # 텍스트 연출
├─ PlayerController.cs    # 플레이어
├─ UIManager.cs           # UI
└─ SoundManager.cs        # 사운드
```

## 🚀 Run

1. Unity Hub에서 저장소를 프로젝트로 추가합니다.
2. **Unity 2022.3.7f1**로 엽니다.
3. Main Scene을 열고 실행합니다.

---

### 👨‍💻 Developer

**JanMatny327**  
Unity에서 여러 게임 시스템을 서로 연결하는 구조를 연습하며 제작한 프로젝트입니다.
