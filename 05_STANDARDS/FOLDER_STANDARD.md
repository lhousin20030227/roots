# ROOTS_DIRECTOR/05_STANDARDS/FOLDER_STANDARD.md

# ROOTS — FOLDER STANDARD

Version: 1.0

---

# PURPOSE

Define the official folder structure for the ROOTS project.

Every AI Agent must follow this structure.

No agent may create arbitrary folders.

---

# ROOT STRUCTURE

```text
ROOTS/

├── Assets/
├── Packages/
├── ProjectSettings/
├── UserSettings/
├── Docs/
├── Tools/
├── Builds/
├── Backups/
├── AI/
└── README.md
```

---

# ASSETS

```text
Assets/

├── _Project/
├── Art/
├── Audio/
├── Materials/
├── Models/
├── Prefabs/
├── Resources/
├── Scenes/
├── Scripts/
├── Settings/
├── Shaders/
├── Sprites/
├── StreamingAssets/
├── Textures/
├── UI/
└── ThirdParty/
```

---

# _PROJECT

```text
_Project/

├── Config/
├── Databases/
├── Managers/
├── ScriptableObjects/
├── Systems/
├── Utilities/
└── Bootstrap/
```

---

# SCRIPTS

```text
Scripts/

├── Core/
├── Gameplay/
├── Player/
├── Interaction/
├── Inventory/
├── Evidence/
├── Dialogue/
├── Save/
├── Audio/
├── UI/
├── Camera/
├── Input/
├── Environment/
├── Debug/
├── Editor/
└── Tests/
```

---

# SCENES

```text
Scenes/

├── Bootstrap/
├── MainMenu/
├── House/
├── Hospital/
├── Archive/
├── TownHall/
├── Cemetery/
├── FatherHouse/
└── Testing/
```

---

# PREFABS

```text
Prefabs/

├── Characters/
├── Environment/
├── Furniture/
├── Props/
├── Doors/
├── UI/
├── Items/
└── Effects/
```

---

# MODELS

```text
Models/

├── Architecture/
├── Characters/
├── Furniture/
├── Props/
├── Nature/
└── Vehicles/
```

---

# TEXTURES

```text
Textures/

├── Environment/
├── Characters/
├── Props/
├── UI/
├── Decals/
└── Atlases/
```

---

# AUDIO

```text
Audio/

├── Ambience/
├── Music/
├── SFX/
├── Voice/
├── AudioLogs/
└── Mixers/
```

---

# UI

```text
UI/

├── Icons/
├── Fonts/
├── Panels/
├── Menus/
├── Inventory/
├── EvidenceBoard/
└── Settings/
```

---

# DOCS

```text
Docs/

├── Story/
├── Gameplay/
├── Art/
├── Audio/
├── Unity/
├── QA/
├── Tasks/
└── Release/
```

---

# AI

```text
AI/

├── Prompts/
├── Tasks/
├── Reviews/
├── Outputs/
└── Logs/
```

---

# BUILDS

```text
Builds/

├── Development/
├── Testing/
└── Release/
```

---

# BACKUPS

```text
Backups/

├── Daily/
├── Weekly/
└── Milestones/
```

---

# THIRD PARTY

Store only approved external assets and plugins.

Every package must include:

* License
* Version
* Source
* Documentation

---

# FORBIDDEN

* Random folders.
* Duplicate folders.
* Mixed asset categories.
* Personal folders.
* Temporary folders.
* Files outside their category.

---

# QUALITY CHECK

Every folder must:

* Have a clear purpose.
* Contain related files only.
* Follow the naming standard.
* Avoid unnecessary nesting.
* Remain easy to navigate.

---

# MASTER RULE

If a file does not clearly belong to a folder, create a task to review the project structure instead of placing it in a random location.
