# NAMING CONVENTION

## Purpose

This document defines the naming standards for every file, folder, asset, scene, script, and resource used in ROOTS.

Consistent naming improves readability, organization, and collaboration.

---

# General Rules

Every name must be:

* Clear
* Descriptive
* Consistent
* Short when possible
* Written in English

Use only:

* Lowercase letters (`a-z`)
* Numbers (`0-9`)
* Underscores (`_`)

Do **not** use:

* Spaces
* Special characters
* Accents
* Mixed casing

---

# Folder Names

Examples:

```text
characters
environments
materials
textures
audio
ui
scripts
scenes
props
```

---

# File Names

Format:

```text
object_name_variant.extension
```

Examples:

```text
family_photo_01.png
hospital_room_a.glb
wooden_door_old.glb
medical_record_03.pdf
```

---

# Scene Names

Prefix:

```text
sc_
```

Examples:

```text
sc_main_menu
sc_family_house
sc_hospital
sc_archive_room
```

---

# Script Names

Prefix:

```text
scr_
```

Examples:

```text
scr_player
scr_inventory
scr_dialogue
scr_door
```

---

# Prefabs / Packed Scenes

Prefix:

```text
pf_
```

Examples:

```text
pf_wooden_chair
pf_family_photo
pf_hospital_bed
```

---

# Materials

Prefix:

```text
mat_
```

Examples:

```text
mat_wood_oak
mat_concrete_old
mat_glass_clear
```

---

# Textures

Prefixes:

```text
tx_
```

Examples:

```text
tx_wood_oak_albedo
tx_wood_oak_normal
tx_wood_oak_roughness
tx_wall_concrete_01
```

---

# Audio

Prefixes:

```text
sfx_
amb_
msc_
vo_
```

Examples:

```text
sfx_door_open
amb_rain_heavy
msc_main_theme
vo_father_intro
```

---

# Animations

Prefix:

```text
anim_
```

Examples:

```text
anim_walk
anim_idle
anim_open_door
anim_pickup_item
```

---

# UI Assets

Prefix:

```text
ui_
```

Examples:

```text
ui_button_primary
ui_inventory_panel
ui_icon_save
```

---

# Variables

Use:

```text
snake_case
```

Example:

```text
player_speed
current_objective
inventory_items
```

---

# Constants

Use:

```text
UPPER_CASE
```

Examples:

```text
MAX_INVENTORY_SIZE
DEFAULT_FOV
SAVE_VERSION
```

---

# Versioning

Working files:

```text
house_v01
house_v02
house_v03
```

Approved file:

```text
house_final
```

---

# Forbidden Names

Avoid names such as:

```text
new
test
temp
object1
final_final
copy
untitled
```

Every name should immediately describe its purpose.

---

# Final Rule

A developer or AI should understand what a file contains simply by reading its name. Clear naming reduces mistakes, improves collaboration, and keeps the ROOTS project organized as it grows.
