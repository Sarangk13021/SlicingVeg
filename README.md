# 🥕 Slicing Vegetable Machine - Unity Game

# A 3D interactive vegetable cutting simulator built with Unity, featuring realistic knife mechanics, physics-based cutting, and dynamic vegetable spawning.

# 

# 📋 Project Overview

# Unity game simulating a vegetable cutting machine where players slice vegetables (carrots, cucumbers) with realistic physics interactions.

# 

# 🎯 Key Features

# Knife Movement: WASD controls with smooth positioning

# 

# Physics Cutting: Space bar cutting with collision detection

# 

# Multiple Vegetables: Carrot and cucumber spawning

# 

# Piece Collection: X key to drag cut pieces

# 

# UI Integration: Button-based spawning system

# 

# 🎮 Controls

# Input	Action

# W/A/S/D	Move knife

# Space	Cut vegetables

# X (Hold)	Drag cut pieces

# UI Buttons	Spawn vegetables

# 🛠️ Technical Implementation

# Core Scripts

# KnifeController.cs - Knife movement and controls

# 

# CuttingScript.cs - Cutting detection logic

# 

# Vegitables.cs - Individual vegetable behavior

# 

# SpwaningScript.cs - Vegetable spawning management

# 

# Key Systems

# Rigidbody Physics for realistic movement

# 

# Collision Detection for cutting mechanics

# 

# Animation System for cutting effects

# 

# UI System with EventSystem management

# 

# ⚙️ Setup

# Open project in Unity 2022.3+

# 

# Load VegetableCuttingScene

# 

# Press Play to start

# 

# Scene Structure

# text

# 🎬 Scene:

# ├── 🔪 Knife (KnifeController + Colliders)

# ├── 🥕 Spawn Points  

# ├── 📱 UI Canvas

# └── 🏠 Collection Area

# 🐛 Troubleshooting

# Problem	Solution

# Knife passes through vegetables	Set collision detection to "Continuous Dynamic"

# Spacebar spawns vegetables	Add EventSystem.current.SetSelectedGameObject(null)

# Vegetables spawn vertically	Use Quaternion.Euler(90,0,0) rotation

# 📈 Future Features

# &nbsp;More vegetable types

# 

# &nbsp;Scoring system

# 

# &nbsp;Sound effects

# 

# &nbsp;Time challenges

# 



