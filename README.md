# CampusCore

## Overview

CampusCore is an enterprise-inspired College Management System being built using ASP.NET Core, C#, Entity Framework Core, and SQL Server.

The project will later evolve to include React, PostgreSQL, Redis, RabbitMQ, and Azure as part of the learning roadmap.

This project is not only a College Management System.

It is also:

* Backend Learning Journey
* Database Design Learning
* ASP.NET Core Learning
* Web API Learning
* Entity Framework Core Learning
* Authentication & Authorization Learning
* Design Pattern Learning
* Testing Learning
* Performance & Scalability Learning
* Portfolio Project
* Interview Preparation Project

---

## Project Vision

The goal of CampusCore is to learn how real enterprise applications are designed, developed, tested, deployed, and maintained.

The project starts from scratch and evolves step-by-step into a production-ready system.

Every implementation decision will be documented and committed separately to GitHub.

---

## Why This Project Exists

CampusCore is intentionally being developed from scratch in small, incremental steps.

The goal is not only to build a College Management System but also to understand:

* Why each architectural decision is made
* How enterprise applications evolve over time
* How database design impacts API design
* How testing, security, performance, and scalability are introduced gradually

Every phase is implemented, tested, documented, committed, and reviewed before moving to the next phase.

---

## Business Problem

Colleges need a centralized system to manage:

* Students
* Teachers
* Courses
* Enrollments
* Results
* Fees

CampusCore aims to solve these problems through a scalable and maintainable architecture.

---

## Technology Stack

### Backend

* C#
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server

### Future Enhancements

* PostgreSQL
* Redis
* RabbitMQ
* React
* Azure

---

## Architecture Roadmap

Phase 0 – Business Understanding

Phase 1 – Database Design

Phase 2 – Entity Creation

Phase 2A – Project Setup

Phase 3 – Entity Framework Core Setup

Phase 4 – Controllers

Phase 5 – Async / Await

Phase 6 – Service Layer

Phase 7 – Repository Pattern

Phase 8 – Service Unit Testing (xUnit + Moq)

Phase 9 – Controller Testing

Phase 10 – DTOs

Phase 11 – AutoMapper

Phase 12 – Validation

Phase 13 – Pagination, Filtering & Sorting

Phase 14 – Middleware

Phase 15 – JWT Authentication

Phase 16 – Role-Based Authorization

Phase 17 – Redis Caching

Phase 18 – RabbitMQ

Phase 19 – Integration Testing

Phase 20 – React UI

Phase 21 – PostgreSQL Migration

Phase 22 – Azure Deployment


---

## Current Project Structure

```text
CampusCore

├── CampusCore.API
│   └── Controllers
│       └── RoleController
│
├── CampusCore.Domain
│   └── Entities
│       ├── Role
│       ├── User
│       ├── Student
│       ├── Teacher
│       ├── Course
│       ├── Enrollment
│       ├── Result
│       └── Fee
│
└── CampusCore.Infrastructure
    ├── Data
    │   └── CampusCoreDbContext
    │
    ├── Configurations
    │
    └── Migrations
```

---

## Domain Model

The current domain model contains the following core entities:

* Role
* User
* Student
* Teacher
* Course
* Enrollment
* Result
* Fee

These entities represent the Phase 1 database design and establish the foundational relationships required for the CampusCore system.

---

## Entity Framework Core Setup Achievements

During Phase 3, the following tasks were completed:

* Installed Entity Framework Core packages
* Created CampusCoreDbContext
* Registered DbContext using Dependency Injection
* Configured SQL Server connection string
* Added DbSet mappings for all domain entities
* Created Initial Migration
* Generated SQL Server database from domain entities
* Configured entity relationships using Fluent API
* Resolved SQL Server multiple cascade path issues
* Configured decimal precision mappings for Fee and Result entities
* Successfully applied migrations using Update-Database

The CampusCore domain model is now fully connected to SQL Server through Entity Framework Core.

---

## Controller Implementation Achievements

During Phase 4, the following tasks were completed:

* Created RoleController
* Configured API routing using Route attribute
* Configured ApiController behavior
* Implemented HTTP POST endpoint
* Implemented HTTP GET endpoint
* Implemented HTTP GET By Id endpoint
* Implemented HTTP PUT endpoint
* Implemented HTTP DELETE endpoint
* Implemented Route Parameter handling
* Implemented resource existence validation
* Implemented update operations
* Implemented delete operations
* Injected CampusCoreDbContext using Constructor Dependency Injection
* Implemented Model Binding using Request Body
* Used IActionResult for API responses
* Successfully tested all CRUD APIs using Swagger
* Inserted Role records into SQL Server through API
* Retrieved Role records from SQL Server through API
* Updated existing Role records through API
* Deleted Role records through API

