# Ticket Management System Challenge

## Introduction

Welcome to the Ticket Management System development challenge. This challenge will evaluate your skills in developing RESTful APIs and mobile applications with .NET MAUI.

The challenge consists of two main parts:
1. Backend API: Implementation and enhancement of endpoints to manage tickets
2. MAUI Application: Development of an interface to list and filter tickets

## Part 1: Backend API

In this part, you must implement a REST API endpoint for support ticket management. You have already been provided with part of the base code that you need to complete.

The base code is using **EntityFramework** and **SqLite**. Everything is already configure for you to be able to use it.

### Requirements

You must implement the following endpoint:

```
GET /api/tickets
```

This endpoint should return a paginated list of tickets, with the ability to filter by status and sort by creation date. 

### Expected Features

- Filtering by ticket status (In Progress, Open, Closed)
- Ascending or descending sorting by creation date
- Pagination of results

## Part 2: MAUI Application (.NET Multi-platform App UI)

You must develop windows desktop application following the design provided in the diagram, which consumes the API endpoint implemented in part 1

### Proposed UI Diagram
![UI Diagram](./img/UI.png)

### Requirements

The application must include:

1. **Filter Panel**:
   - Status selector (In Progress, Open, Closed)
   - Sort order selector (Asc, Desc)
   - Button to apply filters

2. **Ticket List**:
   - Display basic information for each ticket
   - Integrate with the GET endpoint implemented in part 1
   - Properly handle the display of results

3. **Additional Features (optional)**:
   - Implement pagination of results

## Additional details
You can ask any questions to the people accompanying you in the interview.


## Project Setup

The repository already contains the base structure of both projects. You should work on these existing projects without modifying the main structure.

To get started:
1. Clone the repository
2. Review the base projects and additional documentation
3. Implement the required features

Good luck!