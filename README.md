# Cocktail Menu - UWP

## Overview

This repository contains a simple cocktail recipes menu application completed as work for Mobile Applications Development module. The application employs the Universal Windows Platform application architecture. The makes for a dynamic and responsive application design across a number of Windows 10 devices including Windows Phone, Desktop, Tablet, Xbox and even the Hololens.

## Model-View-ViewModel

The application utilizes the Model-View-ViewModel design pattern or more commonly referred to as MVVM. MVVM is essentially a Microsoft alternative to the traditional Model View Controller (MVC) design pattern. It facilitates a simple separation of concerns for an application that contains a graphical user-interface.

### MVVM Components

#### Model
- Model refers either to a domain model, which represents application state (an object-oriented approach), or to the data access layer, which represents fetching content from a source of data.

#### View
- The View refers to the User-Interface of the application. The layout and structure of what is presented to the user on their screens. In the case of Universal Windows Platform the view is composed of XAML templates.

#### ViewModel
- The ViewModel acts as an intermediary between the view and the model, and is responsible for handling the view logic. It is employed to encapsulate the relationship between the Model and the View.

## The Cocktail DB

This applications makes use of a public open-source database called the [TheCocktailDB](http://www.thecocktaildb.com/) which offers a free JSON API for consuming the data. The API offers a number of end points for making requests. This applications makes use of two of the end points offers by the JSON API.

#### Search by Name
```
http://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita
```

#### Random
```
http://www.thecocktaildb.com/api/json/v1/1/random.php
```

## Project Specification

### Instructions

Create a Windows 10 UWP App. The application should incorporate the following elements:

- A responsive UI across the Windows 10 devices. There are some available for testing and this includes the IoT core, mobile devices, tablet and PC. This includes Visual State Management and using available SDKs for individual device types.
- A UI that has been well designed and is fit for purpose. User Experience should be carefully considered while developing the application. The User Experience should be consistent across devices.
- Mobile services for data storage and retrieval. The cloud service does not have to be written in C# to be able to interact with a UWP. The preferred cloud to use is Azure.
- Use of the MVVM design pattern in the development approach.