The CampusCore application can now perform complete CRUD operations for Roles through ASP.NET Core Web APIs.

---

## Current Status

### Completed

* Phase 0 – Business Understanding
* Phase 1 – Database Design
* Phase 2 – Entity Design & Creation
* Phase 2A – Project Setup
* Phase 3 – Entity Framework Core Setup
* Phase 4 – Controllers


---

## Learning Goals

Through CampusCore I aim to learn:

* Database Design
* Entity Relationships
* Clean Architecture
* Dependency Injection
* Middleware
* Repository Pattern
* Service Layer
* DTO Pattern
* Authentication
* Authorization
* Caching
* Messaging
* Cloud Deployment
* Testing
* Enterprise Application Design

---

## GitHub Commit Strategy

Every feature will follow:

Build

↓

Test

↓

Commit

↓

Document

Each commit represents a learning milestone and architectural decision.

---

## Current Milestone

### Current Milestone

Phase 4 – Controllers Completed

### Completed

✅ Business Understanding

✅ Database Design

✅ Entity Design

✅ Project Setup

✅ Domain Entity Creation

✅ Entity Relationships

✅ Entity Framework Core Setup

✅ CampusCoreDbContext Creation

✅ DbSet Registration

✅ SQL Server Connection Configuration

✅ Dependency Injection Registration

✅ Initial Migration

✅ SQL Server Database Creation

✅ Fluent API Configuration

✅ Relationship Mapping

✅ Decimal Precision Configuration

✅ Multiple Cascade Path Resolution

✅ RoleController Creation

✅ POST /api/role

✅ GET /api/role

✅ GET /api/role/{id}

✅ PUT /api/role/{id}

✅ DELETE /api/role/{id}

✅ Route Parameter Handling

✅ Resource Existence Validation

✅ CRUD API Testing

✅ Swagger API Testing


### Concepts Learned

✅ ControllerBase

✅ ApiController

✅ Attribute Routing

✅ Dependency Injection

✅ Constructor Injection

✅ DbContext

✅ DbSet

✅ Model Binding

✅ FromBody

✅ IActionResult

✅ Change Tracking

✅ Add()

✅ SaveChanges()

✅ Find()

✅ FirstOrDefault()

✅ Route Parameters

✅ HTTP Status Codes

✅ NotFound()

✅ NoContent()

✅ Update Operations

✅ Delete Operations

✅ Entity Tracking

✅ Change Detection

✅ Deferred Execution

✅ IQueryable

✅ IEnumerable

### Database Tables Generated

✅ Roles

✅ Users

✅ Students

✅ Teachers

✅ Courses

✅ Enrollments

✅ Results

✅ Fees

### Next

➡ Convert CRUD APIs to Async/Await

➡ Implement SaveChangesAsync()

➡ Implement ToListAsync()

➡ Implement FindAsync()

➡ Implement FirstOrDefaultAsync()

➡ Understand Async Request Processing

➡ Learn Thread Management in ASP.NET Core

---

## API Endpoints Implemented

### Role API

#### Create Role

POST /api/role

Creates a new role record in SQL Server.

#### Get Roles

GET /api/role

Returns all role records from SQL Server.

#### Get Role By Id

GET /api/role/{id}

Returns a specific role by its identifier.

#### Update Role

PUT /api/role/{id}

Updates an existing role record.

#### Delete Role

DELETE /api/role/{id}

Deletes an existing role record.

### Current CRUD Progress

✅ Create

✅ Read

✅ Update

✅ Delete

---

## Swagger Testing Summary

The following scenarios were successfully tested using Swagger:

### Create Role

✅ Created new role records

### Get All Roles

✅ Retrieved all role records

### Get Role By Id

✅ Retrieved existing role

✅ Returned 404 for non-existing role

### Update Role

✅ Updated existing role

✅ Returned 404 for non-existing role

### Delete Role

✅ Deleted existing role

✅ Returned 404 for non-existing role

The Role API CRUD workflow has been fully validated through Swagger and SQL Server verification.

---

## Author

Rajneesh Raj
