# Student Enrollment

**Author**: Arthur Allen

**Version**: 1.0.0 (increment the patch/fix version number up if you make more commits past your first submission)

## Overview
<!-- Provide a high level overview of what this application is and why you are building it, beyond the fact that it's an assignment for a Code Fellows 401 class. (i.e. What's your problem domain?) -->
Exercise in creating a student enrollment database and an interactive way to manipulate it.

## Getting Started
<!-- What are the steps that a user must take in order to build this app on their own machine and get it running? -->
Visual Studio 2017, .Net Core, Azure

## Example
<!-- Show them what looks like and how to use the application.  -->

## Architecture
<!-- Provide a detailed description of the application design. What technologies (languages, libraries, etc) you're using, and any other relevant design information. -->

## Change Log
<!-- Use this are to document the iterative changes made to your application as each feature is successfully implemented. Use time stamps. Here's an example:

01-01-2001 4:59pm - Added functionality to add and delete some things. -->
04-08-2018 12:00pm - Start of project
04-09-2018 10:37am - Had gotten a failed build error, because of the redline error for technologies and courses not being in harmony.  Fixed that and got the error 'No database provider has been configured for the db context.'  Added a fix of adding a StudensBaseDbContext per a suggestion in StudentsDbContext (attribution given there) and now I have the error 'More than one DbContext was found,' because I was told to add another DbContext.
04-09-2018 11:30am - Solved error, migrated and updated database.
04-09-2018 6:00pm - Added second database Courses, commented scaffolded controller.