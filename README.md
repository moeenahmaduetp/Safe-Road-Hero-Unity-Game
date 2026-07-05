# Safe Road Hero

Safe Road Hero is a Unity 3D road safety awareness game developed by Moeen Ahmad for a semester Game Jam final lab project. The game focuses on the social issue theme of road safety and teaches that road signs and safe driving decisions help prevent accidents.

## Developer

- Moeen Ahmad (Student)
- Sir Behram Khan (Instructor)

## Repository

Repository name:

`Safe-Road-Hero-Unity-Game`

Repository description:

`Unity 3D semester Game Jam project about road safety awareness, safe driving decisions, road signs, level completion, game over flow, and a basic quiz scene.`

## Theme

- Main theme: Social Issue
- Topic: Road Safety Awareness
- Engine: Unity
- Project type: 3D game
- Team size: Individual project

## Gameplay Overview

The player drives a car through short road safety levels. Each level teaches one simple safety topic:

- Level 1: Speed limit safety
- Level 2: Turn sign safety
- Level 3: Traffic light safety
- Level 4: No U-turn safety

The player must drive safely, avoid cones, control speed in safety zones, and reach the end line. The game also includes a Safety Quiz scene for basic road sign knowledge.

## Main Flow

```text
MainMenu -> Start -> Level 1 -> Level 2 -> Level 3 -> Level 4 -> MainMenu
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

## Repository Folder Structure

This repository is uploaded as the Unity project root. Open this repository folder directly in Unity Hub.

Important folders:

- `Assets/` - scenes, scripts, UI, car, road signs, models, audio, and gameplay assets.
- `Packages/` - Unity package manifest and package lock files.
- `ProjectSettings/` - Unity project settings and build settings.
- `GSD/TH/` - road/terrain data used by the project.
- `DOCUMENTATION/` - design document and lab preparation notes, if included.

Unity may also generate files such as `.csproj`, `.sln`, `Logs/`, and `Library/`.

## Important Scenes

The active scenes are in `Assets/Scenes/`:

1. `MainMenu.unity`
2. `Level 1.unity`
3. `Level 2.unity`
4. `Level 3.unity`
5. `Level 4.unity`
6. `quiz game.unity`

These scenes should be enabled in Unity Build Settings in the same order.

## Main Scripts

- `GameManager.cs` - scene loading, restart, quit, pause, and resume.
- `Carcontroller.cs` - car movement, steering, wheel positions, speed display, and speed limit.
- `Zone.cs` - overspeed detection and Game Over panel.
- `Level.cs` - road cone collision Game Over logic.
- `End Line.cs` - level completion trigger.
- `UI.cs` - runtime-safe scene loading and reset helper.
- `ScriptQuizManger.cs` - optional quiz manager with safety checks.

## How To Open The Project

1. Clone or download this repository.
2. Open Unity Hub.
3. Click Add/Open.
4. Select the repository folder `Safe-Road-Hero-Unity-Game`.
5. Wait for Unity to import assets.
6. Open `Assets/Scenes/MainMenu.unity`.
7. Press Play.

## How To Build For Windows

1. Open the project in Unity.
2. Go to File -> Build Settings.
3. Select PC, Mac & Linux Standalone.
4. Set Target Platform to Windows.
5. Make sure the six main scenes are enabled.
6. Click Build.
7. Save the build in a separate folder outside the Unity project folder.

## Documentation

The main Game Design Document is included in Markdown format.

Use these files for review and lab preparation:

- `DOCUMENTATION/GAME_DESIGN_DOCUMENT.md`
- `DOCUMENTATION/TECHNICAL_EXPLANATION.md`
- `DOCUMENTATION/LAB_PRESENTATION_NOTES.md`
- `DOCUMENTATION/FINAL_PROJECT_REPORT.md`
- `DOCUMENTATION/SUBMISSION_CHECKLIST.md`

Before final submission, add:

- GitHub repository link
- Main Menu screenshot
- Gameplay screenshot
- Game Over screenshot
- Level Complete screenshot
- Quiz screenshot

## What Should Be Uploaded To GitHub

Required:

- `Assets/`
- `Packages/`
- `ProjectSettings/`
- `GSD/TH/`
- `README.md`
- `DOCUMENTATION/` if available

Optional but not required:

- `.csproj` files
- `.sln` file
- `Logs/`

Do not upload:

- `Library/`
- `Temp/`
- `Obj/`
- `Build/`
- `Builds/`
- `UserSettings/`
- `.DS_Store`

Keep all Unity `.meta` files because Unity needs them for asset references.

## Lab Exam Preparation

Be ready to explain:

- Why road safety was selected as the social issue.
- How the car movement works.
- How the Game Over condition works.
- How the End Line completion works.
- How Main Menu and scene navigation work.
- How the quiz scene supports road sign learning.

## Project Status

Safe Road Hero is ready for final Unity testing, GitHub submission, design document submission, and Windows build testing.
