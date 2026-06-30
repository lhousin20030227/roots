# ROOTS_DIRECTOR/05_STANDARDS/NAMING_STANDARD.md

# ROOTS — NAMING STANDARD

Version: 1.0

---

# PURPOSE

Define one universal naming convention for the entire ROOTS project.

Every file, folder, asset, script, scene, document and AI output must follow these rules.

---

# GENERAL RULES

Use English only.

Use descriptive names.

Keep names short and meaningful.

No spaces.

No special characters.

No duplicate names.

Do not use temporary names.

---

# LETTER CASE

Folders

PascalCase

Example

Inventory

Gameplay

Dialogue

---

Files

PascalCase

Examples

StoryBible.md

InventorySystem.cs

HouseScene.unity

---

# SCRIPTS

Format

<Entity><Purpose>

Examples

PlayerController.cs

InventoryManager.cs

DialogueSystem.cs

SaveManager.cs

---

# CLASSES

PascalCase

Examples

GameManager

EvidenceDatabase

PhotoViewer

---

# INTERFACES

Prefix

I

Examples

IInteractable

ISaveable

IAudioPlayer

---

# METHODS

PascalCase

Examples

OpenDoor()

LoadGame()

CollectEvidence()

PlayAudio()

---

# VARIABLES

camelCase

Examples

playerName

currentObjective

selectedItem

---

# PRIVATE VARIABLES

Prefix

_

Examples

_player

_inventory

_currentScene

---

# BOOLEANS

Prefix

is

has

can

should

Examples

isLocked

hasKey

canOpen

shouldSave

---

# CONSTANTS

UPPER_CASE

Examples

MAX_SAVE_SLOTS

DEFAULT_VOLUME

TARGET_FPS

---

# ENUMS

PascalCase

Examples

GameState

DoorState

PuzzleState

---

# ENUM VALUES

PascalCase

Examples

Locked

Unlocked

Completed

Hidden

---

# EVENTS

Prefix

On

Examples

OnDoorOpened

OnEvidenceCollected

OnGameSaved

---

# SCENES

Prefix

SCN_

Examples

SCN_MainMenu

SCN_House

SCN_Hospital

SCN_Cemetery

---

# PREFABS

Suffix

Prefab

Examples

DoorPrefab

ChairPrefab

PhotoPrefab

---

# MATERIALS

Prefix

MAT_

Examples

MAT_Wood

MAT_Glass

MAT_Metal

---

# TEXTURES

Prefix

TEX_

Examples

TEX_Wood01

TEX_Brick02

TEX_Floor03

---

# SPRITES

Prefix

SPR_

Examples

SPR_Inventory

SPR_Key

SPR_Button

---

# AUDIO

Music

MUS_

Ambience

AMB_

SFX

SFX_

Voice

VO_

Examples

MUS_Menu

AMB_HouseNight

SFX_DoorOpen

VO_Father01

---

# ANIMATIONS

Prefix

AN_

Examples

AN_OpenDoor

AN_PlayerWalk

---

# UI

Prefix

UI_

Examples

UI_MainMenu

UI_Inventory

UI_Settings

---

# DOCUMENTS

Prefix

DOC_

Examples

DOC_AdoptionPaper

DOC_HospitalReport

DOC_FamilyLetter

---

# PHOTOS

Prefix

PHOTO_

Examples

PHOTO_Family01

PHOTO_HouseFront

---

# EVIDENCE

Prefix

EV_

Examples

EV_Key01

EV_Letter02

EV_Record03

---

# SCRIPTABLE OBJECTS

Suffix

Data

Config

Database

Examples

PlayerData

AudioConfig

EvidenceDatabase

---

# TASKS

TASK-0001

TASK-0002

TASK-0003

---

# COMMITS

[TASK-ID] Short Description

Example

[TASK-0021] Implement inventory system

---

# FORBIDDEN

Spaces

Special characters

Mixed languages

Temporary names

Copy

Copy1

New

Final

Final2

Test

Object1

Scene1

---

# QUALITY CHECK

Every name must be:

Readable

Unique

Descriptive

Consistent

Searchable

Production-ready

---

# MASTER RULE

If someone cannot understand what a file or asset contains by reading its name alone, rename it before merging into the project.
