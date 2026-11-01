# 🪙 COIN COLLECTOR
### Catch Coins. Dodge Bombs. Beat the Score.

A Unity-powered 2D arcade experience built with C#, featuring fast-paced object collection, obstacle avoidance, and score-based gameplay.

---

## 🎮 THE GAME

Think fast, move faster!

Coins and bombs continuously drop from the top of the screen. Your job is to control the catcher, grab as many coins as possible, and stay away from explosive obstacles.

You have three lives and one goal: **collect 20 coins to claim victory.**

## ⚡ GAMEPLAY AT A GLANCE

| Parameter | Details |
|:---|:---|
| Game Type | 2D Arcade |
| Engine | Unity 6 |
| Programming Language | C# |
| Player Lives | 3 |
| Winning Score | 20 Coins |
| Movement | Horizontal |
| Physics | Unity 2D |

## 🕹️ HOW TO PLAY

**Movement Controls**

| Keyboard Input | Player Movement |
|:---:|:---|
| ⬅️ | Move Left |
| ➡️ | Move Right |

**Your Mission**

1. Watch for objects falling from above.
2. Position your catcher beneath incoming coins.
3. Avoid bombs to protect your remaining lives.
4. Accumulate 20 points before losing all three lives.

## 💥 GAME MECHANICS

- 🪙 **Coin Collection:** Successfully catching a coin adds one point.
- 💣 **Bomb Collision:** Coming into contact with a bomb costs one life.
- ❤️ **Life Counter:** The player starts each round with three lives.
- 🎯 **Score Target:** Reaching 20 points triggers the victory state.
- 🏁 **End States:** The game displays the appropriate victory or game-over screen depending on the outcome.

## 🧩 UNDER THE HOOD

The project is divided into multiple scripts and asset categories, keeping gameplay functionality organized.

| Component | Responsibility |
|:---|:---|
| `Catcher.cs` | Handles player movement |
| `FallingObject.cs` | Controls falling object behaviour |
| `GameManager.cs` | Manages score, lives, and game states |
| `ObjectSpawner.cs` | Generates coins and bombs |

**Development Tools**

- Unity 6 – Scene creation and game development
- C# – Gameplay implementation
- TextMeshPro – Interface and text elements
- Unity 2D Physics – Trigger-based interactions
- Git – Source code management

## 📦 FILE ORGANIZATION

```text
Coin_Collector_Game
│
├── Assets
│   ├── Prefabs
│   │   ├── coin.prefab
│   │   └── bomb.prefab
│   │
│   ├── Scenes
│   │   └── Main.unity
│   │
│   ├── Scripts
│   │   ├── Catcher.cs
│   │   ├── FallingObject.cs
│   │   ├── GameManager.cs
│   │   └── ObjectSpawner.cs
│   │
│   ├── Sprites
│   └── TextMesh Pro
│
├── Packages
├── ProjectSettings
└── README.md
```

## 🚀 GETTING STARTED

Want to run the game on your machine?

**Requirements**
- Unity Hub
- Unity 6 Editor
- Git

**Setup**

```bash
git clone <YOUR_GITHUB_REPOSITORY_URL>
```

1. Open Unity Hub.
2. Import the downloaded project using **Add Project from Disk**.
3. Wait for Unity to finish importing the required assets.
4. Navigate to `Assets/Scenes/Main.unity`.
5. Open the scene and hit **Play**.

That's it. You're ready to play!

---

## 👨‍💻 PROJECT INFORMATION

**Created by:** Rakshit Saini

**Program:** B.Tech – Computer Science and Engineering (AI & ML)

**Project Category:** 2D Game Development

---
