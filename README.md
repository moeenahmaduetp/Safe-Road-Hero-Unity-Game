# Safe Road Hero

Safe Road Hero is a simple Unity 3D road safety awareness game created for a semester Game Jam final lab project. The project is based on the social issue theme of road safety. The main message is that road signs and safe driving decisions help prevent accidents.

## Repository Name

Recommended GitHub repo name:

`safe-road-hero-unity`

Short repo description:

`Unity 3D semester Game Jam project about road safety awareness, safe driving decisions, road signs, level completion, game over flow, and a basic quiz scene.`

## Theme

- Main theme: Social Issue
- Topic: Road Safety Awareness
- Engine: Unity only
- Project type: 3D game
- Team size: Individual project

## Gameplay

The player drives a car through short road safety levels. Each level teaches one simple road safety topic:

- Level 1: Speed limit safety
- Level 2: Turn sign safety
- Level 3: Traffic light safety
- Level 4: No U-turn safety

The player must drive safely, avoid road cones, control speed in safety zones, and reach the end line. The game also includes a Safety Quiz scene for basic road sign knowledge.

## Main Flow

```text
MainMenu -> Start Drive -> Level 1 -> Level 2 -> Level 3 -> Level 4 -> MainMenu
```

Quiz flow:

```text
MainMenu -> Safety Quiz -> MainMenu
```

## Features

- Main Menu
- Level selection
- Four playable 3D driving levels
- Road safety educational text
- Speed zone Game Over logic
- Road cone collision Game Over logic
- Level Complete screens
- Replay and Main Menu buttons
- Basic Safety Quiz scene
- Audio assets and AudioSource components
- Windows build-ready scene setup

## Controls

- `W` / Up Arrow: Accelerate
- `S` / Down Arrow: Reverse or brake
- `A` / Left Arrow: Steer left
- `D` / Right Arrow: Steer right

## Unity Version

Unity 2022.3.62f3

Open the `Project` folder in Unity Hub.

## Important Scenes

The active scenes are:

1. `Project/Assets/Scenes/MainMenu.unity`
2. `Project/Assets/Scenes/Level 1.unity`
3. `Project/Assets/Scenes/Level 2.unity`
4. `Project/Assets/Scenes/Level 3.unity`
5. `Project/Assets/Scenes/Level 4.unity`
6. `Project/Assets/Scenes/quiz game.unity`

These scenes should be enabled in Build Settings in the same order.

## Main Scripts

- `GameManager.cs` - scene loading, restart, quit, pause, and resume.
- `Carcontroller.cs` - car movement, steering, wheel positions, speed display, and speed limit.
- `Zone.cs` - overspeed detection and Game Over panel.
- `Level.cs` - road cone collision Game Over logic.
- `End Line.cs` - level completion trigger.
- `UI.cs` - runtime-safe scene loading and reset helper.
- `ScriptQuizManger.cs` - optional quiz manager with safety checks.

## How To Open

1. Clone or download this repository.
2. Open Unity Hub.
3. Click Add/Open.
4. Select the `Project` folder.
5. Open `Assets/Scenes/MainMenu.unity`.
6. Press Play.

## How To Build For Windows

1. Open the project in Unity.
2. Go to File -> Build Settings.
3. Select PC, Mac & Linux Standalone.
4. Set Target Platform to Windows.
5. Make sure the six main scenes are enabled.
6. Click Build.
7. Save the build in a separate folder outside the Unity project folder.

## Submission Documents

The required design document and preparation notes are in `DOCUMENTATION/`.

- `GAME_DESIGN_DOCUMENT.md`
- `GAME_DESIGN_DOCUMENT.docx`
- `TECHNICAL_EXPLANATION.md`
- `LAB_PRESENTATION_NOTES.md`
- `FINAL_PROJECT_REPORT.md`
- `SUBMISSION_CHECKLIST.md`

Before final submission, add your GitHub repository link and screenshots to the Game Design Document. A Word version is already available as `DOCUMENTATION/GAME_DESIGN_DOCUMENT.docx`.

## What To Upload To GitHub

Upload:

- `README.md`
- `.gitignore`
- `DOCUMENTATION/`
- `Project/Assets/`
- `Project/GSD/`
- `Project/Packages/`
- `Project/ProjectSettings/`

Keep all Unity `.meta` files. Unity uses them to preserve asset references.

Do not upload:

- `Project/Library/`
- `Project/Temp/`
- `Project/Obj/`
- `Project/Logs/`
- `Project/UserSettings/`
- build output folders
- `.DS_Store`
- Visual Studio/Rider generated files

## Team

- Moeen Ahmad (Student)
- Sir Behram Khan (Instructor)

## Status

The project is ready for final Unity testing, design document export, and Windows build testing.
