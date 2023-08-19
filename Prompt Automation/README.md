# Song Prompt Automation

This is a simple Windows Forms app to help automate entering prompt text for songs as part of a lyrics generation project.

## Overview

The application allows selecting a folder containing JSON song files. It scans the files and separates them into two lists - songs with prompts and without prompts.

The user can then:

- Select a song file without prompt
- Enter title, lyrics, and prompt text
- Save to a new JSON file in an output folder

This automates the process of manually adding prompt text to each song file.

## Usage

- Build and run the app
- Click "Select Directory" and choose the folder with song JSON files 
- The files are split into two list boxes - with and without prompts
- Select a file from "Songs Without Prompts"
- Enter title, lyrics, prompt text
- Click "Save Prompt" to save to output folder
- File is moved out of without prompt list into output

## Implementation

- C# Windows Forms app with listbox, textboxes, buttons etc
- Uses System.IO for file operations
- System.Text.Json for serializing and deserializing JSON 
- Model classes to match JSON structure

## Customizing

The core logic is in Form1.cs. Can be customized:

- Model class properties
- Output folder name
- JSON serialization
- File search filters

## Future Improvements

- Add ability to edit existing prompt text
- Multiple prompt support
- Support other file types like text
- Batch prompt add instead of per-file
