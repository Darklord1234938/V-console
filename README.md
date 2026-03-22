# V-CONSOLE
 
A custom virtual game console built from scratch in C#.
 
---
 
## What is it?
 
V-Console is a software emulation of a fictional game console — designed and built entirely from scratch. Every component is implemented manually: the GPU, RAM, ROM, APU, input controller and CPU. No emulation frameworks or libraries — just C# and computer architecture knowledge.
 
The project is inspired by real hardware like the NES and Atari 2600, combined with modern software design patterns.
 
---
 
## Architecture
 
```
┌─────────────┐    ┌─────────────┐    ┌─────────────┐
│     CPU     │───▶│     RAM     │    │     ROM     │
│  Fetch/     │    │   8KB       │    │   32KB      │
│  Decode/    │    └─────────────┘    └─────────────┘
│  Execute    │
└──────┬──────┘
       │
       ▼
┌─────────────┐    ┌─────────────┐    ┌─────────────┐
│     GPU     │    │     APU     │    │    INPUT    │
│  RGB565     │    │   Audio     │    │ Controller  │
│  16384px    │    │ Processing  │    │             │
│  Framebuffer│    └─────────────┘    └─────────────┘
└─────────────┘
```
 
---
 
## Components
 
### GPU
- 128x128 pixel framebuffer (16,384 pixels)
- RGB565 color encoding — 5 bits red, 6 bits green, 5 bits blue
- VRAM with direct pixel read/write access
- Bitmap rendering pipeline to WinForms PictureBox
 
### Memory
- 8KB RAM — general purpose read/write memory
- 32KB ROM — program storage
- Direct address access via `ushort` addressing
 
### CPU *(in progress)*
- Fetch/decode/execute cycle
- Program counter with byte and word fetch
- CPU flags — Zero, Carry, Negative, Overflow
- Hex memory dump for debugging
 
### APU *(planned)*
- Audio processing unit
- Sound channel support
 
### Input Controller *(planned)*
- Keyboard/gamepad input mapping
 
---
 
## Color System
 
V-Console uses **RGB565** color encoding — the same format used in many real embedded displays and retro hardware:
 
```
Bit:  15 14 13 12 11 | 10 9 8 7 6 5 | 4 3 2 1 0
      R  R  R  R  R  |  G G G G G G | B B B B B
      5 bits red      6 bits green    5 bits blue
```
 
Each pixel is stored as a `ushort` (16-bit unsigned integer) in VRAM.
 
---
 
## Tech Stack
 
- **Language:** C#
- **Framework:** .NET / WinForms
- **IDE:** Visual Studio
 
---
 
## Project Status
 
| Component | Status |
|-----------|--------|
| GPU | ✅ Working |
| RAM | ✅ Working |
| ROM | ✅ Working |
| ConsoleRedirect | ✅ Working |
| CPU | 🔄 In progress |
| APU | 📋 Planned |
| Input Controller | 📋 Planned |
 
---
 
## What I Learned
 
- How real GPU framebuffers work at a memory level
- RGB565 color encoding and bit manipulation
- Thread-safe UI updates in WinForms with `InvokeRequired`
- Memory architecture of real game consoles
- How CPUs execute instructions at a low level
 
---
 
## Related Projects
 
- [QiByte](../QiByte) — Stack-based virtual machine that may serve as V-Console's scripting language
- [CPU Emulator](../CPU) — Standalone CPU implementation feeding into V-Console
 
---
 
## Author
 
**Quidon Roethof** — Software Developer, Netherlands
 
