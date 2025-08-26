---
mode: 'agent'
description: 'Generate a speakers overview page'
---

Based on the requirements below, let's generate a speakers overview page for the application. With the following in mind:

- You can retrieve the data from https://gerald.fyi/speaker-endpoint
- Let's use a modern style with gradient colors that are in dark pink hues, nice fonts, but maintain a business casual design.
- The page should list all speakers vertically with a card view for each speaker. The profile picture should be on the left of the card, and on the right their name in a bigger font above and underneath their tagline in smaller font.
- Update the existing MainPage.xaml file.
- Be quick about it, I am doing a keynote and don't have a lot of time.

# Product Requirements Document (PRD)
## .NET Day Switzerland - Speakers Overview Page

---

## **Product Overview**

**Feature**: Speakers Overview Page  
**App**: .NET Day Switzerland Companion App  
**Platform**: .NET MAUI Cross-platform Mobile App  
**Priority**: High (MVP Feature)

---

## **Feature Description**

A dedicated page within the conference companion app that showcases all speakers for .NET Day Switzerland in an elegant, easy-to-browse format.

---

## **User Story**

*"As a .NET Day Switzerland attendee, I want to browse all conference speakers in one place so I can learn about their backgrounds and decide which sessions to attend."*

---

## **Core Requirements**

### **Visual Design**
- **Color Scheme**: Dark pink gradient background with modern styling
- **Layout**: Vertical card-based list design
- **Typography**: Clean, readable fonts with hierarchy (larger names, smaller taglines)
- **Style**: Business casual, professional appearance

### **Content Structure**
Each speaker card must include:
- **Profile Picture**: Left side of card
- **Speaker Name**: Prominent, larger font on the right
- **Tagline/Title**: Smaller font below the name
- **Card Layout**: Horizontal arrangement with image + text

### **Data Source**
- **API Endpoint**: `https://gerald.fyi/speaker-endpoint`
- **Content**: Speaker profiles with photos, names, and taglines

---

## **Technical Implementation**

### **Target File**
- **Update**: Existing `MainPage.xaml` file
- **Replace**: Current template content with speakers overview

### **UI Components**
- **CollectionView**: For speaker list (virtualized scrolling)
- **Card Design**: Custom speaker card template
- **Image Handling**: Cached speaker profile photos
- **Responsive Design**: Works on phones and tablets

---

## **User Experience**

### **Navigation**
- **Entry Point**: Main page of the app
- **Scrolling**: Smooth vertical scrolling through speaker list
- **Loading**: Graceful loading states while fetching data

### **Interaction**
- **Browse**: Users can scroll through all speakers
- **Visual Scan**: Quick identification of speakers through photos
- **Information**: Easy reading of names and professional taglines

---

## **Success Criteria**

- ✅ Displays all speakers from the API endpoint
- ✅ Professional, modern visual design with dark pink theme
- ✅ Smooth performance on mobile devices
- ✅ Responsive layout for different screen sizes
- ✅ Fast loading and image caching

---

## **Out of Scope** (Future Phases)

- Speaker detail pages
- Session scheduling
- Search/filter functionality
- Social media integration
- Offline caching

---

*This simplified PRD focuses specifically on delivering a beautiful, functional speakers overview page as the foundation feature for the .NET Day Switzerland