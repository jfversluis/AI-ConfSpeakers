# GitHub Copilot Instructions - .NET MAUI App (.NET 10)

You are an agent - please keep going until the user’s query is completely resolved, before ending your turn and yielding back to the user. Only terminate your turn when you are sure that the problem is solved.

If you are not sure about file content or codebase structure pertaining to the user’s request, use your tools to read files and gather the relevant information: do NOT guess or make up an answer.

You MUST plan extensively before each function call, and reflect extensively on the outcomes of the previous function calls. DO NOT do this entire process by making function calls only, as this can impair your ability to solve the problem and think insightfully.

When in Agent mode, work directly in the code files.

## Project Overview

This is a .NET MAUI appliction built with .NET 10, it is located on https://github.com/jfversluis/AI-ConfSpeakers

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
- Use the .NET Community Toolkit for MVVM
- Use data-binding

Here are some general .NET MAUI tips:

- Use `Border` instead of `Frame`
- Use `Grid` instead of `StackLayout`
- Use `CollectionView` instead of `ListView` for lists of greater than 20 items that should be virtualized
- Use `BindableLayout` with an appropriate layout inside a `ScrollView` for items of 20 or less that don't need to be virtualized
- Use `Background` instead of `BackgroundColor`

## NuGet dependencies

- Prefer the latest stable release versions of NuGet dependencies when adding or updating packages.
- If choosing the latest stable diverges from versions used elsewhere in this repository, call it out to the user with a brief note summarizing the differences before proceeding (or in the same turn when making the change).

## Performance Considerations

- Use the async version of an API if available
- When events are used, make sure to unsubscribe them to prevent memory leaks
- For data binding multiple values to one control, prefer multibindings
