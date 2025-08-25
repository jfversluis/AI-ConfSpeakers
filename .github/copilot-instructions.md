# GitHub Copilot Instructions - .NET MAUI App (.NET 10)

## Project Overview

This is a .NET MAUI appliction built with .NET 10.

it is located on https://github.com/jfversluis/AI-ConfSpeakers

The application follows modern best practices for .NET MAUI development.

All code for the frontend is loctated in the ConfSpeakersMaui folder

## Coding Standards

- Use C# 12 features where appropriate
- Implement component-based architecture
- Follow SOLID principles
- Follow DRY principles
- Use nullable reference types
- Prefer async/await for asynchronous operations
- Prefer `is null` over `== null` (and of course for the inverse also)
- Prefer opening and closing braces for everything

## .NET MAUI Best Practices

- Make sure to not use deprecated or obsoleted APIs
- Try to avoid nesting layouts as much as possible. Prefer to use a Grid over nested StackLayouts
- Use the MVVM pattern
- Use data-binding
- 

## Performance Considerations

- Use the async version of an API if available
- When events are used, make sure to unsubscribe them to prevent memory leaks
- For data binding multiple values to one control, prefer multibindings
