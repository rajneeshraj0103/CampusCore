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

Phase 5 – Services

Phase 6 – Async / Await

Phase 7 – Repository Pattern

Phase 8 – Unit Testing (xUnit + Moq)

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

---

## Current Project Structure

```text
CampusCore

├── CampusCore.API
│   └── Middleware
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
    └── Configurations
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

## Current Status

### Completed

* Phase 0 – Business Understanding
* Phase 1 – Database Design
* Phase 2 – Entity Design
* Phase 2 – Entity Creation
* Phase 2A – Project Setup

### In Progress

* Phase 3 – Entity Framework Core Setup

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

### Current Commit

Domain Entities & Relationships

### Completed

✅ Business Understanding

✅ Database Design

✅ Entity Design

✅ Project Setup

✅ Domain Entity Creation

✅ Entity Relationships

### Domain Entities

✅ Role

✅ User

✅ Student

✅ Teacher

✅ Course

✅ Enrollment

✅ Result

✅ Fee

### Next

➡ Entity Framework Core Setup

➡ CampusCoreDbContext Creation

➡ SQL Server Connection Configuration

➡ Initial Migration

---

## Author

Rajneesh Raj
