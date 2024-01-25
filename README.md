# Madcamp_Week4

# Fight Till Death : Battle of Legends 

### 👥 Developers
- 안희웅: 고려대학교 컴퓨터학과 19학번
- 손다윤: KAIST 산업 및 시스템공학과 18학번

### 💻 Programming Tools & Programming Language
- Unity Engine
- C#

## 📢 Description

***Summary***
몰입캠프 4주차 유니티 게임 제작 프로젝트입니다.

### 📱 Introduction
Fight Till Death는 키보드 한 개로 두 명이 함께 즐길 수 있는 2인용 격투 게임입니다. 최대 세 번의 연계가 가능한 주먹 공격, 두 번의 연계가 가능한 발차기, 상대의 공격을 막아내는 가드와 가드를 무시하는 공격을 적재적소에 활용하여 상대를 쓰러뜨려 보세요!

### ✌️ Behind the scene

### Animations
mixamo.com 의 무료 3D 모델링과 Unity Asset Store의 무료 3D 모델을 사용하여 사용하고 싶은 동작 다운로드 후 프레임 및 속도를 수정하여 격투 애니메이션으로 사용하였습니다.   
![kick gif](https://github.com/kesler1202/Madcamp_Week4/assets/80826652/90e44543-4a81-488b-b1d9-e282fe34516e)
### Animator
Unity의 Animator를 적극 활용하여, 각 모션 사이를 Trigger와 Boolean type를 조건으로 하는 transition을 만들어 연결해주었습니다. 

### Collider
각 격투 동작에 해당하는 부분(손, 발)에 Collider를 만들고, 적의 Collider와 충돌 시 동시에 판정이 들어가지 않고 먼저 누른 쪽에 우선순위를 부여하여 타격 판정을 내리도록 했습니다.
-예를 들어, 플레이어에 적용된 script에서 발차기 동작 애니메이션을 실행 시 발에 별개로 적용된 script 내부 함수를 실행시켜 발차기 동작 애니메이션 프레임을 밀리 초 단위로 계산하여 발에 따로 달린 collider를 활성화/비활성화 했습니다.

### Game Play

### Start Scene

### In-Game Scene
1. HP Bar
2. Stamina Bar (Dodge 쿨다운 표시)
3. Time Clock (시간 제한)
   
### Training Scene
‘1’번을 누르면 플레이 매뉴얼을 볼 수 있게 했습니다.
트레이닝 Scene을 따로 만들어 전투 동작을 연습 할 수 있게 했습니다. 

### Source
- [mixamo.com](http://mixamo.com) (플레이어 모션 출처)
- [freesound.org](http://freesound.org) (효과음 출처)
- [pixabay.com](http://pixabay.com) (배경음 출처)
- Unity Assets Store
    - Fighter Pack Bundle FREE (Berserker Fighter 외형을 가져와 사용했습니다.)
    - Lightbulb (전구 모양 사용)
    - SDF_Basic TrainingStage

### 깃헙 링크
https://github.com/kesler1202/Madcamp_Week4

### 폴더 링크
https://drive.google.com/drive/folders/1C6tFBKkZhZ_c4TaHmczzpBASf2eOFJhi?usp=drive_link
